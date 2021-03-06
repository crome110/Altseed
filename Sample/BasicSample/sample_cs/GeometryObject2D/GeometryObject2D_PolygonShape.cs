﻿/// <summary>
/// 多角形を表示するサンプル。
/// </summary>
class GeometryObject2D_PolygonShape : ISample
{
    public string Description
    {
        get { return ""; }
    }
	public string Title
	{
		get { return ""; }
	}
	public string ClassName
	{
		get { return "GeometryObject2D_PolygonShape"; }
	}

    public void Run()
    {
        // Altseedを初期化する。
        asd.Engine.Initialize("GeometryObject2D_PolygonShape", 640, 480, new asd.EngineOption());

        // 図形描画オブジェクトのインスタンスを生成する。
        var geometryObj = new asd.GeometryObject2D();

        // 図形描画オブジェクトのインスタンスをエンジンに追加する。
        asd.Engine.AddObject2D(geometryObj);

        // 多角形の図形クラスのインスタンスを生成する。
        var polygon = new asd.PolygonShape();

        // 多角形を構成する頂点を追加していく。（星形になるようにする。）
		for (int i = 0; i < 10; i++)
        {
            asd.Vector2DF vec = new asd.Vector2DF(1, 0);
            vec.Degree = i * 36;

            if (i % 2 == 0)
            {
                vec.Length = 200;
            }
            else
            {
                vec.Length = 75;
            }

            polygon.AddVertex(vec + new asd.Vector2DF(320, 240));
        }

        // 多角形を描画する図形として設定する。
        geometryObj.Shape = polygon;

        // Altseedのウインドウが閉じられていないか確認する。
        while (asd.Engine.DoEvents())
        {
            // Altseedを更新する。
            asd.Engine.Update();

            Recorder.TakeScreenShot("GeometryObject2D_PolygonShape", 30);
        }

        // Altseedの終了処理をする。
        asd.Engine.Terminate();
    }
}
