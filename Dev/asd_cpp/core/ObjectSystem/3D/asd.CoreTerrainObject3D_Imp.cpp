﻿
#include "asd.CoreTerrainObject3D_Imp.h"

#include "../../Graphics/3D/Object/asd.RenderedTerrainObject3D.h"

namespace asd
{
	CoreTerrainObject3D_Imp::CoreTerrainObject3D_Imp(Graphics* graphics)
		: m_object(nullptr)
	{
		m_object = new RenderedTerrainObject3D(graphics);
		m_commonObject = m_object;
	}

	CoreTerrainObject3D_Imp::~CoreTerrainObject3D_Imp()
	{
		SafeRelease(m_object);
	}

	void CoreTerrainObject3D_Imp::SetMaterialPropertyBlock(MaterialPropertyBlock* block)
	{
		m_object->SetMaterialPropertyBlock(block);
	}

	void CoreTerrainObject3D_Imp::SetTerrain(Terrain3D* terrain)
	{
		m_object->SetTerrain(terrain);
	}
}