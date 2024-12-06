using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060E0")]
public class OverlayData : IEquatable<OverlayData>
{
	[Token(Token = "0x402D7D5")]
	[FieldOffset(Offset = "0x10")]
	public OverlayDataAsset asset;

	[Token(Token = "0x402D7D6")]
	[FieldOffset(Offset = "0x18")]
	public Rect rect;

	[NonSerialized]
	[Token(Token = "0x402D7D7")]
	[FieldOffset(Offset = "0x28")]
	public OverlayColorData colorData;

	[NonSerialized]
	[Token(Token = "0x402D7D8")]
	[FieldOffset(Offset = "0x30")]
	public byte additiveOrder;

	[NonSerialized]
	[Token(Token = "0x402D7D9")]
	[FieldOffset(Offset = "0x34")]
	public int refCount;

	[Token(Token = "0x17002982")]
	public string overlayName
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029074")]
		[Address(RVA = "0x4ACCDA4", Offset = "0x4ACCDA4", VA = "0x104ACCDA4")]
		get
		{
			return null;
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029072")]
	[Address(RVA = "0x4ACC91C", Offset = "0x4ACC91C", VA = "0x104ACC91C")]
	public OverlayData()
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029073")]
	[Address(RVA = "0x4ACC924", Offset = "0x4ACC924", VA = "0x104ACC924")]
	public OverlayData(OverlayDataAsset asset)
	{
	}

	[Token(Token = "0x6029075")]
	[Address(RVA = "0x4ACCDD0", Offset = "0x4ACCDD0", VA = "0x104ACCDD0")]
	public OverlayData Duplicate()
	{
		return null;
	}

	[Token(Token = "0x6029076")]
	[Address(RVA = "0x4ACC954", Offset = "0x4ACC954", VA = "0x104ACC954")]
	public void SetAsset(OverlayDataAsset asset)
	{
	}

	[Token(Token = "0x6029077")]
	[Address(RVA = "0x4ACCEA0", Offset = "0x4ACCEA0", VA = "0x104ACCEA0")]
	private void CreateOrResetColorData(int channels)
	{
	}

	[Token(Token = "0x6029078")]
	[Address(RVA = "0x4ACD014", Offset = "0x4ACD014", VA = "0x104ACD014")]
	public void Reset()
	{
	}

	[Token(Token = "0x6029079")]
	[Address(RVA = "0x4ACCF50", Offset = "0x4ACCF50", VA = "0x104ACCF50")]
	public void InitMaskColor(OverlayColorData colorData)
	{
	}

	[Token(Token = "0x602907A")]
	[Address(RVA = "0x4ACD070", Offset = "0x4ACD070", VA = "0x104ACD070")]
	public void CopyColors(OverlayData overlay)
	{
	}

	[Token(Token = "0x602907B")]
	[Address(RVA = "0x4ACD0BC", Offset = "0x4ACD0BC", VA = "0x104ACD0BC")]
	public void EnsureChannels(int channels, bool createNewColor)
	{
	}

	[Token(Token = "0x602907C")]
	[Address(RVA = "0x4ACD148", Offset = "0x4ACD148", VA = "0x104ACD148")]
	public static bool Equivalent(OverlayData overlay1, OverlayData overlay2)
	{
		return default(bool);
	}

	[Token(Token = "0x602907D")]
	[Address(RVA = "0x4ACD2C4", Offset = "0x4ACD2C4", VA = "0x104ACD2C4")]
	public static bool EquivalentAssetAndUse(OverlayData overlay1, OverlayData overlay2)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602907E")]
	[Address(RVA = "0x4ACD240", Offset = "0x4ACD240", VA = "0x104ACD240")]
	public static implicit operator bool(OverlayData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x602907F")]
	[Address(RVA = "0x4ACD4B4", Offset = "0x4ACD4B4", VA = "0x104ACD4B4", Slot = "4")]
	public bool Equals(OverlayData other)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029080")]
	[Address(RVA = "0x4ACD508", Offset = "0x4ACD508", VA = "0x104ACD508", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029081")]
	[Address(RVA = "0x4ACD4B8", Offset = "0x4ACD4B8", VA = "0x104ACD4B8")]
	public static bool operator ==(OverlayData overlay, OverlayData obj)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029082")]
	[Address(RVA = "0x4ACD598", Offset = "0x4ACD598", VA = "0x104ACD598")]
	public static bool operator !=(OverlayData overlay, OverlayData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029083")]
	[Address(RVA = "0x4ACD5E8", Offset = "0x4ACD5E8", VA = "0x104ACD5E8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
