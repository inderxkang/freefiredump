using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x200612A")]
public class UmaTPose : ScriptableObject
{
	[NonSerialized]
	[Token(Token = "0x402D9EF")]
	[FieldOffset(Offset = "0x18")]
	public SkeletonBone[] boneInfo;

	[NonSerialized]
	[Token(Token = "0x402D9F0")]
	[FieldOffset(Offset = "0x20")]
	public HumanBone[] humanInfo;

	[NonSerialized]
	[Token(Token = "0x402D9F1")]
	[FieldOffset(Offset = "0x28")]
	public float armStretch;

	[NonSerialized]
	[Token(Token = "0x402D9F2")]
	[FieldOffset(Offset = "0x2C")]
	public float feetSpacing;

	[NonSerialized]
	[Token(Token = "0x402D9F3")]
	[FieldOffset(Offset = "0x30")]
	public float legStretch;

	[NonSerialized]
	[Token(Token = "0x402D9F4")]
	[FieldOffset(Offset = "0x34")]
	public float lowerArmTwist;

	[NonSerialized]
	[Token(Token = "0x402D9F5")]
	[FieldOffset(Offset = "0x38")]
	public float lowerLegTwist;

	[NonSerialized]
	[Token(Token = "0x402D9F6")]
	[FieldOffset(Offset = "0x3C")]
	public float upperArmTwist;

	[NonSerialized]
	[Token(Token = "0x402D9F7")]
	[FieldOffset(Offset = "0x40")]
	public float upperLegTwist;

	[NonSerialized]
	[Token(Token = "0x402D9F8")]
	[FieldOffset(Offset = "0x44")]
	public bool extendedInfo;

	[Token(Token = "0x402D9F9")]
	[FieldOffset(Offset = "0x48")]
	public byte[] serializedChunk;

	[MethodImpl(768)]
	[Token(Token = "0x60292A7")]
	[Address(RVA = "0x4B16E0C", Offset = "0x4B16E0C", VA = "0x104B16E0C")]
	public UmaTPose()
	{
	}

	[Token(Token = "0x60292A8")]
	[Address(RVA = "0x4B16E14", Offset = "0x4B16E14", VA = "0x104B16E14")]
	public void DeSerialize()
	{
	}

	[Token(Token = "0x60292A9")]
	[Address(RVA = "0x4B17200", Offset = "0x4B17200", VA = "0x104B17200")]
	private SkeletonBone DeSerializeSkeletonBone(BinaryReader br)
	{
		return default(SkeletonBone);
	}

	[Token(Token = "0x60292AA")]
	[Address(RVA = "0x4B174C0", Offset = "0x4B174C0", VA = "0x104B174C0")]
	private Quaternion DeSerializeQuaternion(BinaryReader br)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60292AB")]
	[Address(RVA = "0x4B17314", Offset = "0x4B17314", VA = "0x104B17314")]
	private HumanBone DeSerializeHumanBone(BinaryReader br)
	{
		return default(HumanBone);
	}

	[Token(Token = "0x60292AC")]
	[Address(RVA = "0x4B175C4", Offset = "0x4B175C4", VA = "0x104B175C4")]
	private HumanLimit DeSerializeHumanLimit(BinaryReader br)
	{
		return default(HumanLimit);
	}

	[Token(Token = "0x60292AD")]
	[Address(RVA = "0x4B173F8", Offset = "0x4B173F8", VA = "0x104B173F8")]
	private Vector3 DeserializeVector3(BinaryReader br)
	{
		return default(Vector3);
	}
}
