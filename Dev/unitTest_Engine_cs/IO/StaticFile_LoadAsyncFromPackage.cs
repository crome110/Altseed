﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTest_Engine_cs.IO
{
	class StaticFile_LoadAsyncFromPackage : EngineTest
	{
		List<asd.StaticFile> files;
		bool finished = false;

		public StaticFile_LoadAsyncFromPackage()
			: base(60)
		{
		}

		protected override void OnStart()
		{
			asd.Engine.File.AddRootPackage("Data/Texture/SamplePackage.pack");

			files = new List<asd.StaticFile>();
			for (int i = 0; i < 10; i++)
			{
				var f = asd.Engine.File.CreateStaticFileAsync("Cloud" + i + ".png");
				files.Add(f);
			}
		}

		protected override void OnUpdated()
		{
			if (!finished && files.All(x => x.LoadState == asd.LoadState.Loaded))
			{
				Console.WriteLine("読み込み完了");
				finished = true;
			}
		}
	}
}
