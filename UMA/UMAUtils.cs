using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200612C")]
public static class UMAUtils
{
	[Token(Token = "0x402D9FF")]
	public const string SKIN_COLOR_NAME = "Skin";

	[Token(Token = "0x402DA00")]
	public const int SKIN_COLOR_INDEX = 1;

	[Token(Token = "0x402DA01")]
	public const int NONE_COLOR_INDEX = 0;

	[Token(Token = "0x60292AE")]
	[Address(RVA = "0x4B135F4", Offset = "0x4B135F4", VA = "0x104B135F4")]
	public static Transform FindMyChild(Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60292AF")]
	[Address(RVA = "0x4B1372C", Offset = "0x4B1372C", VA = "0x104B1372C")]
	public static Transform FindChildExpend(this Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60292B0")]
	[Address(RVA = "0x4B13864", Offset = "0x4B13864", VA = "0x104B13864")]
	public static Transform FindChildCompomentExpend(this Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60292B1")]
	[Address(RVA = "0x4B0C950", Offset = "0x4B0C950", VA = "0x104B0C950")]
	public static int StringToHash(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60292B2")]
	[Address(RVA = "0x4B13930", Offset = "0x4B13930", VA = "0x104B13930")]
	public static float GaussianRandom(float mean, float dev)
	{
		return default(float);
	}

	[Token(Token = "0x60292B3")]
	[Address(RVA = "0x4B139EC", Offset = "0x4B139EC", VA = "0x104B139EC")]
	public static int Count1(int n)
	{
		return default(int);
	}

	[Token(Token = "0x60292B4")]
	[Address(RVA = "0x4B13A0C", Offset = "0x4B13A0C", VA = "0x104B13A0C")]
	public static OverlayColorData[] CreateDefaultColors()
	{
		return null;
	}

	[Token(Token = "0x60292B5")]
	[Address(RVA = "0x4B13B4C", Offset = "0x4B13B4C", VA = "0x104B13B4C")]
	public static OverlayColorData CreateDefaultColor(string name)
	{
		return null;
	}

	[Token(Token = "0x60292B6")]
	[Address(RVA = "0x4B13D74", Offset = "0x4B13D74", VA = "0x104B13D74")]
	public static OverlayColorData GetColor(string name, OverlayColorData[] colors)
	{
		return null;
	}
}
