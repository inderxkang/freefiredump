using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006120")]
public static class OptimizedVector
{
	[Token(Token = "0x602923E")]
	[Address(RVA = "0x4ACAAD0", Offset = "0x4ACAAD0", VA = "0x104ACAAD0")]
	private static int FloatToByte(float x)
	{
		return default(int);
	}

	[Token(Token = "0x602923F")]
	[Address(RVA = "0x4ACABC0", Offset = "0x4ACABC0", VA = "0x104ACABC0")]
	private static float ByteToFloat(uint x)
	{
		return default(float);
	}

	[Token(Token = "0x6029240")]
	[Address(RVA = "0x4ACABD4", Offset = "0x4ACABD4", VA = "0x104ACABD4")]
	public static uint ConvertToUInt(ref Vector3 normal)
	{
		return default(uint);
	}

	[Token(Token = "0x6029241")]
	[Address(RVA = "0x4ACACAC", Offset = "0x4ACACAC", VA = "0x104ACACAC")]
	public static uint ConvertToUInt(ref Vector4 normal)
	{
		return default(uint);
	}

	[Token(Token = "0x6029242")]
	[Address(RVA = "0x4ACADA8", Offset = "0x4ACADA8", VA = "0x104ACADA8")]
	public static void ConvertToVector4(uint data, out Vector4 res)
	{
	}

	[Token(Token = "0x6029243")]
	[Address(RVA = "0x4ACAEE4", Offset = "0x4ACAEE4", VA = "0x104ACAEE4")]
	public static void ConvertToVector3(uint data, out Vector3 res)
	{
	}

	[Token(Token = "0x6029244")]
	[Address(RVA = "0x4ACB000", Offset = "0x4ACB000", VA = "0x104ACB000")]
	public static Vector3[] ConvertToVector3s(uint[] ops)
	{
		return null;
	}

	[Token(Token = "0x6029245")]
	[Address(RVA = "0x4ACB12C", Offset = "0x4ACB12C", VA = "0x104ACB12C")]
	public static Vector4[] ConvertToVector4s(uint[] ops)
	{
		return null;
	}

	[Token(Token = "0x6029246")]
	[Address(RVA = "0x4ACB254", Offset = "0x4ACB254", VA = "0x104ACB254")]
	public static uint[] ConvertFromVector4sToUInts(Vector4[] vs)
	{
		return null;
	}

	[Token(Token = "0x6029247")]
	[Address(RVA = "0x4ACB360", Offset = "0x4ACB360", VA = "0x104ACB360")]
	public static uint[] ConvertFromVector3sToUInts(Vector3[] vs)
	{
		return null;
	}
}
