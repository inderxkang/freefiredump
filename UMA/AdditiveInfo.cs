using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x20060C4")]
public class AdditiveInfo
{
	[Token(Token = "0x402D74A")]
	[FieldOffset(Offset = "0x10")]
	public EAdditiveTargetSlot TargetSlot;

	[Token(Token = "0x402D74B")]
	[FieldOffset(Offset = "0x11")]
	public byte SlotIndex;

	[Token(Token = "0x402D74C")]
	[FieldOffset(Offset = "0x12")]
	public byte OverlayOrder;

	[Token(Token = "0x402D74D")]
	[FieldOffset(Offset = "0x13")]
	public EAdditiveMethod Method;

	[Token(Token = "0x402D74E")]
	[FieldOffset(Offset = "0x14")]
	public EAdditiveOrderType OrderType;

	[Token(Token = "0x1700297E")]
	public EWardrobeSlot TargetWardrobeSlot
	{
		[MethodImpl(512)]
		[Token(Token = "0x6028FC6")]
		[Address(RVA = "0x4AC603C", Offset = "0x4AC603C", VA = "0x104AC603C")]
		get
		{
			return default(EWardrobeSlot);
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6028FC5")]
	[Address(RVA = "0x4AC6034", Offset = "0x4AC6034", VA = "0x104AC6034")]
	public AdditiveInfo()
	{
	}

	[Token(Token = "0x6028FC7")]
	[Address(RVA = "0x4AC6048", Offset = "0x4AC6048", VA = "0x104AC6048")]
	public static AdditiveInfo DeserializeFromByte(byte b)
	{
		return null;
	}

	[Token(Token = "0x6028FC8")]
	[Address(RVA = "0x4AC60DC", Offset = "0x4AC60DC", VA = "0x104AC60DC")]
	public static bool NotNullOrEmpty(AdditiveInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FC9")]
	[Address(RVA = "0x4AC60F0", Offset = "0x4AC60F0", VA = "0x104AC60F0")]
	public static bool IsNullOrEmpty(AdditiveInfo info)
	{
		return default(bool);
	}
}
