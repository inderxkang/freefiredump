using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060F8")]
public struct OptimizedBoneWeightV2
{
	[Token(Token = "0x402D876")]
	[FieldOffset(Offset = "0x0")]
	public uint boneIndex;

	[Token(Token = "0x402D877")]
	[FieldOffset(Offset = "0x4")]
	public uint weight;

	[Token(Token = "0x602913A")]
	[Address(RVA = "0x4ACA258", Offset = "0x4ACA258", VA = "0x104ACA258")]
	private static int FloatToByte(float x)
	{
		return default(int);
	}

	[Token(Token = "0x602913B")]
	[Address(RVA = "0x4ACA350", Offset = "0x4ACA350", VA = "0x104ACA350")]
	private static float ByteToFloat(uint x)
	{
		return default(float);
	}

	[Token(Token = "0x602913C")]
	[Address(RVA = "0x4ACA364", Offset = "0x4ACA364", VA = "0x104ACA364")]
	public static uint ConvertToUInt(float x, float y, float z, float w)
	{
		return default(uint);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602913D")]
	[Address(RVA = "0x4ACA3D4", Offset = "0x4ACA3D4", VA = "0x104ACA3D4")]
	public static implicit operator OptimizedBoneWeightV2(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602913E")]
	[Address(RVA = "0x4ACA4A4", Offset = "0x4ACA4A4", VA = "0x104ACA4A4")]
	public static implicit operator OptimizedBoneWeightV2(OptimizedBoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602913F")]
	[Address(RVA = "0x4ACA4D0", Offset = "0x4ACA4D0", VA = "0x104ACA4D0")]
	public static implicit operator BoneWeight(OptimizedBoneWeightV2 sourceWeight)
	{
		return default(BoneWeight);
	}

	[Token(Token = "0x6029140")]
	[Address(RVA = "0x4ACA5B8", Offset = "0x4ACA5B8", VA = "0x104ACA5B8")]
	public static BoneWeight[] Convert(OptimizedBoneWeightV2[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x6029141")]
	[Address(RVA = "0x4ACA6BC", Offset = "0x4ACA6BC", VA = "0x104ACA6BC")]
	public static OptimizedBoneWeightV2[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x6029142")]
	[Address(RVA = "0x5CFFC", Offset = "0x5CFFC", VA = "0x10005CFFC")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x6029143")]
	[Address(RVA = "0x5D004", Offset = "0x5D004", VA = "0x10005D004")]
	public void ExplicitTranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x6029144")]
	[Address(RVA = "0x4ACAA94", Offset = "0x4ACAA94", VA = "0x104ACAA94")]
	public static OptimizedBoneWeightV2 UpdateBoneIndex(ref OptimizedBoneWeightV2 source, int[] indexMapping)
	{
		return default(OptimizedBoneWeightV2);
	}
}
