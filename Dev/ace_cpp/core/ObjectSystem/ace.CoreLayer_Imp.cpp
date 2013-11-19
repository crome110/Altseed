﻿
#include "ace.CoreLayer_Imp.h"
#include "PostEffect/ace.CorePostEffect_Imp.h"
#include "../Graphics/Common/ace.Graphics_Imp.h"

namespace ace
{

	CoreLayer_Imp::CoreLayer_Imp(Graphics* graphics, Vector2DI windowSize)
		: m_graphics(nullptr)
		, m_isDrawn(true)
		, m_drawingPriority(0)
		, m_renderTarget0(nullptr)
		, m_renderTarget1(nullptr)
		, m_targetToLayer(-1)
		, m_layerSize(windowSize)
		, m_windowSize(windowSize)
	{
		m_graphics = (Graphics_Imp*) graphics;
		SafeAddRef(m_graphics);
	}

	CoreLayer_Imp::~CoreLayer_Imp()
	{
		SafeRelease(m_renderTarget0);
		SafeRelease(m_renderTarget1);

		SafeRelease(m_graphics);
	}

	int CoreLayer_Imp::GetDrawingPriority() const
	{
		return m_drawingPriority;
	}

	void CoreLayer_Imp::SetDrawingPriority(int value)
	{
		m_drawingPriority = value;
	}

	bool CoreLayer_Imp::GetIsDrawn() const
	{
		return m_isDrawn;
	}

	void CoreLayer_Imp::SetIsDrawn(bool value)
	{
		m_isDrawn = value;
	}

	void CoreLayer_Imp::AddPostEffect(CorePostEffect* postEffect)
	{
		SafeAddRef(postEffect);
		m_postEffects.push_back(postEffect);

		CreateRenderTarget(m_layerSize);
	}

	void CoreLayer_Imp::ClearPostEffects()
	{
		for (auto& p : m_postEffects)
		{
			SafeRelease(p);
		}

		m_postEffects.clear();
	}

	RenderTexture2D* CoreLayer_Imp::GetRenderTarget0()
	{
		return m_renderTarget0;
	}

	RenderTexture2D* CoreLayer_Imp::GetRenderTarget1()
	{
		return m_renderTarget1;
	}

	void CoreLayer_Imp::SetTargetToLayer(int32_t index)
	{
		m_targetToLayer = index;
	}

	void CoreLayer_Imp::CreateRenderTarget(const Vector2DI& size)
	{
		if (m_layerSize == size && m_renderTarget0 != nullptr) return;
		m_layerSize = size;

		SafeRelease(m_renderTarget0);
		SafeRelease(m_renderTarget1);

		m_renderTarget0 = m_graphics->CreateRenderTexture_Imp(m_layerSize.X, m_layerSize.Y, eTextureFormat::TEXTURE_FORMAT_RGBA8888);
		m_renderTarget1 = m_graphics->CreateRenderTexture_Imp(m_layerSize.X, m_layerSize.Y, eTextureFormat::TEXTURE_FORMAT_RGBA8888);
	}
}