using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060F9")]
public struct OptimizedBoneWeight
{
	[Token(Token = "0x402D878")]
	[FieldOffset(Offset = "0x0")]
	public uint boneIndex;

	[Token(Token = "0x402D879")]
	[FieldOffset(Offset = "0x4")]
	public uint weight01;

	[Token(Token = "0x402D87A")]
	[FieldOffset(Offset = "0x8")]
	public uint weight23;

	[Token(Token = "0x6029145")]
	[Address(RVA = "0x4AC9AC4", Offset = "0x4AC9AC4", VA = "0x104AC9AC4")]
	private static ushort FloatToUShort(float weight)
	{
		return default(ushort);
	}

	[Token(Token = "0x6029146")]
	[Address(RVA = "0x4AC9ADC", Offset = "0x4AC9ADC", VA = "0x104AC9ADC")]
	private static float ShortToFloat(ushort weight)
	{
		return default(float);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029147")]
	[Address(RVA = "0x4AC9AF0", Offset = "0x4AC9AF0", VA = "0x104AC9AF0")]
	public static implicit operator OptimizedBoneWeight(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029148")]
	[Address(RVA = "0x4AC9BCC", Offset = "0x4AC9BCC", VA = "0x104AC9BCC")]
	public static implicit operator OptimizedBoneWeight(UMABoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029149")]
	[Address(RVA = "0x4AC9C20", Offset = "0x4AC9C20", VA = "0x104AC9C20")]
	public static implicit operator BoneWeight(OptimizedBoneWeight sourceWeight)
	{
		return default(BoneWeight);
	}

	[Token(Token = "0x602914A")]
	[Address(RVA = "0x5CFEC", Offset = "0x5CFEC", VA = "0x10005CFEC")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x602914B")]
	[Address(RVA = "0x5CFF4", Offset = "0x5CFF4", VA = "0x10005CFF4")]
	public void ExplicitTranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x602914C")]
	[Address(RVA = "0x4AC9FE4", Offset = "0x4AC9FE4", VA = "0x104AC9FE4")]
	public static OptimizedBoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x602914D")]
	[Address(RVA = "0x4ACA100", Offset = "0x4ACA100", VA = "0x104ACA100")]
	public static BoneWeight[] Convert(OptimizedBoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x602914E")]
	[Address(RVA = "0x4ACA218", Offset = "0x4ACA218", VA = "0x104ACA218")]
	public static OptimizedBoneWeight UpdateBoneIndex(ref OptimizedBoneWeight source, int[] indexMapping)
	{
		return default(OptimizedBoneWeight);
	}
}
