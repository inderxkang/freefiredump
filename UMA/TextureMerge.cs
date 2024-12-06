using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060EF")]
[ExecuteInEditMode]
public class TextureMerge : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20060F0")]
	public class TextureMergeRect
	{
		[Token(Token = "0x402D830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material mat;

		[Token(Token = "0x402D831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture tex;

		[Token(Token = "0x402D832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rect rect;

		[Token(Token = "0x402D833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rect srcRect;

		[MethodImpl(768)]
		[Token(Token = "0x6029101")]
		[Address(RVA = "0x4AF1F10", Offset = "0x4AF1F10", VA = "0x104AF1F10")]
		public TextureMergeRect()
		{
		}
	}

	[Token(Token = "0x402D819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera myCamera;

	[Token(Token = "0x402D81A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material material;

	[Token(Token = "0x402D81B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Shader normalShader;

	[Token(Token = "0x402D81C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Shader diffuseShader;

	[Token(Token = "0x402D81D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader dataShader;

	[Token(Token = "0x402D81E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Shader cutoutShader;

	[Token(Token = "0x402D81F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader skinShader;

	[Token(Token = "0x402D820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Shader blendShader;

	[Token(Token = "0x402D821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader maskShader;

	[Token(Token = "0x402D822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int textureMergeRectCount;

	[Token(Token = "0x402D823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextureMergeRect[] textureMergeRects;

	[Token(Token = "0x402D824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _MainTex;

	[Token(Token = "0x402D825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _ExtraTex;

	[Token(Token = "0x402D826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _Color;

	[Token(Token = "0x402D827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _AdditiveColor;

	[Token(Token = "0x402D828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _SecondAddtiveColor;

	[Token(Token = "0x402D829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int _AlphaTex;

	[Token(Token = "0x402D82A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _BiasScale;

	[Token(Token = "0x402D82B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _RegionCoord;

	[Token(Token = "0x402D82C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _ClipFlag;

	[Token(Token = "0x402D82D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _DestBlend;

	[Token(Token = "0x402D82E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Rect atlasRect;

	[Token(Token = "0x402D82F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int height;

	[MethodImpl(768)]
	[Token(Token = "0x60290F3")]
	[Address(RVA = "0x4AF1020", Offset = "0x4AF1020", VA = "0x104AF1020")]
	public TextureMerge()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x60290F4")]
	[Address(RVA = "0x4AF1028", Offset = "0x4AF1028", VA = "0x104AF1028")]
	private void Awake()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x60290F5")]
	[Address(RVA = "0x4AF1158", Offset = "0x4AF1158", VA = "0x104AF1158")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60290F6")]
	[Address(RVA = "0x4AF1248", Offset = "0x4AF1248", VA = "0x104AF1248")]
	private void DrawRect(ref TextureMergeRect textureMergeRect)
	{
	}

	[Token(Token = "0x60290F7")]
	[Address(RVA = "0x4AF1444", Offset = "0x4AF1444", VA = "0x104AF1444")]
	public void BlitTexture(ref RenderTexture renderTexture, float normalSpecTexScale)
	{
	}

	[Token(Token = "0x60290F8")]
	[Address(RVA = "0x4AF1B34", Offset = "0x4AF1B34", VA = "0x104AF1B34")]
	public void DrawAllRects(RenderTexture target, int width, int height, [Optional] Color background)
	{
	}

	[Token(Token = "0x60290F9")]
	[Address(RVA = "0x4AF19AC", Offset = "0x4AF19AC", VA = "0x104AF19AC")]
	public Vector4 SetBiasScale(Rect rect, int rtWidth, int rtHeight, Rect srcRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60290FA")]
	[Address(RVA = "0x4AF1C74", Offset = "0x4AF1C74", VA = "0x104AF1C74")]
	public void Reset()
	{
	}

	[Token(Token = "0x60290FB")]
	[Address(RVA = "0x4AF1C7C", Offset = "0x4AF1C7C", VA = "0x104AF1C7C")]
	internal void EnsureCapacity(int moduleCount)
	{
	}

	[Token(Token = "0x60290FC")]
	[Address(RVA = "0x4AF1F18", Offset = "0x4AF1F18", VA = "0x104AF1F18")]
	private void SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int textureType)
	{
	}

	[Token(Token = "0x60290FD")]
	[Address(RVA = "0x4AF275C", Offset = "0x4AF275C", VA = "0x104AF275C")]
	public void SetupModule(UMAData.MaterialFragment source, int textureType)
	{
	}

	[Token(Token = "0x60290FE")]
	[Address(RVA = "0x4AF29B0", Offset = "0x4AF29B0", VA = "0x104AF29B0")]
	public void SetupModule(UMAData.GeneratedMaterial atlas, int idx, int textureType)
	{
	}

	[Token(Token = "0x60290FF")]
	[Address(RVA = "0x4AF2ADC", Offset = "0x4AF2ADC", VA = "0x104AF2ADC")]
	private void SetupOverlay(UMAData.MaterialFragment source, int i2, int textureType)
	{
	}

	[Token(Token = "0x6029100")]
	[Address(RVA = "0x4AF2EB4", Offset = "0x4AF2EB4", VA = "0x104AF2EB4")]
	private bool SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int i2, Rect overlayRect, int textureType)
	{
		return default(bool);
	}
}
