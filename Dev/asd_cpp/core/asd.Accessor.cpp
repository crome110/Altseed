﻿
#include "asd.Accessor.h"

#include "Graphics/3D/Resource/Animation/asd.AnimationSystem.h"
#include "Graphics/3D/Resource/Animation/asd.AnimationClip.h"
#include "Graphics/3D/Resource/Animation/asd.AnimationSource.h"

#include "Graphics/Resource/asd.Shader2D.h"
#include "Graphics/Resource/asd.Material2D.h"

#include "Graphics/Resource/asd.Shader3D.h"
#include "Graphics/Resource/asd.Material3D.h"

#include "Graphics/Resource/asd.MaterialPropertyBlock.h"

#include "Graphics/Resource/asd.ImagePackage.h"

#include "ObjectSystem/2D/asd.CoreEffectObject2D.h"
#include "ObjectSystem/2D/asd.CoreChip2D.h"

#include "Graphics/3D/Resource/asd.Mesh.h"
#include "Graphics/3D//Resource/asd.Model.h"

namespace asd
{
	AnimationSource* Accessor::AnimationClip_GetSource(AnimationClip* o)
	{
		return o->GetSource_();
	}

	Texture2D* Accessor::Material2D_GetTexture2D(Material2D* o, const achar* name)
	{
		return o->GetTexture2D_(name);
	}

	Shader2D* Accessor::Material2D_GetShader2D(Material2D* o)
	{
		return o->GetShader2D_();
	}

	Texture2D* Accessor::Material3D_GetTexture2D(Material3D* o, const achar* name)
	{
		return o->GetTexture2D_(name);
	}

	Shader3D* Accessor::Material3D_GetShader3D(Material3D* o)
	{
		return o->GetShader3D_();
	}

	Texture2D* Accessor::MaterialPropertyBlock_GetTexture2D(MaterialPropertyBlock* o, const achar* name)
	{
		return o->GetTexture2D_(name);
	}

	AnimationClip* Accessor::AnimationSyatem_CreateAnimationClip(AnimationSystem* o)
	{
		return o->CreateAnimationClip_();
	}

	AnimationSource* Accessor::AnimationSyatem_CreateAnimationSource(AnimationSystem* o)
	{
		return o->CreateAnimationSource_();
	}

	KeyframeAnimation* Accessor::AnimationSyatem_CreateKeyframeAnimation(AnimationSystem* o)
	{
		return o->CreateKeyframeAnimation_();
	}

	AnimationClip* Accessor::Model_GetAnimationClip(Model* o, int32_t index)
	{
		return o->GetAnimationClip_(index);
	}

	Mesh* Accessor::Model_GetMesh(Model* o, int32_t index)
	{
		return o->GetMesh_(index);
	}

	Texture2D* Accessor::ImagePackage_GetImage(ImagePackage* o, int32_t index)
	{
		return o->GetImage_(index);
	}    
	
	Texture2D* Accessor::Chip2D_GetTexture(CoreChip2D* chip)
	{
		return chip->GetTexture_();
	}

	Effect* Accessor::CoreEffectObject2D_GetEffect(CoreEffectObject2D* o)
	{
		return o->GetEffect_();
	}
}