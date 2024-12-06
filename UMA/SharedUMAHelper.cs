using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060E6")]
public class SharedUMAHelper
{
	[Token(Token = "0x20060E7")]
	public class UMASharedData
	{
		[Token(Token = "0x402D7EA")]
		[FieldOffset(Offset = "0x10")]
		public List<Texture[]> sharedResultingTextures;

		[Token(Token = "0x402D7EB")]
		[FieldOffset(Offset = "0x18")]
		public Mesh sharedMesh;

		[MethodImpl(768)]
		[Token(Token = "0x60290A4")]
		[Address(RVA = "0x4ACFA24", Offset = "0x4ACFA24", VA = "0x104ACFA24")]
		public UMASharedData()
		{
		}
	}

	[Token(Token = "0x402D7E9")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<uint, UMASharedData> sharedData;

	[MethodImpl(768)]
	[Token(Token = "0x602909E")]
	[Address(RVA = "0x4ACF5D4", Offset = "0x4ACF5D4", VA = "0x104ACF5D4")]
	public SharedUMAHelper()
	{
	}

	[Token(Token = "0x602909F")]
	[Address(RVA = "0x4ACF5DC", Offset = "0x4ACF5DC", VA = "0x104ACF5DC")]
	public static bool SharedTexExist(UMAData umaData)
	{
		return default(bool);
	}

	[Token(Token = "0x60290A0")]
	[Address(RVA = "0x4ACF6B4", Offset = "0x4ACF6B4", VA = "0x104ACF6B4")]
	public static void SaveSharedTex(UMAData umaData)
	{
	}

	[Token(Token = "0x60290A1")]
	[Address(RVA = "0x4ACFA2C", Offset = "0x4ACFA2C", VA = "0x104ACFA2C")]
	public static bool SharedMeshExist(UMAData umaData)
	{
		return default(bool);
	}

	[Token(Token = "0x60290A2")]
	[Address(RVA = "0x4ACFB30", Offset = "0x4ACFB30", VA = "0x104ACFB30")]
	public static void SaveSharedMesh(UMAData umaData)
	{
	}

	[Token(Token = "0x60290A3")]
	[Address(RVA = "0x4ACFCD8", Offset = "0x4ACFCD8", VA = "0x104ACFCD8")]
	public static void ReleaseSharedData()
	{
	}
}
