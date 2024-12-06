using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060FA")]
public struct UMABoneWeight
{
	[Token(Token = "0x402D87B")]
	[FieldOffset(Offset = "0x0")]
	public int boneIndex0;

	[Token(Token = "0x402D87C")]
	[FieldOffset(Offset = "0x4")]
	public int boneIndex1;

	[Token(Token = "0x402D87D")]
	[FieldOffset(Offset = "0x8")]
	public int boneIndex2;

	[Token(Token = "0x402D87E")]
	[FieldOffset(Offset = "0xC")]
	public int boneIndex3;

	[Token(Token = "0x402D87F")]
	[FieldOffset(Offset = "0x10")]
	public float weight0;

	[Token(Token = "0x402D880")]
	[FieldOffset(Offset = "0x14")]
	public float weight1;

	[Token(Token = "0x402D881")]
	[FieldOffset(Offset = "0x18")]
	public float weight2;

	[Token(Token = "0x402D882")]
	[FieldOffset(Offset = "0x1C")]
	public float weight3;

	[Token(Token = "0x602914F")]
	[Address(RVA = "0x4AF8944", Offset = "0x4AF8944", VA = "0x104AF8944")]
	public static UMABoneWeight UpdateBoneIndex(ref UMABoneWeight source, int[] indexMapping)
	{
		return default(UMABoneWeight);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029150")]
	[Address(RVA = "0x4AF8AD4", Offset = "0x4AF8AD4", VA = "0x104AF8AD4")]
	public static implicit operator UMABoneWeight(BoneWeight sourceWeight)
	{
		return default(UMABoneWeight);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029151")]
	[Address(RVA = "0x4AF8B9C", Offset = "0x4AF8B9C", VA = "0x104AF8B9C")]
	public static implicit operator BoneWeight(UMABoneWeight sourceWeight)
	{
		return default(BoneWeight);
	}

	[Token(Token = "0x6029152")]
	[Address(RVA = "0x5D5DC", Offset = "0x5D5DC", VA = "0x10005D5DC")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x6029153")]
	[Address(RVA = "0x4AF8C54", Offset = "0x4AF8C54", VA = "0x104AF8C54")]
	public static UMABoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x6029154")]
	[Address(RVA = "0x4AF8D60", Offset = "0x4AF8D60", VA = "0x104AF8D60")]
	public static BoneWeight[] Convert(UMABoneWeight[] boneWeights)
	{
		return null;
	}
}
