﻿
//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
#include "ace.Texture2D_Imp_GL.h"
#include "../ace.Graphics_Imp_GL.h"

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
namespace ace {
	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	Texture2D_Imp_GL::Texture2D_Imp_GL(Graphics* graphics)
		: Texture2D_Imp(graphics)
		, m_texture(0)
	{
	
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	Texture2D_Imp_GL::Texture2D_Imp_GL(Graphics* graphics, GLuint texture, Vector2DI size, eTextureFormat format)
		: Texture2D_Imp(graphics)
		, m_texture(texture)
		, m_format(format)
	{
		m_size = size;
		m_resource.resize(size.X * size.Y * ImageHelper::GetPitch(m_format));
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	Texture2D_Imp_GL::~Texture2D_Imp_GL()
	{
		glDeleteTextures(1, &m_texture);
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	bool Texture2D_Imp_GL::GenerateTextureFromInternal()
	{
		GLuint texture = 0;
		glGenTextures(1, &texture);


		GLCheckError();
		if (glGetError() != GL_NO_ERROR) return false;

		glBindTexture(GL_TEXTURE_2D, texture);

		glTexImage2D(
			GL_TEXTURE_2D, 
			0, 
			GL_RGBA,
			m_internalTextureWidth, 
			m_internalTextureHeight,
			0, 
			GL_RGBA, 
			GL_UNSIGNED_BYTE, 
			m_internalTextureData);

		glBindTexture(GL_TEXTURE_2D, 0);

		if (glGetError() != GL_NO_ERROR)
		{
			glDeleteTextures(1, &texture);
			return false;
		}
		
		m_texture = texture;
		m_size.X = m_internalTextureWidth;
		m_size.Y = m_internalTextureHeight;

		return true;
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	Texture2D_Imp_GL* Texture2D_Imp_GL::Create(Graphics_Imp_GL* graphics, uint8_t* data, int32_t size)
	{
		if (size == 0) return nullptr;

		/* ロードしてみる */
		Texture2D_Imp_GL* texture = new Texture2D_Imp_GL(graphics);
		if (!texture->InternalLoad(data, size,true))
		{
			SafeRelease(texture);
			return nullptr;
		}

		if (!texture->GenerateTextureFromInternal())
		{
			SafeRelease(texture);
			return nullptr;
		}

		return texture;
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	Texture2D_Imp_GL* Texture2D_Imp_GL::Create(Graphics_Imp_GL* graphics, int32_t width, int32_t height, eTextureFormat format)
	{
		GLuint texture = 0;
		glGenTextures(1, &texture);

		if (glGetError() != GL_NO_ERROR) return nullptr;

		glBindTexture(GL_TEXTURE_2D, texture);

		int32_t type;
		if (format == eTextureFormat::TEXTURE_FORMAT_R8G8B8A8_UNORM)
		{
			type = GL_UNSIGNED_BYTE;
		}
		else if(format == eTextureFormat::TEXTURE_FORMAT_R32G32B32A32_FLOAT)
		{
			type = GL_FLOAT;
		}

		glTexImage2D(
			GL_TEXTURE_2D,
			0,
			GL_RGBA,
			width,
			height,
			0,
			GL_RGBA,
			type,
			nullptr);

		glBindTexture(GL_TEXTURE_2D, 0);

		if (glGetError() != GL_NO_ERROR)
		{
			glDeleteTextures(1, &texture);
			return nullptr;
		}

		GLCheckError();

		return new Texture2D_Imp_GL(graphics, texture, Vector2DI(width, height), format);
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	bool Texture2D_Imp_GL::Save(const achar* path)
	{
		auto g = (Graphics_Imp_GL*) GetGraphics();
		return g->SaveTexture(path, m_texture, GetSize());
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	bool Texture2D_Imp_GL::Lock(TextureLockInfomation& info)
	{
		if (m_resource.size() == 0) return false;

		info.Pixels = &(m_resource[0]);
		info.Pitch = ImageHelper::GetPitch(m_format);
		info.Size = m_size;
		return true;
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	void Texture2D_Imp_GL::Unlock()
	{
		auto g = (Graphics_Imp_GL*) GetGraphics();

		glBindTexture(GL_TEXTURE_2D, m_texture);

		int32_t type;
		if (m_format == eTextureFormat::TEXTURE_FORMAT_R8G8B8A8_UNORM)
		{
			type = GL_UNSIGNED_BYTE;
		}
		else if (m_format == eTextureFormat::TEXTURE_FORMAT_R32G32B32A32_FLOAT)
		{
			type = GL_FLOAT;
		}

		glTexSubImage2D(
			GL_TEXTURE_2D,
			0,
			0,
			0,
			m_size.X,
			m_size.Y,
			GL_RGBA,
			type,
			m_resource.data());

		glBindTexture(GL_TEXTURE_2D, 0);
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
	void Texture2D_Imp_GL::Reload(void* data, int32_t size)
	{
		glDeleteTextures(1, &m_texture);

		if (!InternalLoad(data, size, false))
		{
			InternalUnload();
			return;
		}

		GenerateTextureFromInternal();

		InternalUnload();
	}

	//----------------------------------------------------------------------------------
	//
	//----------------------------------------------------------------------------------
}
