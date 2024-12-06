using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2006128")]
public class UMASkeleton
{
	[Serializable]
	[Token(Token = "0x2006129")]
	public class BoneData
	{
		[Token(Token = "0x402D9E7")]
		[FieldOffset(Offset = "0x10")]
		public int boneNameHash;

		[Token(Token = "0x402D9E8")]
		[FieldOffset(Offset = "0x14")]
		public int parentBoneNameHash;

		[Token(Token = "0x402D9E9")]
		[FieldOffset(Offset = "0x18")]
		public Transform boneTransform;

		[Token(Token = "0x402D9EA")]
		[FieldOffset(Offset = "0x20")]
		public UMATransform umaTransform;

		[Token(Token = "0x402D9EB")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion rotation;

		[Token(Token = "0x402D9EC")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 position;

		[Token(Token = "0x402D9ED")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 scale;

		[Token(Token = "0x402D9EE")]
		[FieldOffset(Offset = "0x50")]
		public int accessedFrame;

		[MethodImpl(768)]
		[Token(Token = "0x60292A6")]
		[Address(RVA = "0x4B12134", Offset = "0x4B12134", VA = "0x104B12134")]
		public BoneData()
		{
		}
	}

	[Token(Token = "0x402D9E2")]
	[FieldOffset(Offset = "0x10")]
	protected bool updating;

	[Token(Token = "0x402D9E3")]
	[FieldOffset(Offset = "0x14")]
	protected int frame;

	[Token(Token = "0x402D9E4")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2D3610", Offset = "0x2D3610")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2D3610", Offset = "0x2D3610")]
	private int _003CrootBoneHash_003Ek__BackingField;

	[Token(Token = "0x402D9E5")]
	[FieldOffset(Offset = "0x20")]
	private List<BoneData> boneHashDataBackup;

	[Token(Token = "0x402D9E6")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, BoneData> boneHashDataLookup;

	[Token(Token = "0x17002995")]
	public int rootBoneHash
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029290")]
		[Address(RVA = "0x4B11F08", Offset = "0x4B11F08", VA = "0x104B11F08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3188B8", Offset = "0x3188B8")]
		get
		{
			return default(int);
		}
		[MethodImpl(512)]
		[Token(Token = "0x6029291")]
		[Address(RVA = "0x4B11BC0", Offset = "0x4B11BC0", VA = "0x104B11BC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3188C8", Offset = "0x3188C8")]
		protected set
		{
		}
	}

	[Token(Token = "0x17002996")]
	public virtual int boneCount
	{
		[MethodImpl(768)]
		[Token(Token = "0x6029292")]
		[Address(RVA = "0x4B11F10", Offset = "0x4B11F10", VA = "0x104B11F10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17002997")]
	private Dictionary<int, BoneData> boneHashData
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029293")]
		[Address(RVA = "0x4B11F74", Offset = "0x4B11F74", VA = "0x104B11F74")]
		get
		{
			return null;
		}
		[MethodImpl(512)]
		[Token(Token = "0x6029294")]
		[Address(RVA = "0x4B11BC8", Offset = "0x4B11BC8", VA = "0x104B11BC8")]
		set
		{
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x602928E")]
	[Address(RVA = "0x4B11A94", Offset = "0x4B11A94", VA = "0x104B11A94")]
	public UMASkeleton(Transform rootBone)
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x602928F")]
	[Address(RVA = "0x4B11E98", Offset = "0x4B11E98", VA = "0x104B11E98")]
	protected UMASkeleton()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029295")]
	[Address(RVA = "0x4B1210C", Offset = "0x4B1210C", VA = "0x104B1210C", Slot = "5")]
	public virtual void BeginSkeletonUpdate()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029296")]
	[Address(RVA = "0x4B1212C", Offset = "0x4B1212C", VA = "0x104B1212C", Slot = "6")]
	public virtual void EndSkeletonUpdate()
	{
	}

	[Token(Token = "0x6029297")]
	[Address(RVA = "0x4B11C68", Offset = "0x4B11C68", VA = "0x104B11C68")]
	private void AddBonesRecursive(Transform transform)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029298")]
	[Address(RVA = "0x4B1221C", Offset = "0x4B1221C", VA = "0x104B1221C", Slot = "7")]
	public virtual bool HasBone(int nameHash)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029299")]
	[Address(RVA = "0x4B12290", Offset = "0x4B12290", VA = "0x104B12290", Slot = "8")]
	public virtual void AddBone(UMATransform transform)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929A")]
	[Address(RVA = "0x4B12474", Offset = "0x4B12474", VA = "0x104B12474", Slot = "9")]
	public virtual Transform GetBoneTransform(int nameHash)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929B")]
	[Address(RVA = "0x4B1253C", Offset = "0x4B1253C", VA = "0x104B1253C", Slot = "10")]
	public virtual GameObject GetBoneGameObject(int nameHash)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929C")]
	[Address(RVA = "0x4B1261C", Offset = "0x4B1261C", VA = "0x104B1261C", Slot = "11")]
	public virtual void SetPosition(int nameHash, Vector3 position)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929D")]
	[Address(RVA = "0x4B1271C", Offset = "0x4B1271C", VA = "0x104B1271C", Slot = "12")]
	public virtual void SetScale(int nameHash, Vector3 scale)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929E")]
	[Address(RVA = "0x4B1281C", Offset = "0x4B1281C", VA = "0x104B1281C", Slot = "13")]
	public virtual void SetRotation(int nameHash, Quaternion rotation)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602929F")]
	[Address(RVA = "0x4B12924", Offset = "0x4B12924", VA = "0x104B12924", Slot = "14")]
	public virtual void ResetAll()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292A0")]
	[Address(RVA = "0x4B12BA0", Offset = "0x4B12BA0", VA = "0x104B12BA0", Slot = "15")]
	public virtual void ResetScales()
	{
	}

	[Token(Token = "0x60292A1")]
	[Address(RVA = "0x4B12D88", Offset = "0x4B12D88", VA = "0x104B12D88")]
	public static int StringToHash(string name)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292A2")]
	[Address(RVA = "0x4B12D90", Offset = "0x4B12D90", VA = "0x104B12D90", Slot = "16")]
	public virtual Transform[] HashesToTransforms(int[] boneNameHashes)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292A3")]
	[Address(RVA = "0x4B12EF8", Offset = "0x4B12EF8", VA = "0x104B12EF8", Slot = "17")]
	public virtual Transform[] HashesToTransforms(List<int> boneNameHashes)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292A4")]
	[Address(RVA = "0x4B13080", Offset = "0x4B13080", VA = "0x104B13080", Slot = "18")]
	public virtual void EnsureBone(UMATransform umaTransform)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292A5")]
	[Address(RVA = "0x4B13238", Offset = "0x4B13238", VA = "0x104B13238", Slot = "19")]
	public virtual void EnsureBoneHierarchy()
	{
	}
}
