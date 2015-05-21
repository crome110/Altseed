using System;
namespace ace {
	/// <summary>
	/// 回転行列の計算順序 
	///	</summary>
	public enum RotationOrder : int
	{
		/// <summary>
		/// 
		/// </summary>
		QUATERNION = ace.swig.RotationOrder.QUATERNION,
		/// <summary>
		/// 
		/// </summary>
		XZY = ace.swig.RotationOrder.XZY,
		/// <summary>
		/// 
		/// </summary>
		XYZ = ace.swig.RotationOrder.XYZ,
		/// <summary>
		/// 
		/// </summary>
		ZXY = ace.swig.RotationOrder.ZXY,
		/// <summary>
		/// 
		/// </summary>
		ZYX = ace.swig.RotationOrder.ZYX,
		/// <summary>
		/// 
		/// </summary>
		YXZ = ace.swig.RotationOrder.YXZ,
		/// <summary>
		/// 
		/// </summary>
		YZX = ace.swig.RotationOrder.YZX,
		/// <summary>
		/// 
		/// </summary>
		AXIS = ace.swig.RotationOrder.AXIS,
	}

	/// <summary>
	/// キー間の補間方法 
	///	</summary>
	public enum InterpolationType : int
	{
		/// <summary>
		/// 次のキーまで定数で補間 
		/// </summary>
		Constant = ace.swig.InterpolationType.Constant,
		/// <summary>
		/// 次のキーまで線形で補間 
		/// </summary>
		Linear = ace.swig.InterpolationType.Linear,
		/// <summary>
		/// 次のキーまで三次方程式で補間 
		/// </summary>
		Cubic = ace.swig.InterpolationType.Cubic,
	}

	/// <summary>
	/// 起動時に自動的に生成されるレイヤーの種類 
	///	</summary>
	public enum AutoGeneratedLayerType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Layer2D = ace.swig.AutoGeneratedLayerType.Layer2D,
		/// <summary>
		/// 
		/// </summary>
		Layer3D = ace.swig.AutoGeneratedLayerType.Layer3D,
		/// <summary>
		/// 
		/// </summary>
		Nothing = ace.swig.AutoGeneratedLayerType.Nothing,
	}

	/// <summary>
	/// レイヤーの種類 
	///	</summary>
	public enum LayerType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Layer2D = ace.swig.LayerType.Layer2D,
		/// <summary>
		/// 
		/// </summary>
		Layer3D = ace.swig.LayerType.Layer3D,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum WritingDirection : int
	{
		/// <summary>
		/// 
		/// </summary>
		Vertical = ace.swig.WritingDirection.Vertical,
		/// <summary>
		/// 
		/// </summary>
		Horizontal = ace.swig.WritingDirection.Horizontal,
	}

	/// <summary>
	/// フレームレートの制御方法 
	///	</summary>
	public enum FramerateMode : int
	{
		/// <summary>
		/// 固定フレームレート 
		/// </summary>
		Constant = ace.swig.FramerateMode.Constant,
		/// <summary>
		/// 可変フレームレート 
		/// </summary>
		Variable = ace.swig.FramerateMode.Variable,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum TextureFormat : int
	{
		/// <summary>
		/// 
		/// </summary>
		R8G8B8A8_UNORM = ace.swig.TextureFormat.R8G8B8A8_UNORM,
		/// <summary>
		/// 
		/// </summary>
		R32G32B32A32_FLOAT = ace.swig.TextureFormat.R32G32B32A32_FLOAT,
		/// <summary>
		/// 
		/// </summary>
		R8G8B8A8_UNORM_SRGB = ace.swig.TextureFormat.R8G8B8A8_UNORM_SRGB,
		/// <summary>
		/// 
		/// </summary>
		R16G16_FLOAT = ace.swig.TextureFormat.R16G16_FLOAT,
		/// <summary>
		/// 
		/// </summary>
		R8_UNORM = ace.swig.TextureFormat.R8_UNORM,
		/// <summary>
		/// 
		/// </summary>
		BC1 = ace.swig.TextureFormat.BC1,
		/// <summary>
		/// 
		/// </summary>
		BC2 = ace.swig.TextureFormat.BC2,
		/// <summary>
		/// 
		/// </summary>
		BC3 = ace.swig.TextureFormat.BC3,
		/// <summary>
		/// 
		/// </summary>
		BC1_SRGB = ace.swig.TextureFormat.BC1_SRGB,
		/// <summary>
		/// 
		/// </summary>
		BC2_SRGB = ace.swig.TextureFormat.BC2_SRGB,
		/// <summary>
		/// 
		/// </summary>
		BC3_SRGB = ace.swig.TextureFormat.BC3_SRGB,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum TextureClassType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Texture2D = ace.swig.TextureClassType.Texture2D,
		/// <summary>
		/// 
		/// </summary>
		RenderTexture2D = ace.swig.TextureClassType.RenderTexture2D,
		/// <summary>
		/// 
		/// </summary>
		CubemapTexture = ace.swig.TextureClassType.CubemapTexture,
		/// <summary>
		/// 
		/// </summary>
		DepthBuffer = ace.swig.TextureClassType.DepthBuffer,
	}

	/// <summary>
	/// 描画時のブレンドモードを表す列挙体 
	///	</summary>
	public enum AlphaBlendMode : int
	{
		/// <summary>
		/// 不透明 
		/// </summary>
		Opacity = ace.swig.AlphaBlendMode.Opacity,
		/// <summary>
		/// 透明 
		/// </summary>
		Blend = ace.swig.AlphaBlendMode.Blend,
		/// <summary>
		/// 加算 
		/// </summary>
		Add = ace.swig.AlphaBlendMode.Add,
		/// <summary>
		/// 減算 
		/// </summary>
		Sub = ace.swig.AlphaBlendMode.Sub,
		/// <summary>
		/// 乗算 
		/// </summary>
		Mul = ace.swig.AlphaBlendMode.Mul,
		/// <summary>
		/// 全加算(内部処理用) 
		/// </summary>
		AddAll = ace.swig.AlphaBlendMode.AddAll,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum TextureFilterType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Nearest = ace.swig.TextureFilterType.Nearest,
		/// <summary>
		/// 
		/// </summary>
		Linear = ace.swig.TextureFilterType.Linear,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum TextureWrapType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Repeat = ace.swig.TextureWrapType.Repeat,
		/// <summary>
		/// 
		/// </summary>
		Clamp = ace.swig.TextureWrapType.Clamp,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum CullingType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Front = ace.swig.CullingType.Front,
		/// <summary>
		/// 
		/// </summary>
		Back = ace.swig.CullingType.Back,
		/// <summary>
		/// 
		/// </summary>
		Double = ace.swig.CullingType.Double,
	}

	/// <summary>
	/// 描画方法 
	///	</summary>
	public enum GraphicsDeviceType : int
	{
		/// <summary>
		/// 実行環境で最も安定している描画方法(初期化時に使用) 
		/// </summary>
		Default = ace.swig.GraphicsDeviceType.Default,
		/// <summary>
		/// DirectX11. 
		/// </summary>
		DirectX11 = ace.swig.GraphicsDeviceType.DirectX11,
		/// <summary>
		/// OpenGL. 
		/// </summary>
		OpenGL = ace.swig.GraphicsDeviceType.OpenGL,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum Object2DType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = ace.swig.Object2DType.Unknown,
		/// <summary>
		/// 
		/// </summary>
		Texture = ace.swig.Object2DType.Texture,
		/// <summary>
		/// 
		/// </summary>
		Camera = ace.swig.Object2DType.Camera,
		/// <summary>
		/// 
		/// </summary>
		Effect = ace.swig.Object2DType.Effect,
		/// <summary>
		/// 
		/// </summary>
		Text = ace.swig.Object2DType.Text,
		/// <summary>
		/// 
		/// </summary>
		Map = ace.swig.Object2DType.Map,
		/// <summary>
		/// 
		/// </summary>
		Geometry = ace.swig.Object2DType.Geometry,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum RenderedObject3DType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = ace.swig.RenderedObject3DType.Unknown,
		/// <summary>
		/// 
		/// </summary>
		Mesh = ace.swig.RenderedObject3DType.Mesh,
		/// <summary>
		/// 
		/// </summary>
		Camera = ace.swig.RenderedObject3DType.Camera,
		/// <summary>
		/// 
		/// </summary>
		Effect = ace.swig.RenderedObject3DType.Effect,
		/// <summary>
		/// 
		/// </summary>
		DirectionalLight = ace.swig.RenderedObject3DType.DirectionalLight,
		/// <summary>
		/// 
		/// </summary>
		MassObject = ace.swig.RenderedObject3DType.MassObject,
		/// <summary>
		/// 
		/// </summary>
		Terrain = ace.swig.RenderedObject3DType.Terrain,
	}

	/// <summary>
	/// シェーダーに対して外部から設定可能なプロパティの変数の種類 
	///	</summary>
	public enum ShaderVariableType : int
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = ace.swig.ShaderVariableType.Unknown,
		/// <summary>
		/// 
		/// </summary>
		Float = ace.swig.ShaderVariableType.Float,
		/// <summary>
		/// 
		/// </summary>
		Vector2DF = ace.swig.ShaderVariableType.Vector2DF,
		/// <summary>
		/// 
		/// </summary>
		Vector3DF = ace.swig.ShaderVariableType.Vector3DF,
		/// <summary>
		/// 
		/// </summary>
		Vector4DF = ace.swig.ShaderVariableType.Vector4DF,
		/// <summary>
		/// 
		/// </summary>
		Vector4DF_Array = ace.swig.ShaderVariableType.Vector4DF_Array,
		/// <summary>
		/// 
		/// </summary>
		Matrix44 = ace.swig.ShaderVariableType.Matrix44,
		/// <summary>
		/// 
		/// </summary>
		Matrix44_Array = ace.swig.ShaderVariableType.Matrix44_Array,
		/// <summary>
		/// 
		/// </summary>
		Texture2D = ace.swig.ShaderVariableType.Texture2D,
		/// <summary>
		/// 
		/// </summary>
		CubemapTexture = ace.swig.ShaderVariableType.CubemapTexture,
	}

	/// <summary>
	/// 3D描画時に表示されるバッファ 
	///	</summary>
	public enum VisualizedBufferType : int
	{
		/// <summary>
		/// 
		/// </summary>
		FinalImage = ace.swig.VisualizedBufferType.FinalImage,
		/// <summary>
		/// 
		/// </summary>
		DiffuseColor = ace.swig.VisualizedBufferType.DiffuseColor,
		/// <summary>
		/// 
		/// </summary>
		SpecularColor = ace.swig.VisualizedBufferType.SpecularColor,
		/// <summary>
		/// 
		/// </summary>
		Normal = ace.swig.VisualizedBufferType.Normal,
		/// <summary>
		/// 
		/// </summary>
		Smoothness = ace.swig.VisualizedBufferType.Smoothness,
		/// <summary>
		/// 
		/// </summary>
		Environment = ace.swig.VisualizedBufferType.Environment,
		/// <summary>
		/// 
		/// </summary>
		Occlusion = ace.swig.VisualizedBufferType.Occlusion,
	}

	/// <summary>
	/// マウスボタンの押し状態を示す列挙型 
	///	</summary>
	public enum MouseButtonState : int
	{
		/// <summary>
		/// ボタンをこのフレームで押した状態 
		/// </summary>
		Push = ace.swig.MouseButtonState.Push,
		/// <summary>
		/// ボタンをこのフレームで離した状態 
		/// </summary>
		Release = ace.swig.MouseButtonState.Release,
		/// <summary>
		/// ボタンを離し続けている状態 
		/// </summary>
		Free = ace.swig.MouseButtonState.Free,
		/// <summary>
		/// ボタンを押し続けている状態 
		/// </summary>
		Hold = ace.swig.MouseButtonState.Hold,
	}

	/// <summary>
	/// ACEで扱うキーボードのキー一覧 
	///	</summary>
	public enum Keys : int
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = ace.swig.Keys.Unknown,
		/// <summary>
		/// 
		/// </summary>
		Space = ace.swig.Keys.Space,
		/// <summary>
		/// 
		/// </summary>
		Apostrophe = ace.swig.Keys.Apostrophe,
		/// <summary>
		/// 
		/// </summary>
		Comma = ace.swig.Keys.Comma,
		/// <summary>
		/// 
		/// </summary>
		Minus = ace.swig.Keys.Minus,
		/// <summary>
		/// 
		/// </summary>
		Period = ace.swig.Keys.Period,
		/// <summary>
		/// 
		/// </summary>
		Slash = ace.swig.Keys.Slash,
		/// <summary>
		/// 
		/// </summary>
		Num0 = ace.swig.Keys.Num0,
		/// <summary>
		/// 
		/// </summary>
		Num1 = ace.swig.Keys.Num1,
		/// <summary>
		/// 
		/// </summary>
		Num2 = ace.swig.Keys.Num2,
		/// <summary>
		/// 
		/// </summary>
		Num3 = ace.swig.Keys.Num3,
		/// <summary>
		/// 
		/// </summary>
		Num4 = ace.swig.Keys.Num4,
		/// <summary>
		/// 
		/// </summary>
		Num5 = ace.swig.Keys.Num5,
		/// <summary>
		/// 
		/// </summary>
		Num6 = ace.swig.Keys.Num6,
		/// <summary>
		/// 
		/// </summary>
		Num7 = ace.swig.Keys.Num7,
		/// <summary>
		/// 
		/// </summary>
		Num8 = ace.swig.Keys.Num8,
		/// <summary>
		/// 
		/// </summary>
		Num9 = ace.swig.Keys.Num9,
		/// <summary>
		/// 
		/// </summary>
		Semicolon = ace.swig.Keys.Semicolon,
		/// <summary>
		/// 
		/// </summary>
		Equal = ace.swig.Keys.Equal,
		/// <summary>
		/// 
		/// </summary>
		A = ace.swig.Keys.A,
		/// <summary>
		/// 
		/// </summary>
		B = ace.swig.Keys.B,
		/// <summary>
		/// 
		/// </summary>
		C = ace.swig.Keys.C,
		/// <summary>
		/// 
		/// </summary>
		D = ace.swig.Keys.D,
		/// <summary>
		/// 
		/// </summary>
		E = ace.swig.Keys.E,
		/// <summary>
		/// 
		/// </summary>
		F = ace.swig.Keys.F,
		/// <summary>
		/// 
		/// </summary>
		G = ace.swig.Keys.G,
		/// <summary>
		/// 
		/// </summary>
		H = ace.swig.Keys.H,
		/// <summary>
		/// 
		/// </summary>
		I = ace.swig.Keys.I,
		/// <summary>
		/// 
		/// </summary>
		J = ace.swig.Keys.J,
		/// <summary>
		/// 
		/// </summary>
		K = ace.swig.Keys.K,
		/// <summary>
		/// 
		/// </summary>
		L = ace.swig.Keys.L,
		/// <summary>
		/// 
		/// </summary>
		M = ace.swig.Keys.M,
		/// <summary>
		/// 
		/// </summary>
		N = ace.swig.Keys.N,
		/// <summary>
		/// 
		/// </summary>
		O = ace.swig.Keys.O,
		/// <summary>
		/// 
		/// </summary>
		P = ace.swig.Keys.P,
		/// <summary>
		/// 
		/// </summary>
		Q = ace.swig.Keys.Q,
		/// <summary>
		/// 
		/// </summary>
		R = ace.swig.Keys.R,
		/// <summary>
		/// 
		/// </summary>
		S = ace.swig.Keys.S,
		/// <summary>
		/// 
		/// </summary>
		T = ace.swig.Keys.T,
		/// <summary>
		/// 
		/// </summary>
		U = ace.swig.Keys.U,
		/// <summary>
		/// 
		/// </summary>
		V = ace.swig.Keys.V,
		/// <summary>
		/// 
		/// </summary>
		W = ace.swig.Keys.W,
		/// <summary>
		/// 
		/// </summary>
		X = ace.swig.Keys.X,
		/// <summary>
		/// 
		/// </summary>
		Y = ace.swig.Keys.Y,
		/// <summary>
		/// 
		/// </summary>
		Z = ace.swig.Keys.Z,
		/// <summary>
		/// 
		/// </summary>
		LeftBracket = ace.swig.Keys.LeftBracket,
		/// <summary>
		/// 
		/// </summary>
		Backslash = ace.swig.Keys.Backslash,
		/// <summary>
		/// 
		/// </summary>
		RightBracket = ace.swig.Keys.RightBracket,
		/// <summary>
		/// 
		/// </summary>
		GraveAccent = ace.swig.Keys.GraveAccent,
		/// <summary>
		/// 
		/// </summary>
		World1 = ace.swig.Keys.World1,
		/// <summary>
		/// 
		/// </summary>
		World2 = ace.swig.Keys.World2,
		/// <summary>
		/// 
		/// </summary>
		Escape = ace.swig.Keys.Escape,
		/// <summary>
		/// 
		/// </summary>
		Enter = ace.swig.Keys.Enter,
		/// <summary>
		/// 
		/// </summary>
		Tab = ace.swig.Keys.Tab,
		/// <summary>
		/// 
		/// </summary>
		Backspace = ace.swig.Keys.Backspace,
		/// <summary>
		/// 
		/// </summary>
		Insert = ace.swig.Keys.Insert,
		/// <summary>
		/// 
		/// </summary>
		Delete = ace.swig.Keys.Delete,
		/// <summary>
		/// 
		/// </summary>
		Right = ace.swig.Keys.Right,
		/// <summary>
		/// 
		/// </summary>
		Left = ace.swig.Keys.Left,
		/// <summary>
		/// 
		/// </summary>
		Down = ace.swig.Keys.Down,
		/// <summary>
		/// 
		/// </summary>
		Up = ace.swig.Keys.Up,
		/// <summary>
		/// 
		/// </summary>
		PageUp = ace.swig.Keys.PageUp,
		/// <summary>
		/// 
		/// </summary>
		PageDown = ace.swig.Keys.PageDown,
		/// <summary>
		/// 
		/// </summary>
		Home = ace.swig.Keys.Home,
		/// <summary>
		/// 
		/// </summary>
		End = ace.swig.Keys.End,
		/// <summary>
		/// 
		/// </summary>
		CapsLock = ace.swig.Keys.CapsLock,
		/// <summary>
		/// 
		/// </summary>
		ScrollLock = ace.swig.Keys.ScrollLock,
		/// <summary>
		/// 
		/// </summary>
		NumLock = ace.swig.Keys.NumLock,
		/// <summary>
		/// 
		/// </summary>
		PrintScreen = ace.swig.Keys.PrintScreen,
		/// <summary>
		/// 
		/// </summary>
		Pause = ace.swig.Keys.Pause,
		/// <summary>
		/// 
		/// </summary>
		F1 = ace.swig.Keys.F1,
		/// <summary>
		/// 
		/// </summary>
		F2 = ace.swig.Keys.F2,
		/// <summary>
		/// 
		/// </summary>
		F3 = ace.swig.Keys.F3,
		/// <summary>
		/// 
		/// </summary>
		F4 = ace.swig.Keys.F4,
		/// <summary>
		/// 
		/// </summary>
		F5 = ace.swig.Keys.F5,
		/// <summary>
		/// 
		/// </summary>
		F6 = ace.swig.Keys.F6,
		/// <summary>
		/// 
		/// </summary>
		F7 = ace.swig.Keys.F7,
		/// <summary>
		/// 
		/// </summary>
		F8 = ace.swig.Keys.F8,
		/// <summary>
		/// 
		/// </summary>
		F9 = ace.swig.Keys.F9,
		/// <summary>
		/// 
		/// </summary>
		F10 = ace.swig.Keys.F10,
		/// <summary>
		/// 
		/// </summary>
		F11 = ace.swig.Keys.F11,
		/// <summary>
		/// 
		/// </summary>
		F12 = ace.swig.Keys.F12,
		/// <summary>
		/// 
		/// </summary>
		F13 = ace.swig.Keys.F13,
		/// <summary>
		/// 
		/// </summary>
		F14 = ace.swig.Keys.F14,
		/// <summary>
		/// 
		/// </summary>
		F15 = ace.swig.Keys.F15,
		/// <summary>
		/// 
		/// </summary>
		F16 = ace.swig.Keys.F16,
		/// <summary>
		/// 
		/// </summary>
		F17 = ace.swig.Keys.F17,
		/// <summary>
		/// 
		/// </summary>
		F18 = ace.swig.Keys.F18,
		/// <summary>
		/// 
		/// </summary>
		F19 = ace.swig.Keys.F19,
		/// <summary>
		/// 
		/// </summary>
		F20 = ace.swig.Keys.F20,
		/// <summary>
		/// 
		/// </summary>
		F21 = ace.swig.Keys.F21,
		/// <summary>
		/// 
		/// </summary>
		F22 = ace.swig.Keys.F22,
		/// <summary>
		/// 
		/// </summary>
		F23 = ace.swig.Keys.F23,
		/// <summary>
		/// 
		/// </summary>
		F24 = ace.swig.Keys.F24,
		/// <summary>
		/// 
		/// </summary>
		F25 = ace.swig.Keys.F25,
		/// <summary>
		/// 
		/// </summary>
		Keypad0 = ace.swig.Keys.Keypad0,
		/// <summary>
		/// 
		/// </summary>
		Keypad1 = ace.swig.Keys.Keypad1,
		/// <summary>
		/// 
		/// </summary>
		Keypad2 = ace.swig.Keys.Keypad2,
		/// <summary>
		/// 
		/// </summary>
		Keypad3 = ace.swig.Keys.Keypad3,
		/// <summary>
		/// 
		/// </summary>
		Keypad4 = ace.swig.Keys.Keypad4,
		/// <summary>
		/// 
		/// </summary>
		Keypad5 = ace.swig.Keys.Keypad5,
		/// <summary>
		/// 
		/// </summary>
		Keypad6 = ace.swig.Keys.Keypad6,
		/// <summary>
		/// 
		/// </summary>
		Keypad7 = ace.swig.Keys.Keypad7,
		/// <summary>
		/// 
		/// </summary>
		Keypad8 = ace.swig.Keys.Keypad8,
		/// <summary>
		/// 
		/// </summary>
		Keypad9 = ace.swig.Keys.Keypad9,
		/// <summary>
		/// 
		/// </summary>
		KeypadDecimal = ace.swig.Keys.KeypadDecimal,
		/// <summary>
		/// 
		/// </summary>
		KeypadDivide = ace.swig.Keys.KeypadDivide,
		/// <summary>
		/// 
		/// </summary>
		KeypadMultiply = ace.swig.Keys.KeypadMultiply,
		/// <summary>
		/// 
		/// </summary>
		KeypadSubstract = ace.swig.Keys.KeypadSubstract,
		/// <summary>
		/// 
		/// </summary>
		KeypadAdd = ace.swig.Keys.KeypadAdd,
		/// <summary>
		/// 
		/// </summary>
		KeypadEnter = ace.swig.Keys.KeypadEnter,
		/// <summary>
		/// 
		/// </summary>
		KeypadEqual = ace.swig.Keys.KeypadEqual,
		/// <summary>
		/// 
		/// </summary>
		LeftShift = ace.swig.Keys.LeftShift,
		/// <summary>
		/// 
		/// </summary>
		LeftControl = ace.swig.Keys.LeftControl,
		/// <summary>
		/// 
		/// </summary>
		LeftAlt = ace.swig.Keys.LeftAlt,
		/// <summary>
		/// 
		/// </summary>
		LeftWin = ace.swig.Keys.LeftWin,
		/// <summary>
		/// 
		/// </summary>
		RightShift = ace.swig.Keys.RightShift,
		/// <summary>
		/// 
		/// </summary>
		RightControl = ace.swig.Keys.RightControl,
		/// <summary>
		/// 
		/// </summary>
		RightAlt = ace.swig.Keys.RightAlt,
		/// <summary>
		/// 
		/// </summary>
		RightWin = ace.swig.Keys.RightWin,
		/// <summary>
		/// 
		/// </summary>
		Menu = ace.swig.Keys.Menu,
		/// <summary>
		/// 
		/// </summary>
		Last = ace.swig.Keys.Last,
		/// <summary>
		/// 
		/// </summary>
		MAX = ace.swig.Keys.MAX,
	}

	/// <summary>
	/// キーボードの押下状態を示す列挙型 
	///	</summary>
	public enum KeyState : int
	{
		/// <summary>
		/// キーをこのフレームで押した状態 
		/// </summary>
		Push = ace.swig.KeyState.Push,
		/// <summary>
		/// キーをこのフレームで離した状態 
		/// </summary>
		Release = ace.swig.KeyState.Release,
		/// <summary>
		/// キーを押し続けている状態 
		/// </summary>
		Hold = ace.swig.KeyState.Hold,
		/// <summary>
		/// キーを離し続けている状態 
		/// </summary>
		Free = ace.swig.KeyState.Free,
	}

	/// <summary>
	/// ジョイスティックのボタンの押し状態を示す列挙型 
	///	</summary>
	public enum JoystickButtonState : int
	{
		/// <summary>
		/// ボタンをこのフレームで押した状態 
		/// </summary>
		Push = ace.swig.JoystickButtonState.Push,
		/// <summary>
		/// ボタンをこのフレームで離した状態 
		/// </summary>
		Release = ace.swig.JoystickButtonState.Release,
		/// <summary>
		/// ボタンを離し続けている状態 
		/// </summary>
		Free = ace.swig.JoystickButtonState.Free,
		/// <summary>
		/// ボタンを押し続けている状態 
		/// </summary>
		Hold = ace.swig.JoystickButtonState.Hold,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum LogLevel : int
	{
		/// <summary>
		/// 
		/// </summary>
		Error = ace.swig.LogLevel.Error,
		/// <summary>
		/// 
		/// </summary>
		Critical = ace.swig.LogLevel.Critical,
		/// <summary>
		/// 
		/// </summary>
		Warning = ace.swig.LogLevel.Warning,
		/// <summary>
		/// 
		/// </summary>
		Information = ace.swig.LogLevel.Information,
		/// <summary>
		/// 
		/// </summary>
		All = ace.swig.LogLevel.All,
	}

	/// <summary>
	/// 図形の種類 
	///	</summary>
	public enum ShapeType : int
	{
		/// <summary>
		/// 円 
		/// </summary>
		CircleShape = ace.swig.ShapeType.CircleShape,
		/// <summary>
		/// 弧 
		/// </summary>
		ArcShape = ace.swig.ShapeType.ArcShape,
		/// <summary>
		/// 線分 
		/// </summary>
		LineShape = ace.swig.ShapeType.LineShape,
		/// <summary>
		/// 矩形 
		/// </summary>
		RectangleShape = ace.swig.ShapeType.RectangleShape,
		/// <summary>
		/// 三角形 
		/// </summary>
		TriangleShape = ace.swig.ShapeType.TriangleShape,
		/// <summary>
		/// 多角形 
		/// </summary>
		PolygonShape = ace.swig.ShapeType.PolygonShape,
	}

	/// <summary>
	/// 
	///	</summary>
	public enum ChildMode : int
	{
		/// <summary>
		/// 
		/// </summary>
		Position = ace.swig.ChildMode.Position,
		/// <summary>
		/// 
		/// </summary>
		All = ace.swig.ChildMode.All,
		/// <summary>
		/// 
		/// </summary>
		Nothing = ace.swig.ChildMode.Nothing,
	}

	/// <summary>
	/// エフェクトの情報が記録されているクラス 
	/// </summary>
	public partial class Effect
	{
		internal ace.swig.Effect CoreInstance { get; set; }


	}


	/// <summary>
	/// ファイルの操作に関する処理を提供するクラス 
	/// </summary>
	public partial class File
	{
		internal ace.swig.File CoreInstance { get; set; }


		/// <summary>
		/// ファイル操作する時のルートのディレクトリを追加する。 
		/// </summary>
		/// <param name="path">ルートのディレクトリのパス </param>
		public void AddRootDirectory(string path)
		{
			CoreInstance.AddRootDirectory(path);
		}

		/// <summary>
		/// ファイル操作する時のルートのパスワード付パッケージを追加する。 
		/// </summary>
		/// <param name="path">パッケージのパス </param>
		/// <param name="password">パスワード </param>
		public void AddRootPackageWithPassword(string path, string password)
		{
			CoreInstance.AddRootPackageWithPassword(path, password);
		}

		/// <summary>
		/// ファイル操作する時のルートのパッケージを追加する。 
		/// </summary>
		/// <param name="path">パッケージのパス </param>
		public void AddRootPackage(string path)
		{
			CoreInstance.AddRootPackage(path);
		}

		/// <summary>
		/// 追加されたパッケージを全て消去する。 
		/// </summary>
		public void ClearRootDirectories()
		{
			CoreInstance.ClearRootDirectories();
		}

		/// <summary>
		/// ファイルが存在するか取得する。 
		/// </summary>
		/// <param name="path">ファイルのパス </param>
		/// <returns>ファイルが存在するか? </returns>
		public bool Exists(string path)
		{
			return CoreInstance.Exists(path);
		}

	}


	/// <summary>
	/// フォントの情報が記録されているクラス 
	/// </summary>
	public partial class Font
	{
		internal ace.swig.Font CoreInstance { get; set; }


		/// <summary>
		/// 描画テキストと描画方向を与えると、その文字の描画領域を返す。 
		/// </summary>
		/// <param name="text">描画テキスト </param>
		/// <param name="writingDirection">描画方向 </param>
		/// <returns>文字の描画領域 </returns>
		public ace.Vector2DI CalcTextureSize(string text, WritingDirection writingDirection)
		{
			return CoreInstance.CalcTextureSize(text, (ace.swig.WritingDirection)writingDirection);
		}

	}


	/// <summary>
	/// 複数の画像が格納されているクラス 
	/// </summary>
	public partial class ImagePackage
	{
		internal ace.swig.ImagePackage CoreInstance { get; set; }

		/// <summary>
		/// 格納されている画像の枚数を取得する。
		/// </summary>
		public int ImageCount
		{
			get { return CoreInstance.GetImageCount(); }
		}


		/// <summary>
		/// 格納されている画像の名称を取得する。 
		/// </summary>
		/// <param name="index">インデックス </param>
		/// <returns>名称 </returns>
		public string GetImageName(int index)
		{
			return CoreInstance.GetImageName(index);
		}

		/// <summary>
		/// 格納されている画像が配置される領域を取得する。 
		/// </summary>
		/// <param name="index">インデックス </param>
		/// <returns>領域 </returns>
		public ace.RectI GetImageArea(int index)
		{
			return CoreInstance.GetImageArea(index);
		}

	}


	/// <summary>
	/// 大量描画が可能な3Dモデルクラス 
	/// </summary>
	public partial class MassModel
	{
		internal ace.swig.MassModel CoreInstance { get; set; }

		/// <summary>
		/// モデルが持つアニメーションの個数を取得する。
		/// </summary>
		public int AnimationCount
		{
			get { return CoreInstance.GetAnimationCount(); }
		}


		/// <summary>
		/// モデルが持つアニメーションの名称を取得する。 
		/// </summary>
		/// <param name="index">アニメーションのインデックス </param>
		/// <returns>アニメーションの名称 </returns>
		public string GetAnimationName(int index)
		{
			return CoreInstance.GetAnimationName(index);
		}

		/// <summary>
		/// モデルが持つアニメーションの長さ(60フレーム単位)を取得する。 
		/// </summary>
		/// <param name="name">アニメーション名 </param>
		/// <returns>アニメーションの長さ </returns>
		public float GetAnimationLength(string name)
		{
			return CoreInstance.GetAnimationLength(name);
		}

		/// <summary>
		/// アニメーションがループするかを取得する。 
		/// </summary>
		/// <param name="name">アニメーション名 </param>
		/// <returns>ループするか? </returns>
		public bool GetIsAnimationLoopingMode(string name)
		{
			return CoreInstance.GetIsAnimationLoopingMode(name);
		}

		/// <summary>
		/// アニメーションがループするかを設定する。 
		/// </summary>
		/// <param name="name">アニメーション名 </param>
		/// <param name="isLoopingMode"></param>
		public void SetIsAnimationLoopingMode(string name, bool isLoopingMode)
		{
			CoreInstance.SetIsAnimationLoopingMode(name, isLoopingMode);
		}

	}


	/// <summary>
	/// 3Dメッシュのクラス 
	/// </summary>
	public partial class Mesh
	{
		internal ace.swig.Mesh CoreInstance { get; set; }


		/// <summary>
		/// 頂点を追加する。 
		/// </summary>
		/// <param name="position">座標 </param>
		/// <param name="normal">法線 </param>
		/// <param name="binormal">従法線 </param>
		/// <param name="uv1">UV1 </param>
		/// <param name="uv2">UV2 </param>
		/// <param name="color">頂点色 </param>
		/// <param name="boneWeights">ボーンのウエイト </param>
		/// <param name="boneIndexes">ボーンのインデックス </param>
		public void AddVertex(ace.Vector3DF position, ace.Vector3DF normal, ace.Vector3DF binormal, ace.Vector2DF uv1, ace.Vector2DF uv2, ace.Color color, int boneWeights, int boneIndexes)
		{
			CoreInstance.AddVertex(ref position, ref normal, ref binormal, ref uv1, ref uv2, ref color, boneWeights, boneIndexes);
		}

		/// <summary>
		/// 面を追加する。 
		/// </summary>
		/// <param name="index1">頂点インデックス1 </param>
		/// <param name="index2">頂点インデックス2 </param>
		/// <param name="index3">頂点インデックス3 </param>
		/// <param name="materialIndex">材質インデックス </param>
		public void AddFace(int index1, int index2, int index3, int materialIndex)
		{
			CoreInstance.AddFace(index1, index2, index3, materialIndex);
		}

		/// <summary>
		/// ボーンとの接続設定を追加する。 
		/// </summary>
		/// <param name="targetIndex">対象ボーンインデックス </param>
		/// <param name="boneToMesh">ボーンの行列をメッシュの行列に変換する行列 </param>
		public void AddBoneConnector(int targetIndex, ace.Matrix44 boneToMesh)
		{
			CoreInstance.AddBoneConnector(targetIndex, ref boneToMesh);
		}

		/// <summary>
		/// 材質を追加する。 
		/// </summary>
		/// <returns>材質のインデックス </returns>
		public int AddMaterial()
		{
			return CoreInstance.AddMaterial();
		}

		/// <summary>
		/// 設定した値をGPUに送信する。 
		/// </summary>
		public void SendToGPUMemory()
		{
			CoreInstance.SendToGPUMemory();
		}

		/// <summary>
		/// 内部シェーダーを使用する場合のカラーテクスチャを設定する。 
		/// </summary>
		/// <param name="materialIndex">材質のインデックス </param>
		/// <param name="texture"></param>
		public void SetColorTexture(int materialIndex, Texture2D texture)
		{
			var textureCore = texture != null ? texture.CoreInstance : null;
			CoreInstance.SetColorTexture(materialIndex, textureCore);
		}

		/// <summary>
		/// 内部シェーダーを使用する場合の法線テクスチャを設定する。 
		/// </summary>
		/// <param name="materialIndex">材質のインデックス </param>
		/// <param name="texture"></param>
		public void SetNormalTexture(int materialIndex, Texture2D texture)
		{
			var textureCore = texture != null ? texture.CoreInstance : null;
			CoreInstance.SetNormalTexture(materialIndex, textureCore);
		}

		/// <summary>
		/// 内部シェーダーを使用する場合の金属度テクスチャを設定する。 
		/// </summary>
		/// <param name="materialIndex">材質のインデックス </param>
		/// <param name="texture"></param>
		public void SetMetalnessTexture(int materialIndex, Texture2D texture)
		{
			var textureCore = texture != null ? texture.CoreInstance : null;
			CoreInstance.SetMetalnessTexture(materialIndex, textureCore);
		}

		/// <summary>
		/// 内部シェーダーを使用する場合の面平滑度テクスチャを設定する。 
		/// </summary>
		/// <param name="materialIndex">材質のインデックス </param>
		/// <param name="texture"></param>
		public void SetSmoothnessTexture(int materialIndex, Texture2D texture)
		{
			var textureCore = texture != null ? texture.CoreInstance : null;
			CoreInstance.SetSmoothnessTexture(materialIndex, textureCore);
		}

	}


	/// <summary>
	/// 3Dモデルクラス 
	/// </summary>
	public partial class Model
	{
		internal ace.swig.Model CoreInstance { get; set; }

		/// <summary>
		/// モデルが持つメッシュの個数を取得する。
		/// </summary>
		public int MeshCount
		{
			get { return CoreInstance.GetMeshCount(); }
		}

		/// <summary>
		/// モデルが持つアニメーションクリップの個数を取得する。
		/// </summary>
		public int AnimationClipCount
		{
			get { return CoreInstance.GetAnimationClipCount(); }
		}


		/// <summary>
		/// モデルが持つアニメーションクリップの名称を取得する。 
		/// </summary>
		/// <param name="index">アニメーションクリップのインデックス </param>
		/// <returns>アニメーションクリップの名称 </returns>
		public string GetAnimationClipName(int index)
		{
			return CoreInstance.GetAnimationClipName(index);
		}

	}


	/// <summary>
	/// 音を管理するクラス 
	/// </summary>
	public partial class Sound
	{
		internal ace.swig.Sound CoreInstance { get; set; }


		/// <summary>
		/// 音を再生する。 
		/// </summary>
		/// <param name="soundSource">音源 </param>
		/// <returns>ID </returns>
		public int Play(SoundSource soundSource)
		{
			var soundSourceCore = soundSource != null ? soundSource.CoreInstance : null;
			return CoreInstance.Play(soundSourceCore);
		}

		/// <summary>
		/// 音が再生中か、取得する。 
		/// </summary>
		/// <param name="id">ID </param>
		/// <returns>再生中か? </returns>
		public bool GetIsPlaying(int id)
		{
			return CoreInstance.GetIsPlaying(id);
		}

		/// <summary>
		/// 全ての再生中の音を停止する。 
		/// </summary>
		public void StopAll()
		{
			CoreInstance.StopAll();
		}

		/// <summary>
		/// 指定した音を停止する。 
		/// </summary>
		/// <param name="id">ID </param>
		public void Stop(int id)
		{
			CoreInstance.Stop(id);
		}

		/// <summary>
		/// 指定した音を一時停止する。 
		/// </summary>
		/// <param name="id">ID </param>
		public void Pause(int id)
		{
			CoreInstance.Pause(id);
		}

		/// <summary>
		/// 指定した一時停止中の音の一時停止を解除する。 
		/// </summary>
		/// <param name="id">ID </param>
		public void Resume(int id)
		{
			CoreInstance.Resume(id);
		}

		/// <summary>
		/// 指定した音の音量を設定する。 
		/// </summary>
		/// <param name="id">ID </param>
		/// <param name="volume">音量(0.0～1.0) </param>
		public void SetVolume(int id, float volume)
		{
			CoreInstance.SetVolume(id, volume);
		}

		/// <summary>
		/// 指定した音をフェードインさせる。 
		/// </summary>
		/// <param name="id">ID </param>
		/// <param name="second">フェードインに使用する時間(秒) </param>
		public void FadeIn(int id, float second)
		{
			CoreInstance.FadeIn(id, second);
		}

		/// <summary>
		/// 指定した音をフェードアウトさせる。 
		/// </summary>
		/// <param name="id">ID </param>
		/// <param name="second">フェードアウトに使用する時間(秒) </param>
		public void FadeOut(int id, float second)
		{
			CoreInstance.FadeOut(id, second);
		}

	}


	/// <summary>
	/// 音源のクラス 
	/// </summary>
	public partial class SoundSource
	{
		internal ace.swig.SoundSource CoreInstance { get; set; }

		/// <summary>
		/// ループポイントの開始地点(秒)を取得または設定する。
		/// </summary>
		public float LoopStartingPoint
		{
			get { return CoreInstance.GetLoopStartingPoint(); }
			set { CoreInstance.SetLoopStartingPoint(value); }
		}

		/// <summary>
		/// ループポイントの終了地点(秒)を取得または設定する。
		/// </summary>
		public float LoopEndPoint
		{
			get { return CoreInstance.GetLoopEndPoint(); }
			set { CoreInstance.SetLoopEndPoint(value); }
		}

		/// <summary>
		/// ループするかを取得または設定する。
		/// </summary>
		public bool IsLoopingMode
		{
			get { return CoreInstance.GetIsLoopingMode(); }
			set { CoreInstance.SetIsLoopingMode(value); }
		}

		/// <summary>
		/// 音の長さを取得する。
		/// </summary>
		public float Length
		{
			get { return CoreInstance.GetLength(); }
		}


	}


	/// <summary>
	/// 一括してファイルを読み込むクラス 
	/// </summary>
	public partial class StaticFile
	{
		internal ace.swig.StaticFile CoreInstance { get; set; }

		/// <summary>
		/// ファイルのパスを取得する。
		/// </summary>
		public string FullPath
		{
			get { return CoreInstance.GetFullPath(); }
		}

		/// <summary>
		/// 読み込まれたバッファの先頭のポインタを取得する。
		/// </summary>
		public System.IntPtr Data
		{
			get { return CoreInstance.GetData(); }
		}

		/// <summary>
		/// 読み込まれたバッファのサイズを取得する。
		/// </summary>
		public int Size
		{
			get { return CoreInstance.GetSize(); }
		}


	}


	/// <summary>
	/// 部分的にファイルを読み込むクラス 
	/// </summary>
	public partial class StreamFile
	{
		internal ace.swig.StreamFile CoreInstance { get; set; }

		/// <summary>
		/// ファイルのサイズを取得する。
		/// </summary>
		public int Size
		{
			get { return CoreInstance.GetSize(); }
		}

		/// <summary>
		/// ファイル内で現在読み込んでいる位置を取得する。
		/// </summary>
		public int CurrentPosition
		{
			get { return CoreInstance.GetCurrentPosition(); }
		}


	}


	/// <summary>
	/// 地形のクラス 
	/// </summary>
	public partial class Terrain3D
	{
		internal ace.swig.Terrain3D CoreInstance { get; set; }


		/// <summary>
		/// 新規に地形を作成する。 
		/// </summary>
		/// <param name="gridSize">グリッド1つ当たりの大きさ </param>
		/// <param name="gridWidthCount">横方向のグリッド数 </param>
		/// <param name="gridHeightCount">縦方向のグリッド数 </param>
		public void New(float gridSize, int gridWidthCount, int gridHeightCount)
		{
			CoreInstance.New(gridSize, gridWidthCount, gridHeightCount);
		}

		/// <summary>
		/// 素材を追加する。 
		/// </summary>
		/// <param name="name">素材名 </param>
		/// <param name="size">素材のテクスチャ1枚あたりの大きさ </param>
		/// <param name="color">色テクスチャのパス </param>
		/// <param name="normal">法線テクスチャのパス </param>
		/// <param name="metalness">スペキュラテクスチャのパス </param>
		public void AddSurface(string name, float size, string color, string normal, string metalness)
		{
			CoreInstance.AddSurface(name, size, color, normal, metalness);
		}

		/// <summary>
		/// 素材インデックスを取得する。 
		/// </summary>
		/// <param name="name">素材名 </param>
		/// <returns>素材インデックス </returns>
		public int GetSurfaceIndex(string name)
		{
			return CoreInstance.GetSurfaceIndex(name);
		}

		/// <summary>
		/// 素材を円形に割り当てる。 
		/// </summary>
		/// <param name="surfaceIndex">素材インデックス </param>
		/// <param name="x">円形の中心座標 </param>
		/// <param name="y">円形の中心座標 </param>
		/// <param name="radius">円形の半径 </param>
		/// <param name="value">割り当てる値(-255～255) </param>
		/// <param name="fallout">周囲のぼかし(0～1) </param>
		public void AssignSurfaceWithCircle(int surfaceIndex, float x, float y, float radius, float value, float fallout)
		{
			CoreInstance.AssignSurfaceWithCircle(surfaceIndex, x, y, radius, value, fallout);
		}

		/// <summary>
		/// 円形に地形を上下させる。 
		/// </summary>
		/// <param name="x">円形の中心座標 </param>
		/// <param name="y">円形の中心座標 </param>
		/// <param name="radius">円形の半径 </param>
		/// <param name="value">値 </param>
		/// <param name="fallout">周囲のぼかし(0～1) </param>
		public void RaiseWithCircle(float x, float y, float radius, float value, float fallout)
		{
			CoreInstance.RaiseWithCircle(x, y, radius, value, fallout);
		}

		/// <summary>
		/// 円形に崖の生成を伴う地形の上下をさせる。 
		/// </summary>
		/// <param name="x">円形の中心座標 </param>
		/// <param name="y">円形の中心座標 </param>
		/// <param name="radius">円形の半径 </param>
		/// <param name="value">値 </param>
		public void ChangeCliffesWithCircle(float x, float y, float radius, int value)
		{
			CoreInstance.ChangeCliffesWithCircle(x, y, radius, value);
		}

		/// <summary>
		/// 光線を飛ばし、衝突した位置を取得する。 
		/// </summary>
		/// <param name="from">光線を飛ばす元の位置 </param>
		/// <param name="to">光線を飛ばす先の位置 </param>
		/// <returns>光線が地形に衝突した位置。衝突しない場合、NaNを返す。 </returns>
		public ace.Vector3DF CastRay(ace.Vector3DF from, ace.Vector3DF to)
		{
			return CoreInstance.CastRay(ref from, ref to);
		}

	}


	/// <summary>
	/// 
	/// </summary>
	public partial class Texture2D
	{
		internal ace.swig.Texture2D CoreInstance { get; set; }

		/// <summary>
		/// テクスチャのサイズを取得する。
		/// </summary>
		public ace.Vector2DI Size
		{
			get { return CoreInstance.GetSize(); }
		}

		/// <summary>
		/// テクスチャのフォーマットを取得する。
		/// </summary>
		public TextureFormat Format
		{
			get { return (ace.TextureFormat)CoreInstance.GetFormat(); }
		}

		/// <summary>
		/// テクスチャのクラスの種類を取得する。
		/// </summary>
		public TextureClassType Type
		{
			get { return (ace.TextureClassType)CoreInstance.GetType(); }
		}


		/// <summary>
		/// テクスチャをファイルに保存する。 
		/// </summary>
		/// <param name="path">出力先 </param>
		/// <returns>成否 </returns>
		public bool Save(string path)
		{
			return CoreInstance.Save(path);
		}

		/// <summary>
		/// テクスチャをアンロックする。 
		/// </summary>
		public void Unlock()
		{
			CoreInstance.Unlock();
		}

	}


}