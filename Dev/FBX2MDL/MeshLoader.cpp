#include "MeshLoader.h"
#include <iostream>

MeshLoader::MeshLoader()
{
	faceContinue=0;
	preFaceIndex=0;
}

std::vector<Vertex> MeshLoader::GetVertices()
{
	return _vertices;
}

void MeshLoader::_loadPositions(FbxMesh* fbxMesh)
{
	name=std::string(fbxMesh->GetNode()->GetName());
	int controlNum = fbxMesh->GetControlPointsCount();

	FbxVector4* src = fbxMesh->GetControlPoints();

	for(int i=0;i<controlNum;++i)
	{
		Vertex vertex;
		ace::Vector3DF controlAry;
		controlAry.X=src[i][0];
		controlAry.Y=src[i][1];
		controlAry.Z=src[i][2];
		vertex.position=controlAry;
		vertex.normal=ace::Vector3DF(0,0,0);
		vertex.binormal=ace::Vector3DF(0,0,0);
		vertex.uv=ace::Vector2DF(0,0);
		vertex.subuv=ace::Vector2DF(0,0);
		vertex.normalAddCount=0;
		vertex.binormalAddCount=0;
		vertex.weightPtr=0;
		for(int j=0;j<4;++j)
		{
			vertex.color[j]=255;
			vertex.weight[j]=0;
			vertex.weightIndexDivided[j]=0;
			vertex.weightIndexOriginal[j]=0;

		}
		vertex.weight[0]=255;
		_baseVertices.push_back(vertex);
	}
}

ace::Vector3DF MeshLoader::_loadNormal(FbxMesh* fbxMesh,int lControlPointIndex,int vertexId)
{
	ace::Vector3DF normal;
	for(int l = 0; l < fbxMesh->GetElementNormalCount(); ++l)
	{
		FbxGeometryElementNormal* leNormal = fbxMesh->GetElementNormal( l);

		if(leNormal->GetMappingMode() == FbxGeometryElement::eByPolygonVertex)
		{
			switch (leNormal->GetReferenceMode())
			{
			case FbxGeometryElement::eDirect:
				normal.X = leNormal->GetDirectArray().GetAt(vertexId)[0];
				normal.Y = leNormal->GetDirectArray().GetAt(vertexId)[1];
				normal.Z = leNormal->GetDirectArray().GetAt(vertexId)[2];
				break;
			case FbxGeometryElement::eIndexToDirect:
				{
					int id = leNormal->GetIndexArray().GetAt(vertexId);
					normal.X = leNormal->GetDirectArray().GetAt(id)[0];
					normal.Y = leNormal->GetDirectArray().GetAt(id)[1];
					normal.Z = leNormal->GetDirectArray().GetAt(id)[2];
				}
				break;
			}
		}

	}

	return normal;
}


ace::Vector3DF MeshLoader::_loadBinormal(FbxMesh* fbxMesh,int lControlPointIndex,int vertexId)
{
	ace::Vector3DF binormal;
	for(int l = 0; l < fbxMesh->GetElementBinormalCount(); ++l)
	{

		FbxGeometryElementBinormal* leBinormal = fbxMesh->GetElementBinormal( l);
		if(leBinormal->GetMappingMode() == FbxGeometryElement::eByPolygonVertex)
		{
			switch (leBinormal->GetReferenceMode())
			{
			case FbxGeometryElement::eDirect:
				binormal.X = leBinormal->GetDirectArray().GetAt(vertexId)[0];
				binormal.Y = leBinormal->GetDirectArray().GetAt(vertexId)[1];
				binormal.Z = leBinormal->GetDirectArray().GetAt(vertexId)[2];
				break;
			case FbxGeometryElement::eIndexToDirect:
				{
					int id = leBinormal->GetIndexArray().GetAt(vertexId);
					binormal.X = leBinormal->GetDirectArray().GetAt(id)[0];
					binormal.Y = leBinormal->GetDirectArray().GetAt(id)[1];
					binormal.Z = leBinormal->GetDirectArray().GetAt(id)[2];
				}
				break;
			}
		}
	}
	return binormal;
}

ace::Vector2DF MeshLoader::_loadUV(FbxMesh* fbxMesh, int lControlPointIndex, int vertexId, int polygonCount, int polygonVert)
{
	ace::Vector2DF uv;
	for (int l = 0; l < fbxMesh->GetElementUVCount(); ++l)
	{
		FbxGeometryElementUV* leUV = fbxMesh->GetElementUV( l);

		switch (leUV->GetMappingMode())
		{
		default:
			break;
		case FbxGeometryElement::eByControlPoint:
			switch (leUV->GetReferenceMode())
			{
			case FbxGeometryElement::eDirect:
				uv.X=leUV->GetDirectArray().GetAt(lControlPointIndex)[0];
				uv.Y=leUV->GetDirectArray().GetAt(lControlPointIndex)[1];
				break;
			case FbxGeometryElement::eIndexToDirect:
				{
					int id = leUV->GetIndexArray().GetAt(lControlPointIndex);
					uv.X=leUV->GetDirectArray().GetAt(id)[0];
					uv.Y=leUV->GetDirectArray().GetAt(id)[1];
				}
				break;
			}
			break;

		case FbxGeometryElement::eByPolygonVertex:
			{									 
				int lTextureUVIndex = fbxMesh->GetTextureUVIndex(polygonCount, polygonVert);
				switch (leUV->GetReferenceMode())
				{
				case FbxGeometryElement::eDirect:
				case FbxGeometryElement::eIndexToDirect:
					{
						uv.X=leUV->GetDirectArray().GetAt(lTextureUVIndex)[0];
						uv.Y=leUV->GetDirectArray().GetAt(lTextureUVIndex)[1];
					}
					break;
				}
			}
			break;
		}
	}
	return uv;
}

std::vector<uint8_t> MeshLoader::_loadColor(FbxMesh* fbxMesh,int lControlPointIndex,int vertexId)
{
	std::vector<uint8_t> color;
	color.push_back(255);
	color.push_back(255);
	color.push_back(255);
	color.push_back(255);

	for (int l = 0; l < fbxMesh->GetElementVertexColorCount(); l++)
	{
		FbxGeometryElementVertexColor* leVtxc = fbxMesh->GetElementVertexColor( l);

		switch (leVtxc->GetMappingMode())
		{
		default:
			break;
		case FbxGeometryElement::eByControlPoint:
			switch (leVtxc->GetReferenceMode())
			{
			case FbxGeometryElement::eDirect:
				color[0]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(lControlPointIndex)[0]*255);
				color[1]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(lControlPointIndex)[1]*255);
				color[2]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(lControlPointIndex)[2]*255);
				color[3]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(lControlPointIndex)[3]*255);
				break;
			case FbxGeometryElement::eIndexToDirect:
				{
					int id = leVtxc->GetIndexArray().GetAt(lControlPointIndex);
					color[0]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[0]*255);
					color[1]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[1]*255);
					color[2]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[2]*255);
					color[3]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[3]*255);
				}
				break;
			default:
				break; // other reference modes not shown here!
			}
			break;

		case FbxGeometryElement::eByPolygonVertex:
			{
				switch (leVtxc->GetReferenceMode())
				{
				case FbxGeometryElement::eDirect:
					color[0]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(vertexId)[0]*255);
					color[1]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(vertexId)[1]*255);
					color[2]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(vertexId)[2]*255);
					color[3]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(vertexId)[3]*255);
					break;
				case FbxGeometryElement::eIndexToDirect:
					{
						int id = leVtxc->GetIndexArray().GetAt(vertexId);
						color[0]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[0]*255);
						color[1]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[1]*255);
						color[2]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[2]*255);
						color[3]=static_cast<uint8_t>(leVtxc->GetDirectArray().GetAt(id)[3]*255);
					}
					break;
				}
			}
			break;
		}
	}
	return color;
}

void MeshLoader::_loadWeight(FbxMesh* fbxMesh,int& attachedIndex,std::vector<MeshGroup> &meshGroups)
{
	int skinCount=fbxMesh->GetDeformerCount(FbxDeformer::eSkin);

	attachedIndex=-1;

	for(int i=0;i<skinCount;++i)
	{
		//printf("Weight Start.\n");
		FbxSkin* skin = (FbxSkin*)fbxMesh->GetDeformer(i,FbxDeformer::eSkin);

		FbxCluster* firstCluster = skin->GetCluster(0);

		for(int j=0;j<meshGroups.size();++j)
		{
			if (meshGroups[j].deformerManager.GetDeformerByName(firstCluster->GetLink()->GetName())!=NULL)
			{
				attachedIndex =j;
				break;
			}
		}

		int clusterNum = skin->GetClusterCount();

		for(int j=0;j<clusterNum;++j)
		{
			FbxCluster* cluster = skin->GetCluster(j);

			int pointNum = cluster->GetControlPointIndicesCount();
			int* pointAry = cluster->GetControlPointIndices();
			double* weightAry = cluster->GetControlPointWeights();

			std::string name = std::string(cluster->GetLink()->GetName());

			int dmIndex = meshGroups[attachedIndex].deformerManager.GetIndexByName(name);

			for(int k=0;k<pointNum;++k)
			{
				int index = pointAry[k];
				float weight = static_cast<float>(weightAry[k]);

				int ptr=_baseVertices[index].weightPtr;

				_baseVertices[index].weight[ptr]=static_cast<uint8_t>(weight*255.0);
				_baseVertices[index].weightIndexDivided[ptr]=dmIndex;
				_baseVertices[index].weightIndexOriginal[ptr]=dmIndex;

				++_baseVertices[index].weightPtr;
			}
		}
	}
}

void MeshLoader::_loadFaceIndices(FbxMesh* fbxMesh)
{
	int PolygonVertexNum=fbxMesh->GetPolygonVertexCount();
	int *IndexAry = fbxMesh->GetPolygonVertices();

	Face face;
	int faceIndexer=0;

	for(int i=0;i<PolygonVertexNum;++i)
	{
		face.vertexIndex[faceIndexer++]=IndexAry[i];
		if(faceIndexer==3)
		{
			faceIndexer=0;
			_faces.push_back(face);
		}
	}
}

void MeshLoader::Load(FbxMesh* fbxMesh,int& attachmentIndex,std::vector<MeshGroup> &meshGroups)
{
	_loadPositions(fbxMesh);

	_loadWeight(fbxMesh,attachmentIndex,meshGroups);
	
	_loadTextures(fbxMesh);

	_loadVertices(fbxMesh);


	//_loadFaceMaterials(fbxMesh);
}

void MeshLoader::WriteVertices(ace::BinaryWriter* writer)
{
	printf("Mesh Name = %s\n",name.c_str());
	//printf("Control Point Num = %d\n",_vertices.size());
	writer->Push((int32_t)_vertices.size());

	ace::Vector3DF zero3 = ace::Vector3DF(0,0,0);
	ace::Vector2DF zero2 = ace::Vector2DF(0,0);


	for(int i=0;i<_vertices.size();++i)
	{
		writer->Push(_vertices[i].position);

		writer->Push(_vertices[i].normal/_vertices[i].normalAddCount);
		writer->Push(_vertices[i].binormal/_vertices[i].binormalAddCount);

		writer->Push(_vertices[i].uv);
		writer->Push(_vertices[i].subuv);
		/*
		if(_vertices[i].color[0]==0&&_vertices[i].color[1]==0&&_vertices[i].color[2]==0&&_vertices[i].color[3]==0)
		{
			_vertices[i].color[0]=255;
			_vertices[i].color[1]=255;
			_vertices[i].color[2]=255;
			_vertices[i].color[3]=255;
		}
		*/

		//頂点カラー
		writer->Push(static_cast<uint8_t>(_vertices[i].color[0]));
		writer->Push(static_cast<uint8_t>(_vertices[i].color[1]));
		writer->Push(static_cast<uint8_t>(_vertices[i].color[2]));
		writer->Push(static_cast<uint8_t>(_vertices[i].color[3]));

		//頂点ウェイト

		uint8_t biggest=0;
		int biggestIndex=0;
		int sum=0;
		for (int j = 0; j < 4; ++j)
		{
			if(_vertices[i].weight[j]>biggest)
			{
				biggest=_vertices[i].weight[j];
				biggestIndex=j;
			}
			sum+=static_cast<int>(_vertices[i].weight[j]);
		}

		if(sum!=255&&sum!=0)
		{
			_vertices[i].weight[biggestIndex]+=static_cast<uint8_t>(255-sum);
		}

		for (int j = 0; j < 4; ++j)
		{
			writer->Push(_vertices[i].weight[j]);
		}
		for (int j = 0; j < 4; ++j)
		{
			writer->Push(_vertices[i].weightIndexOriginal[j]);
		}
		for (int j = 0; j < 4; ++j)
		{
			writer->Push(_vertices[i].weightIndexDivided[j]);
		}
	}
}

void MeshLoader::WriteFaces(ace::BinaryWriter* writer)
{

	writer->Push((int32_t) _faces.size());
	for (auto ite = _faces.begin(); ite != _faces.end(); ++ite)
	{
		for (int i = 0; i < 3; ++i)
		{
			writer->Push((int32_t) ite->vertexIndex[i]);
		}
	}

}


void MeshLoader::_loadBoneAttachments(FbxMesh* fbxMesh)
{

}

void MeshLoader::WriteFaceMaterials(ace::BinaryWriter* writer)
{
	writer->Push((int32_t)_facialMaterials.size());

	printf("fms = %d\n",_facialMaterials.size());

	for(int i=0;i<_facialMaterials.size();++i)
	{
		writer->Push((int32_t)_facialMaterials[i].materialRef.groupIndex);
		writer->Push((int32_t)_facialMaterials[i].faceNum);

		printf("fmi = %d fmfn = %d\n",_facialMaterials[i].materialRef.groupIndex,_facialMaterials[i].faceNum);
	}
}

void MeshLoader::WriteBoneAttachments(ace::BinaryWriter* writer)
{
	//writer->Push((int32_t)0);

	writer->Push((int32_t)1);
	for(int i=0;i<32;++i)
	{
		writer->Push(static_cast<uint8_t>(i));
	}
	writer->Push(static_cast<int>(_faces.size()));

}

void MeshLoader::_loadTextures(FbxMesh* fbxMesh)
{
	FbxNode* node = fbxMesh->GetNode();

	int materialCount = node->GetMaterialCount();

	const char* mats[3]={FbxSurfaceMaterial::sDiffuse,FbxSurfaceMaterial::sNormalMap,FbxSurfaceMaterial::sSpecular};

	printf("mat num = %d\n",materialCount);

	for (int i = 0; i < materialCount; i++) 
	{

		FbxSurfaceMaterial* material = node->GetMaterial(i);
		Material mat;
		mat.Type=0;
		mat.groupIndex=-1;
		for(int s=0;s<3;++s)
		{
			FbxProperty prop = material->FindProperty(mats[s]);

			int layeredTextureCount = prop.GetSrcObjectCount<FbxLayeredTexture>();

			if(0 < layeredTextureCount) 
			{

				for(int j = 0; layeredTextureCount > j; j++) 
				{

					FbxLayeredTexture* layeredTexture = prop.GetSrcObject<FbxLayeredTexture>(j);
					int textureCount = layeredTexture->GetSrcObjectCount<FbxFileTexture>();

					for(int k = 0; textureCount > k; k++) {
						FbxFileTexture* texture = prop.GetSrcObject<FbxFileTexture>(k);

						if(texture) {
							//--- テクスチャ名を取得 ---//
							//std::string textureName = texture->GetName();
							std::string textureName = texture->GetFileName();

							//--- UVSet名を取得 ---//
							std::string UVSetName = texture->UVSet.Get().Buffer();

							mat.texture[j]=textureName;
						}
					}
				}
			}
			else {
				//--- テクスチャ数を取得 ---//
				int fileTextureCount = prop.GetSrcObjectCount<FbxFileTexture>();

				if(0 < fileTextureCount) 
				{
					for(int j = 0; fileTextureCount > j; j++) {
						FbxFileTexture* texture = prop.GetSrcObject<FbxFileTexture>(j);
						if(texture) {
							//std::string textureName = texture->GetName();
							std::string textureName = texture->GetFileName();

							//--- UVSet名を取得 ---//
							std::string UVSetName = texture->UVSet.Get().Buffer();

							mat.texture[j]=textureName;
						}
					}
				}
			}
		}
		materials.push_back(mat);
	}
}

void MeshLoader::_loadFaceMaterials(FbxMesh* fbxMesh)
{

}

void MeshLoader::_loadVertices(FbxMesh* fbxMesh)
{
	int lPolygonCount = fbxMesh->GetPolygonCount();
	FbxVector4* lControlPoints = fbxMesh->GetControlPoints();

	int vertexId = 0;

	for (int i = 0; i < lPolygonCount; i++)
	{
		int lPolygonSize = fbxMesh->GetPolygonSize(i);

		for (int j = 0; j < lPolygonSize; j++)
		{
			int lControlPointIndex = fbxMesh->GetPolygonVertex(i, j);

			_baseVertices[lControlPointIndex].normal += _loadNormal(fbxMesh,lControlPointIndex,vertexId);

			_baseVertices[lControlPointIndex].binormal += _loadBinormal(fbxMesh,lControlPointIndex,vertexId);

			++_baseVertices[lControlPointIndex].normalAddCount;
			++_baseVertices[lControlPointIndex].binormalAddCount;

			vertexId++;
		} // for polygonSize
	}

	vertexId=0;

	bool lIsAllSame = true;
	for (int l = 0; l < fbxMesh->GetElementMaterialCount(); l++)
	{

		FbxGeometryElementMaterial* lMaterialElement = fbxMesh->GetElementMaterial(l);
		if( lMaterialElement->GetMappingMode() == FbxGeometryElement::eByPolygon) 
		{
			lIsAllSame = false;
			break;
		}
	}

	for (int i = 0; i < lPolygonCount; i++)
	{
		int lPolygonSize = fbxMesh->GetPolygonSize(i);

		int cIndices[3];

		for (int j = 0; j < lPolygonSize; j++)
		{
			int lControlPointIndex = fbxMesh->GetPolygonVertex(i, j);

			Vertex vertex;

			vertex=_baseVertices[lControlPointIndex];

			std::vector<uint8_t> color = _loadColor(fbxMesh,lControlPointIndex,vertexId);

			vertex.color[0]=color[0];
			vertex.color[1]=color[1];
			vertex.color[2]=color[2];
			vertex.color[3]=color[3];

			vertex.uv = _loadUV(fbxMesh,lControlPointIndex,vertexId,i,j);
			vertex.uv.Y=1-vertex.uv.Y;
			int index = -1;
			for(int k=0;k<_vertices.size();++k)
			{
				if(_vertices[k]==vertex)
				{
					index=k;
					break;
				}
			}

			//not found same vertex
			if(index==-1)
			{
				_vertices.push_back(vertex);
				cIndices[j]=(int)_vertices.size()-1;
			}
			else
			{
				cIndices[j]=index;
			}

			vertexId++;
		} // for polygonSize

		int lMatId = -1;
		if(!lIsAllSame)
		{
			FbxGeometryElementMaterial* lMaterialElement = fbxMesh->GetElementMaterial(0);
			FbxSurfaceMaterial* lMaterial = NULL;

			lMaterial = fbxMesh->GetNode()->GetMaterial(lMaterialElement->GetIndexArray().GetAt(i));

			lMatId = lMaterialElement->GetIndexArray().GetAt(i);
		}
		else
		{
			FbxGeometryElementMaterial* lMaterialElement = fbxMesh->GetElementMaterial( 0);
			FbxSurfaceMaterial* lMaterial = fbxMesh->GetNode()->GetMaterial(lMaterialElement->GetIndexArray().GetAt(0));    
			lMatId = lMaterialElement->GetIndexArray().GetAt(0);
		}

		if(i==0)
		{
			preFaceIndex = lMatId;
		}
		else if(i==lPolygonCount-1)
		{
			_facialMaterials.push_back(FacialMaterial(faceContinue+2,materials[lMatId]));
		}
		else if(preFaceIndex==lMatId)
		{
			++faceContinue;
		}
		else
		{
			_facialMaterials.push_back(FacialMaterial(faceContinue+1,materials[lMatId]));
			faceContinue=0;
		}

		preFaceIndex=lMatId;

		Face face;
		face.materialIndex=lMatId;
		face.vertexIndex[0]=cIndices[2];
		face.vertexIndex[1]=cIndices[1];
		face.vertexIndex[2]=cIndices[0];
		_faces.push_back(face);

	} // for polygonCount
}