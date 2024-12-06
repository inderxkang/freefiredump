using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2006107")]
public class UMADynamicBoneProperties : ScriptableObject
{
	[Token(Token = "0x402D91A")]
	[FieldOffset(Offset = "0x18")]
	public float m_UpdateRate;

	[Token(Token = "0x402D91B")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2D3420", Offset = "0x2D3420")]
	public float m_Damping;

	[Token(Token = "0x402D91C")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2D3438", Offset = "0x2D3438")]
	public float m_Elasticity;

	[Token(Token = "0x402D91D")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2D3450", Offset = "0x2D3450")]
	public float m_Stiffness;

	[Token(Token = "0x402D91E")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2D3468", Offset = "0x2D3468")]
	public float m_Inert;

	[Token(Token = "0x402D91F")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x402D920")]
	[FieldOffset(Offset = "0x30")]
	public float m_EndLength;

	[Token(Token = "0x402D921")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x402D922")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_Gravity;

	[Token(Token = "0x402D923")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_Force;

	[Token(Token = "0x402D924")]
	[FieldOffset(Offset = "0x58")]
	public bool m_AnimationControlled;

	[Token(Token = "0x402D925")]
	[FieldOffset(Offset = "0x59")]
	public bool m_useNet;

	[Token(Token = "0x402D926")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 m_RandomAcceleration;

	[Token(Token = "0x402D927")]
	[FieldOffset(Offset = "0x68")]
	public int m_RandomAccelerationInterval;

	[MethodImpl(768)]
	[Token(Token = "0x60291BC")]
	[Address(RVA = "0x4B02068", Offset = "0x4B02068", VA = "0x104B02068")]
	public UMADynamicBoneProperties()
	{
	}

	[Token(Token = "0x60291BD")]
	[Address(RVA = "0x4B02124", Offset = "0x4B02124", VA = "0x104B02124")]
	public void ApplyValues(DynamicBone dynamicBone, Transform root)
	{
	}

	[Token(Token = "0x60291BE")]
	[Address(RVA = "0x4B021DC", Offset = "0x4B021DC", VA = "0x104B021DC")]
	public void ApplyValues(DynamicBoneNet dynamicBoneNet, Transform root)
	{
	}

	[Token(Token = "0x60291BF")]
	[Address(RVA = "0x4B02294", Offset = "0x4B02294", VA = "0x104B02294")]
	public void ReadValues(DynamicBone dynamicBone)
	{
	}
}
