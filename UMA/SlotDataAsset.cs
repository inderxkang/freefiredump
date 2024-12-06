using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060ED")]
public class SlotDataAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	[Token(Token = "0x402D80B")]
	[FieldOffset(Offset = "0x18")]
	public string slotName;

	[NonSerialized]
	[Token(Token = "0x402D80C")]
	[FieldOffset(Offset = "0x20")]
	public int nameHash;

	[Token(Token = "0x402D80D")]
	[FieldOffset(Offset = "0x28")]
	[UMAAssetFieldVisible]
	public UMAMaterial material;

	[Token(Token = "0x402D80E")]
	[FieldOffset(Offset = "0x30")]
	public float overlayScale;

	[Token(Token = "0x402D80F")]
	[FieldOffset(Offset = "0x38")]
	public string[] animatedBoneNames;

	[Token(Token = "0x402D810")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public int[] animatedBoneHashes;

	[Token(Token = "0x402D811")]
	[FieldOffset(Offset = "0x48")]
	public UMAMeshAsset meshAsset;

	[Token(Token = "0x402D812")]
	[FieldOffset(Offset = "0x50")]
	public int subMeshIndex;

	[Token(Token = "0x402D813")]
	[FieldOffset(Offset = "0x58")]
	public string slotGroup;

	[Token(Token = "0x402D814")]
	[FieldOffset(Offset = "0x60")]
	public string[] dynamicBoneRoots;

	[Token(Token = "0x402D815")]
	[FieldOffset(Offset = "0x68")]
	public UMADynamicBoneProperties[] dynamicBones;

	[Token(Token = "0x402D816")]
	[FieldOffset(Offset = "0x70")]
	public UMADynamicBoneColliderProperties[] dynamicBoneColliders;

	[Token(Token = "0x402D817")]
	[FieldOffset(Offset = "0x78")]
	public List<HangStringProperty> fluxAssets;

	[Token(Token = "0x402D818")]
	[FieldOffset(Offset = "0x80")]
	public OverlayDataAsset overlayAsset;

	[MethodImpl(768)]
	[Token(Token = "0x60290DC")]
	[Address(RVA = "0x4AF0DAC", Offset = "0x4AF0DAC", VA = "0x104AF0DAC")]
	public SlotDataAsset()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290DD")]
	[Address(RVA = "0x4AF0E2C", Offset = "0x4AF0E2C", VA = "0x104AF0E2C", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290DE")]
	[Address(RVA = "0x4AF0E34", Offset = "0x4AF0E34", VA = "0x104AF0E34", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290DF")]
	[Address(RVA = "0x4AF0E3C", Offset = "0x4AF0E3C", VA = "0x104AF0E3C", Slot = "8")]
	public virtual AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}

	[Token(Token = "0x60290E0")]
	[Address(RVA = "0x4AF0E44", Offset = "0x4AF0E44", VA = "0x104AF0E44")]
	public bool ValidateDynamicBones()
	{
		return default(bool);
	}

	[Token(Token = "0x60290E1")]
	[Address(RVA = "0x4AF0A5C", Offset = "0x4AF0A5C", VA = "0x104AF0A5C")]
	public UMAMeshData GetMeshData()
	{
		return null;
	}

	[Token(Token = "0x60290E2")]
	[Address(RVA = "0x4AF0F28", Offset = "0x4AF0F28", VA = "0x104AF0F28")]
	public int GetTextureChannelCount(UMAGeneratorBase generator)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290E3")]
	[Address(RVA = "0x4AF0F64", Offset = "0x4AF0F64", VA = "0x104AF0F64", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60290E4")]
	[Address(RVA = "0x4AF0FDC", Offset = "0x4AF0FDC", VA = "0x104AF0FDC")]
	public void UpdateMeshAsset(UMAMeshAsset mas)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290E5")]
	[Address(RVA = "0x4AF0FE4", Offset = "0x4AF0FE4", VA = "0x104AF0FE4", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60290E6")]
	[Address(RVA = "0x4AF1010", Offset = "0x4AF1010", VA = "0x104AF1010", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}
}
