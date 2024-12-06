using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006126")]
internal class UMARenderTexturePool
{
	[Token(Token = "0x402D9DF")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, List<RenderTexture>> mTexturePool;

	[Token(Token = "0x402D9E0")]
	[FieldOffset(Offset = "0x18")]
	private RenderTextureDescriptor mTextureDescriptor;

	[Token(Token = "0x402D9E1")]
	[FieldOffset(Offset = "0x44")]
	private RenderTextureFormat mTextureFormat;

	[MethodImpl(768)]
	[Token(Token = "0x6029286")]
	[Address(RVA = "0x4B10AC8", Offset = "0x4B10AC8", VA = "0x104B10AC8")]
	public UMARenderTexturePool(RenderTextureFormat textureFMT)
	{
	}

	[Token(Token = "0x6029287")]
	[Address(RVA = "0x4B10B90", Offset = "0x4B10B90", VA = "0x104B10B90")]
	public void RecylceRenderTexture(RenderTexture rt)
	{
	}

	[Token(Token = "0x6029288")]
	[Address(RVA = "0x4B10DB0", Offset = "0x4B10DB0", VA = "0x104B10DB0")]
	public RenderTexture GetRenderTexture(int width, int height, bool enableMipmap)
	{
		return null;
	}

	[Token(Token = "0x6029289")]
	[Address(RVA = "0x4B111BC", Offset = "0x4B111BC", VA = "0x104B111BC")]
	public void Clean()
	{
	}

	[Token(Token = "0x602928A")]
	[Address(RVA = "0x4B10D98", Offset = "0x4B10D98", VA = "0x104B10D98")]
	private int GetHashKey(int width, int height, bool enableMipmap)
	{
		return default(int);
	}

	[Token(Token = "0x602928B")]
	[Address(RVA = "0x4B114B0", Offset = "0x4B114B0", VA = "0x104B114B0")]
	public static void RelaseSingle(RenderTexture rt)
	{
	}

	[Token(Token = "0x602928C")]
	[Address(RVA = "0x4B110C0", Offset = "0x4B110C0", VA = "0x104B110C0")]
	public static bool UseRenderTextureGetTemporary()
	{
		return default(bool);
	}
}
