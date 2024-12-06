using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006125")]
public class UMARenderTexturePoolManager
{
	[Token(Token = "0x402D9DB")]
	[FieldOffset(Offset = "0x0")]
	private static UMARenderTexturePoolManager _instance;

	[Token(Token = "0x402D9DC")]
	[FieldOffset(Offset = "0x8")]
	public static int MAX_CACHE;

	[Token(Token = "0x402D9DD")]
	[FieldOffset(Offset = "0xC")]
	public static int freeCount;

	[Token(Token = "0x402D9DE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, UMARenderTexturePool> mPools;

	[Token(Token = "0x17002994")]
	public static UMARenderTexturePoolManager instance
	{
		[MethodImpl(512)]
		[Token(Token = "0x602927F")]
		[Address(RVA = "0x4B115F0", Offset = "0x4B115F0", VA = "0x104B115F0")]
		get
		{
			return null;
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x602927E")]
	[Address(RVA = "0x4B11580", Offset = "0x4B11580", VA = "0x104B11580")]
	private UMARenderTexturePoolManager()
	{
	}

	[Token(Token = "0x6029280")]
	[Address(RVA = "0x4B116B0", Offset = "0x4B116B0", VA = "0x104B116B0")]
	public RenderTexture GetRenderTexture(int width, int height, RenderTextureFormat textFormat, bool enableMipmap)
	{
		return null;
	}

	[Token(Token = "0x6029281")]
	[Address(RVA = "0x4B117F8", Offset = "0x4B117F8", VA = "0x104B117F8")]
	public void RecycleRenderTexture(RenderTexture rt)
	{
	}

	[Token(Token = "0x6029282")]
	[Address(RVA = "0x4B118C4", Offset = "0x4B118C4", VA = "0x104B118C4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6029283")]
	[Address(RVA = "0x4B11700", Offset = "0x4B11700", VA = "0x104B11700")]
	private UMARenderTexturePool GetPool(RenderTextureFormat textFormat)
	{
		return null;
	}

	[Token(Token = "0x6029284")]
	[Address(RVA = "0x4B11A34", Offset = "0x4B11A34", VA = "0x104B11A34")]
	public bool UseRenderTextureGetTemporary()
	{
		return default(bool);
	}
}
