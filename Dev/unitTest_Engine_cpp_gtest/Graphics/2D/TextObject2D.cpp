﻿#include <ace.h>
#include <gtest/gtest.h>
#include <memory>
#include "../../EngineTest.h"

using namespace std;
using namespace ace;

class Graphics_TextObject2D : public EngineTest
{
public:
	Graphics_TextObject2D(bool isOpenGLMode)
		: EngineTest(ace::ToAString("TextObject2D"), isOpenGLMode, 360)
	{
	}

protected:
	void OnStart()
	{
		auto scene = make_shared<Scene>();
		auto layer = make_shared<Layer2D>();
		auto object = make_shared<TextObject2D>();

		ASSERT_NE(scene, nullptr);
		ASSERT_NE(layer, nullptr);
		ASSERT_NE(object, nullptr);

		ace::Engine::ChangeScene(scene);
		scene->AddLayer(layer);

		auto g = ace::Engine::GetGraphics();

		layer->AddObject(object);
		auto font = g->CreateFont(ace::ToAString("Data/Font/Nac0812.aff").c_str());

		object->SetFont(font);
		object->SetText(ToAString("Dependency\nPropertyとは").c_str());

		//object->SetCenterPosition(Vector2DF(128, 128));
		object->SetPosition(Vector2DF(0, 0));

		auto size = font->CalcTextureSize(ToAString("Dependency\nPropertyとは").c_str(), WritingDirection::Horizontal);

		printf("%d %d\n", size.X,size.Y);
	}
};


ENGINE_TEST(Graphics, TextObject2D)
