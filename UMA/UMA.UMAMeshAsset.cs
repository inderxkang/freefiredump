// Assembly-CSharp, Version=0.86.0.518, Culture=neutral, PublicKeyToken=null
// UMA.UMAMeshAsset
using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Serializable]
[Token(Token = "0x2006117")]
public class UMAMeshAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	[Token(Token = "0x402D991")]
	[FieldOffset(Offset = "0x18")]
	public string meshName;

	[NonSerialized]
	[Token(Token = "0x402D992")]
	[FieldOffset(Offset = "0x20")]
	public int nameHash;

	[Token(Token = "0x402D993")]
	[FieldOffset(Offset = "0x28")]
	public string[] animatedBoneNames;

	[Token(Token = "0x402D994")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public int[] animatedBoneHashes;

	[Token(Token = "0x402D995")]
	[FieldOffset(Offset = "0x38")]
	public UMAMeshData meshData;

	[Token(Token = "0x402D996")]
	[FieldOffset(Offset = "0x40")]
	public string slotGroup;

	[MethodImpl(768)]
	[Token(Token = "0x6029223")]
	[Address(RVA = "0x4B0C684", Offset = "0x4B0C684", VA = "0x104B0C684")]
	public UMAMeshAsset()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029224")]
	[Address(RVA = "0x4B0C6FC", Offset = "0x4B0C6FC", VA = "0x104B0C6FC", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029225")]
	[Address(RVA = "0x4B0C704", Offset = "0x4B0C704", VA = "0x104B0C704", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x6029226")]
	[Address(RVA = "0x4B0C70C", Offset = "0x4B0C70C", VA = "0x104B0C70C")]
	public void Release()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029227")]
	[Address(RVA = "0x4B0C714", Offset = "0x4B0C714", VA = "0x104B0C714", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6029228")]
	[Address(RVA = "0x4B0C78C", Offset = "0x4B0C78C", VA = "0x104B0C78C")]
	public static bool GetMaleInfoByName(string assetName, ref bool isMale)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029229")]
	[Address(RVA = "0x4B0C924", Offset = "0x4B0C924", VA = "0x104B0C924", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602922A")]
	[Address(RVA = "0x4B0C958", Offset = "0x4B0C958", VA = "0x104B0C958", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x602922B")]
	[Address(RVA = "0x4B0C95C", Offset = "0x4B0C95C", VA = "0x104B0C95C")]
	public void Assign(UMAMeshAsset source)
	{
	}
}
