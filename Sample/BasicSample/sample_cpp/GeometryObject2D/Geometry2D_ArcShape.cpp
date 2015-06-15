﻿#include <Base.h>

/**
@brief	弧を表示するサンプル。
*/
void GeometryObject2D_ArcShape()
{
	// aceを初期化する
	asd::Engine::Initialize(asd::ToAString("GeometryObject2D_ArcShape").c_str(), 640, 480, asd::EngineOption());

	auto texture = asd::Engine::GetGraphics()->CreateTexture2D(asd::ToAString("Data/Texture/Sample1.png").c_str());

	// 図形描画クラスのコンストラクタを呼び出す。
	auto geometryObj = std::make_shared<asd::GeometryObject2D>();

	// 図形描画クラスをレイヤーに追加する。
	asd::Engine::AddObject2D(geometryObj);

	// 弧を図形描画クラスにて描画する。
	{
		// 弧の外径、内径、頂点数、中心位置、開始頂点番号、終了頂点番号を指定。
		auto arc = std::make_shared<asd::ArcShape>();
		arc->SetOuterDiameter(100);
		arc->SetInnerDiameter(10);
		arc->SetNumberOfCorners(96);
		arc->SetPosition(asd::Vector2DF(300, 100));
		arc->SetStartingCorner(90);
		arc->SetEndingCorner(5);

		// 弧を描画する図形として設定し、合成するテクスチャも設定。
		geometryObj->SetShape(arc);
		geometryObj->SetTexture(texture);
		geometryObj->SetPosition(asd::Vector2DF(0, 0));
	}


	// aceが進行可能かチェックする。
	while (asd::Engine::DoEvents())
	{
		// aceを更新する。
		asd::Engine::Update();
	}

	// aceを終了する。
	asd::Engine::Terminate();
}