using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2006121")]
public class UMAMeshData
{
	[Token(Token = "0x402D9A7")]
	[FieldOffset(Offset = "0x10")]
	public Matrix4x4[] bindPoses;

	[Token(Token = "0x402D9A8")]
	[FieldOffset(Offset = "0x18")]
	public UMABoneWeight[] boneWeights;

	[Token(Token = "0x402D9A9")]
	[FieldOffset(Offset = "0x20")]
	public BoneWeight[] unityBoneWeights;

	[Token(Token = "0x402D9AA")]
	[FieldOffset(Offset = "0x28")]
	public Vector3[] vertices;

	[Token(Token = "0x402D9AB")]
	[FieldOffset(Offset = "0x30")]
	public Vector4[] tangents;

	[Token(Token = "0x402D9AC")]
	[FieldOffset(Offset = "0x38")]
	public Vector3[] normals;

	[Token(Token = "0x402D9AD")]
	[FieldOffset(Offset = "0x40")]
	public Color32[] colors32;

	[Token(Token = "0x402D9AE")]
	[FieldOffset(Offset = "0x48")]
	public Vector2[] uv;

	[Token(Token = "0x402D9AF")]
	[FieldOffset(Offset = "0x50")]
	public Vector2[] uv2;

	[Token(Token = "0x402D9B0")]
	[FieldOffset(Offset = "0x58")]
	public Vector2[] uv3;

	[Token(Token = "0x402D9B1")]
	[FieldOffset(Offset = "0x60")]
	public Vector2[] uv4;

	[Token(Token = "0x402D9B2")]
	[FieldOffset(Offset = "0x68")]
	public UMABlendShape[] blendShapes;

	[Token(Token = "0x402D9B3")]
	[FieldOffset(Offset = "0x70")]
	public SubMeshTriangles[] submeshes;

	[NonSerialized]
	[Token(Token = "0x402D9B4")]
	[FieldOffset(Offset = "0x78")]
	public Transform[] bones;

	[NonSerialized]
	[Token(Token = "0x402D9B5")]
	[FieldOffset(Offset = "0x80")]
	public Transform rootBone;

	[Token(Token = "0x402D9B6")]
	[FieldOffset(Offset = "0x88")]
	public UMATransform[] umaBones;

	[Token(Token = "0x402D9B7")]
	[FieldOffset(Offset = "0x90")]
	public int umaBoneCount;

	[Token(Token = "0x402D9B8")]
	[FieldOffset(Offset = "0x94")]
	public int rootBoneHash;

	[Token(Token = "0x402D9B9")]
	[FieldOffset(Offset = "0x98")]
	public int[] boneNameHashes;

	[Token(Token = "0x402D9BA")]
	[FieldOffset(Offset = "0xA0")]
	public int subMeshCount;

	[Token(Token = "0x402D9BB")]
	[FieldOffset(Offset = "0xA4")]
	public int vertexCount;

	[Token(Token = "0x402D9BC")]
	[FieldOffset(Offset = "0xA8")]
	public string RootBoneName;

	[Token(Token = "0x402D9BD")]
	[FieldOffset(Offset = "0xB0")]
	public bool optimized;

	[Token(Token = "0x402D9BE")]
	[FieldOffset(Offset = "0xB8")]
	public uint[] optimizeduv;

	[Token(Token = "0x402D9BF")]
	[FieldOffset(Offset = "0xC0")]
	public OptimizedBoneWeight[] optimizedBoneWeights;

	[Token(Token = "0x402D9C0")]
	[FieldOffset(Offset = "0xC8")]
	public OptimizedBoneWeightV2[] optimizedBoneWeightsV2;

	[Token(Token = "0x402D9C1")]
	[FieldOffset(Offset = "0xD0")]
	public uint[] optimizedTangents;

	[Token(Token = "0x402D9C2")]
	[FieldOffset(Offset = "0xD8")]
	public uint[] optimizedNormals;

	[Token(Token = "0x402D9C3")]
	[FieldOffset(Offset = "0xE0")]
	public uint[] optimizeduv2;

	[Token(Token = "0x402D9C4")]
	[FieldOffset(Offset = "0xE8")]
	public byte[] optimizedVertArray;

	[Token(Token = "0x402D9C5")]
	[FieldOffset(Offset = "0xF0")]
	public byte[] optimizedNormalArray;

	[Token(Token = "0x402D9C6")]
	[FieldOffset(Offset = "0xF8")]
	public byte[] optimizedUVArray;

	[Token(Token = "0x402D9C7")]
	[FieldOffset(Offset = "0x100")]
	public byte[] optimizedBoneWeightArray;

	[Token(Token = "0x402D9C8")]
	[FieldOffset(Offset = "0x108")]
	public SubMeshTrianglesNew[] optimizedSubMeshArray;

	[NonSerialized]
	[Token(Token = "0x402D9C9")]
	public const int EXTRA_BONE_INDEX = 46;

	[NonSerialized]
	[Token(Token = "0x402D9CA")]
	[FieldOffset(Offset = "0x110")]
	private Dictionary<int, int> BoneNameHashDict;

	[NonSerialized]
	[Token(Token = "0x402D9CB")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<int, Matrix4x4> BindPoseDict;

	[NonSerialized]
	[Token(Token = "0x402D9CC")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<int, UMATransform> BonesDict;

	[Token(Token = "0x402D9CD")]
	[FieldOffset(Offset = "0x128")]
	public Matrix4x4[] extraBindPoses;

	[Token(Token = "0x402D9CE")]
	[FieldOffset(Offset = "0x130")]
	public int[] extraBoneNameHashes;

	[Token(Token = "0x402D9CF")]
	[FieldOffset(Offset = "0x138")]
	public UMATransform[] extraBones;

	[Token(Token = "0x402D9D0")]
	[FieldOffset(Offset = "0x140")]
	public bool isMale;

	[MethodImpl(768)]
	[Token(Token = "0x6029248")]
	[Address(RVA = "0x4B0C9BC", Offset = "0x4B0C9BC", VA = "0x104B0C9BC")]
	public UMAMeshData()
	{
	}

	[Token(Token = "0x6029249")]
	[Address(RVA = "0x4B0CA14", Offset = "0x4B0CA14", VA = "0x104B0CA14")]
	public Dictionary<int, UMATransform> GetBonesDict()
	{
		return null;
	}

	[Token(Token = "0x602924A")]
	[Address(RVA = "0x4B0CB68", Offset = "0x4B0CB68", VA = "0x104B0CB68")]
	public bool UseShareBones()
	{
		return default(bool);
	}

	[Token(Token = "0x602924B")]
	[Address(RVA = "0x4B0CB8C", Offset = "0x4B0CB8C", VA = "0x104B0CB8C")]
	public int[] GetBoneHashs()
	{
		return null;
	}

	[Token(Token = "0x602924C")]
	[Address(RVA = "0x4B0CBB8", Offset = "0x4B0CBB8", VA = "0x104B0CBB8")]
	public Matrix4x4[] GetBonePoses()
	{
		return null;
	}

	[Token(Token = "0x602924D")]
	[Address(RVA = "0x4B0CBE4", Offset = "0x4B0CBE4", VA = "0x104B0CBE4")]
	public UMATransform[] GetUMABones()
	{
		return null;
	}

	[Token(Token = "0x602924E")]
	[Address(RVA = "0x4B0CC08", Offset = "0x4B0CC08", VA = "0x104B0CC08")]
	public void PrepareVertexBuffers(int size)
	{
	}

	[Token(Token = "0x602924F")]
	[Address(RVA = "0x4B0CD5C", Offset = "0x4B0CD5C", VA = "0x104B0CD5C")]
	private static Transform RecursiveFindBone(Transform bone, string raceRoot)
	{
		return null;
	}

	[Token(Token = "0x6029250")]
	[Address(RVA = "0x4B0CEAC", Offset = "0x4B0CEAC", VA = "0x104B0CEAC")]
	private Transform FindRoot(Transform rootBone, Transform[] bones)
	{
		return null;
	}

	[Token(Token = "0x6029251")]
	[Address(RVA = "0x4B0D048", Offset = "0x4B0D048", VA = "0x104B0D048")]
	private BoneWeight[] GetBoneWeights()
	{
		return null;
	}

	[Token(Token = "0x6029252")]
	[Address(RVA = "0x4B0D0B0", Offset = "0x4B0D0B0", VA = "0x104B0D0B0")]
	public Vector3[] GetNormals()
	{
		return null;
	}

	[Token(Token = "0x6029253")]
	[Address(RVA = "0x4B0D0F4", Offset = "0x4B0D0F4", VA = "0x104B0D0F4")]
	public Vector3[] GetVertices()
	{
		return null;
	}

	[Token(Token = "0x6029254")]
	[Address(RVA = "0x4B0D0FC", Offset = "0x4B0D0FC", VA = "0x104B0D0FC")]
	public Vector3[] GetVerticesNewAlloc()
	{
		return null;
	}

	[Token(Token = "0x6029255")]
	[Address(RVA = "0x4B0D418", Offset = "0x4B0D418", VA = "0x104B0D418")]
	public void GetVerticesNew(ref Vector3[] dest, int destIndex)
	{
	}

	[Token(Token = "0x6029256")]
	[Address(RVA = "0x4B0D700", Offset = "0x4B0D700", VA = "0x104B0D700")]
	public void GetVerticesNew(List<Vector3> dest, int destIndex)
	{
	}

	[Token(Token = "0x6029257")]
	[Address(RVA = "0x4B0DA84", Offset = "0x4B0DA84", VA = "0x104B0DA84")]
	public Vector3[] GetNormalNew()
	{
		return null;
	}

	[Token(Token = "0x6029258")]
	[Address(RVA = "0x4B0DCC0", Offset = "0x4B0DCC0", VA = "0x104B0DCC0")]
	public void GetNormalNew(List<Vector3> dest)
	{
	}

	[Token(Token = "0x6029259")]
	[Address(RVA = "0x4B0E08C", Offset = "0x4B0E08C", VA = "0x104B0E08C")]
	public Vector2[] GetUVNew()
	{
		return null;
	}

	[Token(Token = "0x602925A")]
	[Address(RVA = "0x4B0E2BC", Offset = "0x4B0E2BC", VA = "0x104B0E2BC")]
	public void GetUVNew(List<Vector2> dest)
	{
	}

	[Token(Token = "0x602925B")]
	[Address(RVA = "0x4B0E668", Offset = "0x4B0E668", VA = "0x104B0E668")]
	public Vector2[] GetUV2New()
	{
		return null;
	}

	[Token(Token = "0x602925C")]
	[Address(RVA = "0x4B0E6E8", Offset = "0x4B0E6E8", VA = "0x104B0E6E8")]
	public void GetUV2New(List<Vector2> dest)
	{
	}

	[Token(Token = "0x602925D")]
	[Address(RVA = "0x4B0E934", Offset = "0x4B0E934", VA = "0x104B0E934")]
	public BoneWeight[] GetBoneWeightNew()
	{
		return null;
	}

	[Token(Token = "0x602925E")]
	[Address(RVA = "0x4B0ED50", Offset = "0x4B0ED50", VA = "0x104B0ED50")]
	public SubMeshTriangles[] GetSubMesh()
	{
		return null;
	}

	[Token(Token = "0x602925F")]
	[Address(RVA = "0x4B0ED58", Offset = "0x4B0ED58", VA = "0x104B0ED58")]
	public SubMeshTriangles[] GetSubMeshNew()
	{
		return null;
	}

	[Token(Token = "0x6029260")]
	[Address(RVA = "0x4B0EFFC", Offset = "0x4B0EFFC", VA = "0x104B0EFFC")]
	public bool HasUV()
	{
		return default(bool);
	}

	[Token(Token = "0x6029261")]
	[Address(RVA = "0x4B0F0C0", Offset = "0x4B0F0C0", VA = "0x104B0F0C0")]
	public bool HasUV2()
	{
		return default(bool);
	}

	[Token(Token = "0x6029262")]
	[Address(RVA = "0x4B0E27C", Offset = "0x4B0E27C", VA = "0x104B0E27C")]
	public Vector2[] GetUvs()
	{
		return null;
	}

	[Token(Token = "0x6029263")]
	[Address(RVA = "0x4B0E6A8", Offset = "0x4B0E6A8", VA = "0x104B0E6A8")]
	public Vector2[] GetUv2s()
	{
		return null;
	}

	[Token(Token = "0x6029264")]
	[Address(RVA = "0x4B0F2A0", Offset = "0x4B0F2A0", VA = "0x104B0F2A0")]
	public bool HasNormals()
	{
		return default(bool);
	}

	[Token(Token = "0x6029265")]
	[Address(RVA = "0x4B0F364", Offset = "0x4B0F364", VA = "0x104B0F364")]
	public bool HasTangents()
	{
		return default(bool);
	}

	[Token(Token = "0x6029266")]
	[Address(RVA = "0x4B0F3A0", Offset = "0x4B0F3A0", VA = "0x104B0F3A0")]
	public Vector4[] GetTangents()
	{
		return null;
	}

	[MethodImpl(512)]
	[Token(Token = "0x6029267")]
	[Address(RVA = "0x4B0F3E4", Offset = "0x4B0F3E4", VA = "0x104B0F3E4")]
	public static implicit operator bool(UMAMeshData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6029268")]
	[Address(RVA = "0x4B0F3F8", Offset = "0x4B0F3F8", VA = "0x104B0F3F8")]
	public bool Equals(UMAMeshData other)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029269")]
	[Address(RVA = "0x4B0F488", Offset = "0x4B0F488", VA = "0x104B0F488", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602926A")]
	[Address(RVA = "0x4B0F440", Offset = "0x4B0F440", VA = "0x104B0F440")]
	public static bool operator ==(UMAMeshData overlay, UMAMeshData obj)
	{
		return default(bool);
	}

	[MethodImpl(512)]
	[Token(Token = "0x602926B")]
	[Address(RVA = "0x4B0F55C", Offset = "0x4B0F55C", VA = "0x104B0F55C")]
	public static bool operator !=(UMAMeshData overlay, UMAMeshData obj)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x602926C")]
	[Address(RVA = "0x4B0F5A0", Offset = "0x4B0F5A0", VA = "0x104B0F5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x602926D")]
	[Address(RVA = "0x4B0EA50", Offset = "0x4B0EA50", VA = "0x104B0EA50")]
	public static void TranlateBoneWeightArray(ref BoneWeight bw, int sourceIndex, byte[] boneWeightArray, int[] boneMapping)
	{
	}

	[Token(Token = "0x602926E")]
	[Address(RVA = "0x4B0F5A8", Offset = "0x4B0F5A8", VA = "0x104B0F5A8")]
	public static void TranlateBoneWeightToArray(int sourceIndex, byte[] boneWeightArray, ref BoneWeight bw)
	{
	}

	[Token(Token = "0x602926F")]
	[Address(RVA = "0x4B0F7AC", Offset = "0x4B0F7AC", VA = "0x104B0F7AC")]
	public static void UpdateBoneIndexForBoneWightArray(int sourceIndex, byte[] boneWeightArray, int[] boneMapping)
	{
	}
}
