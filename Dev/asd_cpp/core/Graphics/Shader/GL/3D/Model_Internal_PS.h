﻿static const char* model_internal_ps_gl = R"(

//<|| モデル共通レジスタ
uniform sampler2D g_colorTexture;
//>||

uniform sampler2D g_normalTexture;
uniform sampler2D g_metalnessTexture;
uniform sampler2D g_smoothnessTexture;

in vec4 voutPosition;
in vec4 voutProjPosition;
in vec4 voutColor;
in vec2 voutUV;
in vec2 voutUVSub;
in vec3 voutNormal;
in vec3 voutBinormal;
in vec3 voutTangent;

#ifdef EXPORT_DEPTH
out vec4 Depth;
#else
layout(location = 0) out vec4 DiffuseColor;
layout(location = 1) out vec4 SmoothnessMetalnessAO;
layout(location = 2) out vec4 NormalDepth;
layout(location = 3) out vec4 AO_MatID;
#endif

//<|| ALSL
vec3 CalculateNormal(vec3 normal, vec3 tangent, vec3 binormal, vec3 normalMap)
{
	vec3 n = (normalMap - 0.500000) * 2.00000;
	return tangent * n.x + binormal * n.y + normal * n.z;
}

//>||


void main()
{
	vec2 voutUV_ = voutUV;
	voutUV_.y = 1.0 - voutUV_.y;

	vec4 diffuseColor = voutColor;
	if(diffuseColor.a == 0.0f) discard;

	diffuseColor = diffuseColor * texture(g_colorTexture, voutUV_);
	if(diffuseColor.a == 0.0f) discard;	

	float projDepth = (voutProjPosition.z / voutProjPosition.w);

	// GL
	projDepth = projDepth * 0.5 + 0.5;

#ifdef EXPORT_DEPTH
	// VSM用二乗バッファ含む

	float dx = dFdx(projDepth);
	float dy = dFdy(projDepth);
	Depth.x = projDepth;
	Depth.y = projDepth * projDepth + 0.25*(dx*dx+dy*dy);
	Depth.z = 0.0;
	Depth.w = projDepth;
#else

	DiffuseColor = diffuseColor;

	NormalDepth.xyz = CalculateNormal( voutNormal, voutTangent, voutBinormal, texture(g_normalTexture, voutUV_).xyz );
	//NormalDepth.xyz = texture(g_normalTexture, voutUV_).xyz;
	NormalDepth.w = projDepth;
	//NormalDepth.xyz = voutNormal;

	//NormalDepth.x = 1.0;
	//NormalDepth.y = 1.0;
	//NormalDepth.z = 1.0;
	//NormalDepth.w = 1.0;
	//NormalDepth = diffuseColor;

	SmoothnessMetalnessAO.x = texture(g_smoothnessTexture, voutUV_).x;
	SmoothnessMetalnessAO.y = texture(g_metalnessTexture, voutUV_).x;
	SmoothnessMetalnessAO.z = 1.0;

	AO_MatID.x = 1.0;
	AO_MatID.y = 0;
	AO_MatID.z = 0;
	AO_MatID.w = 0;

#endif

}

)";