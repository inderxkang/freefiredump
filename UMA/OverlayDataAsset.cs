using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060E1")]
public class OverlayDataAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	[Token(Token = "0x20060E2")]
	public enum OverlayType
	{
		[Token(Token = "0x402D7E2")]
		Normal,
		[Token(Token = "0x402D7E3")]
		Cutout,
		[Token(Token = "0x402D7E4")]
		Additive
	}

	[Token(Token = "0x402D7DA")]
	[FieldOffset(Offset = "0x18")]
	public string overlayName;

	[NonSerialized]
	[Token(Token = "0x402D7DB")]
	[FieldOffset(Offset = "0x20")]
	public int nameHash;

	[Token(Token = "0x402D7DC")]
	[FieldOffset(Offset = "0x24")]
	public OverlayType overlayType;

	[Token(Token = "0x402D7DD")]
	[FieldOffset(Offset = "0x28")]
	public Rect rect;

	[Token(Token = "0x402D7DE")]
	[FieldOffset(Offset = "0x38")]
	public Texture alphaMask;

	[Token(Token = "0x402D7DF")]
	[FieldOffset(Offset = "0x40")]
	public Texture[] textureList;

	[Token(Token = "0x402D7E0")]
	[FieldOffset(Offset = "0x48")]
	[UMAAssetFieldVisible]
	public UMAMaterial material;

	[MethodImpl(768)]
	[Token(Token = "0x6029084")]
	[Address(RVA = "0x4ACD5F0", Offset = "0x4ACD5F0", VA = "0x104ACD5F0")]
	public OverlayDataAsset()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029085")]
	[Address(RVA = "0x4ACD5F8", Offset = "0x4ACD5F8", VA = "0x104ACD5F8", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029086")]
	[Address(RVA = "0x4ACD600", Offset = "0x4ACD600", VA = "0x104ACD600", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029087")]
	[Address(RVA = "0x4ACD608", Offset = "0x4ACD608", VA = "0x104ACD608", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029088")]
	[Address(RVA = "0x4ACD634", Offset = "0x4ACD634", VA = "0x104ACD634", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6029089")]
	[Address(RVA = "0x4ACD638", Offset = "0x4ACD638", VA = "0x104ACD638")]
	public Texture GetAlphaMask()
	{
		return null;
	}
}
