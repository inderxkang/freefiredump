using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200611F")]
public static class UVOptimize
{
	[Token(Token = "0x6029238")]
	[Address(RVA = "0x4B13E80", Offset = "0x4B13E80", VA = "0x104B13E80")]
	private static uint FloatToUShort(float x)
	{
		return default(uint);
	}

	[Token(Token = "0x6029239")]
	[Address(RVA = "0x4B13EC8", Offset = "0x4B13EC8", VA = "0x104B13EC8")]
	public static float UShortToFloat(uint value)
	{
		return default(float);
	}

	[Token(Token = "0x602923A")]
	[Address(RVA = "0x4B13EDC", Offset = "0x4B13EDC", VA = "0x104B13EDC")]
	public static uint Convert(ref Vector2 uv)
	{
		return default(uint);
	}

	[Token(Token = "0x602923B")]
	[Address(RVA = "0x4B0E638", Offset = "0x4B0E638", VA = "0x104B0E638")]
	public static void ConvertToVector2(uint value, out Vector2 v)
	{
	}

	[Token(Token = "0x602923C")]
	[Address(RVA = "0x4B0F184", Offset = "0x4B0F184", VA = "0x104B0F184")]
	public static Vector2[] ConvertToUVs(uint[] opvs)
	{
		return null;
	}

	[Token(Token = "0x602923D")]
	[Address(RVA = "0x4B13F6C", Offset = "0x4B13F6C", VA = "0x104B13F6C")]
	public static uint[] ConvertFromUVs(Vector2[] uvs)
	{
		return null;
	}
}
