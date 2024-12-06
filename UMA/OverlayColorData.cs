using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060DF")]
public class OverlayColorData : IEquatable<OverlayColorData>
{
	[Token(Token = "0x402D7D1")]
	public const string UNSHARED = "-";

	[Token(Token = "0x402D7D2")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x402D7D3")]
	[FieldOffset(Offset = "0x18")]
	public Color[] channelMask;

	[Token(Token = "0x402D7D4")]
	[FieldOffset(Offset = "0x20")]
	public Color[] channelAdditiveMask;

	[Token(Token = "0x17002980")]
	public Color color
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029060")]
		[Address(RVA = "0x4ACB6EC", Offset = "0x4ACB6EC", VA = "0x104ACB6EC")]
		get
		{
			return default(Color);
		}
		[MethodImpl(512)]
		[Token(Token = "0x6029061")]
		[Address(RVA = "0x4ACB75C", Offset = "0x4ACB75C", VA = "0x104ACB75C")]
		set
		{
		}
	}

	[Token(Token = "0x17002981")]
	public bool IsASharedColor
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029064")]
		[Address(RVA = "0x4ACB9CC", Offset = "0x4ACB9CC", VA = "0x104ACB9CC")]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x602905E")]
	[Address(RVA = "0x4ACB46C", Offset = "0x4ACB46C", VA = "0x104ACB46C")]
	public OverlayColorData()
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x602905F")]
	[Address(RVA = "0x4ACB4DC", Offset = "0x4ACB4DC", VA = "0x104ACB4DC")]
	public OverlayColorData(int channels)
	{
	}

	[Token(Token = "0x6029062")]
	[Address(RVA = "0x4ACB564", Offset = "0x4ACB564", VA = "0x104ACB564")]
	public void Reset(int channels)
	{
	}

	[Token(Token = "0x6029063")]
	[Address(RVA = "0x4ACB7C4", Offset = "0x4ACB7C4", VA = "0x104ACB7C4")]
	public OverlayColorData Duplicate()
	{
		return null;
	}

	[Token(Token = "0x6029065")]
	[Address(RVA = "0x4ACBA70", Offset = "0x4ACBA70", VA = "0x104ACBA70")]
	public bool HasName()
	{
		return default(bool);
	}

	[Token(Token = "0x6029066")]
	[Address(RVA = "0x4ACBA98", Offset = "0x4ACBA98", VA = "0x104ACBA98")]
	public static bool SameColor(Color color1, Color color2)
	{
		return default(bool);
	}

	[Token(Token = "0x6029067")]
	[Address(RVA = "0x4ACBBE4", Offset = "0x4ACBBE4", VA = "0x104ACBBE4")]
	public static bool DifferentColor(Color color1, Color color2)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029068")]
	[Address(RVA = "0x4ACBD20", Offset = "0x4ACBD20", VA = "0x104ACBD20")]
	public static implicit operator bool(OverlayColorData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029069")]
	[Address(RVA = "0x4ACBD2C", Offset = "0x4ACBD2C", VA = "0x104ACBD2C", Slot = "4")]
	public bool Equals(OverlayColorData other)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x602906A")]
	[Address(RVA = "0x4ACBF30", Offset = "0x4ACBF30", VA = "0x104ACBF30", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602906B")]
	[Address(RVA = "0x4ACBD30", Offset = "0x4ACBD30", VA = "0x104ACBD30")]
	public static bool operator ==(OverlayColorData cd1, OverlayColorData cd2)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602906C")]
	[Address(RVA = "0x4ACBFC0", Offset = "0x4ACBFC0", VA = "0x104ACBFC0")]
	public static bool operator !=(OverlayColorData cd1, OverlayColorData cd2)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x602906D")]
	[Address(RVA = "0x4ACC1BC", Offset = "0x4ACC1BC", VA = "0x104ACC1BC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x602906E")]
	[Address(RVA = "0x4ACC1C4", Offset = "0x4ACC1C4", VA = "0x104ACC1C4")]
	public int GetChannels()
	{
		return default(int);
	}

	[Token(Token = "0x602906F")]
	[Address(RVA = "0x4ACC1DC", Offset = "0x4ACC1DC", VA = "0x104ACC1DC")]
	public void EnsureChannels(int channels)
	{
	}

	[Token(Token = "0x6029070")]
	[Address(RVA = "0x4ACC4FC", Offset = "0x4ACC4FC", VA = "0x104ACC4FC")]
	public void AssignTo(OverlayColorData dest)
	{
	}

	[Token(Token = "0x6029071")]
	[Address(RVA = "0x4ACC730", Offset = "0x4ACC730", VA = "0x104ACC730")]
	public void AssignFrom(OverlayColorData src)
	{
	}
}
