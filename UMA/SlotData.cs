using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060EC")]
public class SlotData : IEquatable<SlotData>, ISerializationCallbackReceiver
{
	[Token(Token = "0x402D804")]
	[FieldOffset(Offset = "0x10")]
	public SlotDataAsset asset;

	[Token(Token = "0x402D805")]
	[FieldOffset(Offset = "0x18")]
	public float overlayScale;

	[Token(Token = "0x402D806")]
	[FieldOffset(Offset = "0x1C")]
	public int overlayLimitSize;

	[Token(Token = "0x402D807")]
	[FieldOffset(Offset = "0x20")]
	public bool dontSerialize;

	[Token(Token = "0x402D808")]
	[FieldOffset(Offset = "0x28")]
	private List<OverlayData> overlayList;

	[Token(Token = "0x402D809")]
	[FieldOffset(Offset = "0x30")]
	private List<OverlayData> individualOverlayList;

	[NonSerialized]
	[Token(Token = "0x402D80A")]
	[FieldOffset(Offset = "0x38")]
	public UMAMaterial overrideMaterial;

	[Token(Token = "0x17002985")]
	public string slotName
	{
		[MethodImpl(512)]
		[Token(Token = "0x60290C6")]
		[Address(RVA = "0x4AEFB70", Offset = "0x4AEFB70", VA = "0x104AEFB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17002986")]
	public int OverlayCount
	{
		[MethodImpl(512)]
		[Token(Token = "0x60290CC")]
		[Address(RVA = "0x4AEFF88", Offset = "0x4AEFF88", VA = "0x104AEFF88")]
		get
		{
			return default(int);
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x60290C4")]
	[Address(RVA = "0x4AEFA0C", Offset = "0x4AEFA0C", VA = "0x104AEFA0C")]
	public SlotData(SlotDataAsset asset)
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x60290C5")]
	[Address(RVA = "0x4AEFAEC", Offset = "0x4AEFAEC", VA = "0x104AEFAEC")]
	public SlotData()
	{
	}

	[Token(Token = "0x60290C7")]
	[Address(RVA = "0x4AEFAB4", Offset = "0x4AEFAB4", VA = "0x104AEFAB4")]
	public void SetAsset(SlotDataAsset asset)
	{
	}

	[Token(Token = "0x60290C8")]
	[Address(RVA = "0x4AEFB9C", Offset = "0x4AEFB9C", VA = "0x104AEFB9C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60290C9")]
	[Address(RVA = "0x4AEFC14", Offset = "0x4AEFC14", VA = "0x104AEFC14")]
	public SlotData Copy()
	{
		return null;
	}

	[Token(Token = "0x60290CA")]
	[Address(RVA = "0x4AEFD9C", Offset = "0x4AEFD9C", VA = "0x104AEFD9C")]
	public OverlayData GetOverlay(int index)
	{
		return null;
	}

	[Token(Token = "0x60290CB")]
	[Address(RVA = "0x4AEFE50", Offset = "0x4AEFE50", VA = "0x104AEFE50")]
	public OverlayData GetEquivalentUsedOverlay(OverlayData overlay)
	{
		return null;
	}

	[Token(Token = "0x60290CD")]
	[Address(RVA = "0x4AEFFE8", Offset = "0x4AEFFE8", VA = "0x104AEFFE8")]
	public void SetOverlayList(List<OverlayData> overlayList)
	{
	}

	[Token(Token = "0x60290CE")]
	[Address(RVA = "0x4AF0080", Offset = "0x4AF0080", VA = "0x104AF0080")]
	private void CopyOverlayList(List<OverlayData> src)
	{
	}

	[Token(Token = "0x60290CF")]
	[Address(RVA = "0x4AF036C", Offset = "0x4AF036C", VA = "0x104AF036C")]
	public void AddOverlay(OverlayData overlayData)
	{
	}

	[Token(Token = "0x60290D0")]
	[Address(RVA = "0x4AF0450", Offset = "0x4AF0450", VA = "0x104AF0450")]
	public List<OverlayData> GetOverlayList()
	{
		return null;
	}

	[Token(Token = "0x60290D1")]
	[Address(RVA = "0x4AF0458", Offset = "0x4AF0458", VA = "0x104AF0458")]
	public List<OverlayData> GetSharedOverlayList()
	{
		return null;
	}

	[Token(Token = "0x60290D2")]
	[Address(RVA = "0x4AF0530", Offset = "0x4AF0530", VA = "0x104AF0530")]
	internal bool Validate()
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290D3")]
	[Address(RVA = "0x4AF0AF0", Offset = "0x4AF0AF0", VA = "0x104AF0AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(512)]
	[Token(Token = "0x60290D4")]
	[Address(RVA = "0x4AF0B78", Offset = "0x4AF0B78", VA = "0x104AF0B78")]
	public static implicit operator bool(SlotData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290D5")]
	[Address(RVA = "0x4AF0BFC", Offset = "0x4AF0BFC", VA = "0x104AF0BFC", Slot = "4")]
	public bool Equals(SlotData other)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290D6")]
	[Address(RVA = "0x4AF0C50", Offset = "0x4AF0C50", VA = "0x104AF0C50", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x60290D7")]
	[Address(RVA = "0x4AF0C00", Offset = "0x4AF0C00", VA = "0x104AF0C00")]
	public static bool operator ==(SlotData slot, SlotData obj)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x60290D8")]
	[Address(RVA = "0x4AF0CE0", Offset = "0x4AF0CE0", VA = "0x104AF0CE0")]
	public static bool operator !=(SlotData slot, SlotData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290D9")]
	[Address(RVA = "0x4AF0D30", Offset = "0x4AF0D30", VA = "0x104AF0D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290DA")]
	[Address(RVA = "0x4AF0D38", Offset = "0x4AF0D38", VA = "0x104AF0D38", Slot = "6")]
	public void OnAfterDeserialize()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290DB")]
	[Address(RVA = "0x4AF0DA8", Offset = "0x4AF0DA8", VA = "0x104AF0DA8", Slot = "5")]
	public void OnBeforeSerialize()
	{
	}
}
