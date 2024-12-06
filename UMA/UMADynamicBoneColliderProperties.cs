using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2006106")]
public class UMADynamicBoneColliderProperties : ScriptableObject
{
	[Token(Token = "0x402D915")]
	[FieldOffset(Offset = "0x18")]
	public string m_RootTransformName;

	[Token(Token = "0x402D916")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Center;

	[Token(Token = "0x402D917")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x402D918")]
	[FieldOffset(Offset = "0x30")]
	public float m_Height;

	[Token(Token = "0x402D919")]
	[FieldOffset(Offset = "0x34")]
	public DynamicBoneCollider.Direction m_Direction;

	[MethodImpl(768)]
	[Token(Token = "0x60291B9")]
	[Address(RVA = "0x4B01F48", Offset = "0x4B01F48", VA = "0x104B01F48")]
	public UMADynamicBoneColliderProperties()
	{
	}

	[Token(Token = "0x60291BA")]
	[Address(RVA = "0x4B01FC8", Offset = "0x4B01FC8", VA = "0x104B01FC8")]
	public void ApplyValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}

	[Token(Token = "0x60291BB")]
	[Address(RVA = "0x4B0201C", Offset = "0x4B0201C", VA = "0x104B0201C")]
	public void ReadValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}
}
