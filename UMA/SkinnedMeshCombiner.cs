using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060E8")]
public static class SkinnedMeshCombiner
{
	[Token(Token = "0x20060E9")]
	public class CombineInstance
	{
		[Token(Token = "0x402D7F6")]
		[FieldOffset(Offset = "0x10")]
		public UMAMeshData meshData;

		[Token(Token = "0x402D7F7")]
		[FieldOffset(Offset = "0x18")]
		public List<int> targetSubmeshIndices;

		[MethodImpl(768)]
		[Token(Token = "0x60290BD")]
		[Address(RVA = "0x4AEF9A0", Offset = "0x4AEF9A0", VA = "0x104AEF9A0")]
		public CombineInstance()
		{
		}

		[Token(Token = "0x60290BE")]
		[Address(RVA = "0x4AEF9A8", Offset = "0x4AEF9A8", VA = "0x104AEF9A8")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x20060EA")]
	private enum MeshComponents
	{
		[Token(Token = "0x402D7F9")]
		none = 0,
		[Token(Token = "0x402D7FA")]
		has_normals = 1,
		[Token(Token = "0x402D7FB")]
		has_tangents = 2,
		[Token(Token = "0x402D7FC")]
		has_colors32 = 4,
		[Token(Token = "0x402D7FD")]
		has_uv = 8,
		[Token(Token = "0x402D7FE")]
		has_uv2 = 0x10,
		[Token(Token = "0x402D7FF")]
		has_uv3 = 0x20,
		[Token(Token = "0x402D800")]
		has_uv4 = 0x40,
		[Token(Token = "0x402D801")]
		has_blendShapes = 0x80
	}

	[Token(Token = "0x20060EB")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x208B88", Offset = "0x208B88")]
	private class BoneIndexEntry
	{
		[Token(Token = "0x402D802")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x402D803")]
		[FieldOffset(Offset = "0x18")]
		public List<int> indices;

		[Token(Token = "0x17002983")]
		public int Count
		{
			[MethodImpl(512)]
			[Token(Token = "0x60290C0")]
			[Address(RVA = "0x4AEF720", Offset = "0x4AEF720", VA = "0x104AEF720")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17002984")]
		public int Item
		{
			[MethodImpl(512)]
			[Token(Token = "0x60290C1")]
			[Address(RVA = "0x4AEF798", Offset = "0x4AEF798", VA = "0x104AEF798")]
			get
			{
				return default(int);
			}
		}

		[MethodImpl(768)]
		[Token(Token = "0x60290BF")]
		[Address(RVA = "0x4AEF718", Offset = "0x4AEF718", VA = "0x104AEF718")]
		public BoneIndexEntry()
		{
		}

		[Token(Token = "0x60290C2")]
		[Address(RVA = "0x4AEF85C", Offset = "0x4AEF85C", VA = "0x104AEF85C")]
		internal void AddIndex(int idx)
		{
		}

		[Token(Token = "0x60290C3")]
		[Address(RVA = "0x4AEF938", Offset = "0x4AEF938", VA = "0x104AEF938")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x402D7EC")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_enableNewUMABuild;

	[Token(Token = "0x402D7ED")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, BoneIndexEntry> bonesCollection;

	[Token(Token = "0x402D7EE")]
	[FieldOffset(Offset = "0x10")]
	private static List<Matrix4x4> bindPoses;

	[Token(Token = "0x402D7EF")]
	[FieldOffset(Offset = "0x18")]
	private static List<int> bonesList;

	[Token(Token = "0x402D7F0")]
	[FieldOffset(Offset = "0x20")]
	private static List<int> s_SubMeshTrisCnt;

	[Token(Token = "0x402D7F1")]
	[FieldOffset(Offset = "0x28")]
	public static bool OptGc;

	[Token(Token = "0x402D7F2")]
	[FieldOffset(Offset = "0x30")]
	private static List<BoneIndexEntry> s_BoneIndexEntryPool;

	[Token(Token = "0x402D7F3")]
	[FieldOffset(Offset = "0x38")]
	private static int s_BoneIndexEntryPoolUsedCnt;

	[Token(Token = "0x402D7F4")]
	[FieldOffset(Offset = "0x40")]
	private static int[] s_nonSharedBoneMapping;

	[Token(Token = "0x402D7F5")]
	[FieldOffset(Offset = "0x48")]
	private static int[] s_sharedBoneMapping;

	[Token(Token = "0x60290A5")]
	[Address(RVA = "0x4AE8798", Offset = "0x4AE8798", VA = "0x104AE8798")]
	public static void BuildBones(UMAMeshDataForBuild target, List<CombineInstance> sources, bool ignoreBlendShapes = false)
	{
	}

	[Token(Token = "0x60290A6")]
	[Address(RVA = "0x4AEA050", Offset = "0x4AEA050", VA = "0x104AEA050")]
	private static void ResetBoneIndexEntryPool()
	{
	}

	[Token(Token = "0x60290A7")]
	[Address(RVA = "0x4AEA504", Offset = "0x4AEA504", VA = "0x104AEA504")]
	private static BoneIndexEntry AllocBoneIndexEntry()
	{
		return null;
	}

	[Token(Token = "0x60290A8")]
	[Address(RVA = "0x4AEA74C", Offset = "0x4AEA74C", VA = "0x104AEA74C")]
	public static void CombineMeshes(UMAMeshDataForBuild target, List<CombineInstance> sources, ref List<Vector3> verticesList, ref List<Vector4> tangentsList, ref List<Vector3> normalsList, ref List<Vector2> uvList, ref List<Vector2> uv2List, ref List<List<int>> trianglesList, ref BoneWeight[] boneWeightsCache, int maxTriNum, bool ignoreBlendShapes = false, bool needTangent = true)
	{
	}

	[Token(Token = "0x60290A9")]
	[Address(RVA = "0x4AE9C4C", Offset = "0x4AE9C4C", VA = "0x104AE9C4C")]
	private static void MergeSortedTransforms(UMATransform[] mergedTransforms, ref int len1, UMATransform[] umaTransforms)
	{
	}

	[Token(Token = "0x60290AA")]
	[Address(RVA = "0x4AE9444", Offset = "0x4AE9444", VA = "0x104AE9444")]
	private static void AnalyzeSources(List<CombineInstance> sources, List<int> subMeshTriangleLength, int subMeshCnt, ref int vertexCount, ref int bindPoseCount, ref int transformHierarchyCount, ref MeshComponents meshComponents, ref int blendShapeCount)
	{
	}

	[Token(Token = "0x60290AB")]
	[Address(RVA = "0x4AE91A0", Offset = "0x4AE91A0", VA = "0x104AE91A0")]
	private static int FindTargetSubMeshCount(List<CombineInstance> sources)
	{
		return default(int);
	}

	[Token(Token = "0x60290AC")]
	[Address(RVA = "0x4AEDFE8", Offset = "0x4AEDFE8", VA = "0x104AEDFE8")]
	private static void BuildBoneWeights(UMAMeshData meshData, int sourceIndex, BoneWeight[] dest, int destIndex, int count, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList, int[] sharedBoneMapping, int[] nonSharedBoneMapping)
	{
	}

	[Token(Token = "0x60290AD")]
	[Address(RVA = "0x4AEF194", Offset = "0x4AEF194", VA = "0x104AEF194")]
	public static bool CompareSkinningMatrices(ref Matrix4x4 m1, ref Matrix4x4 m2)
	{
		return default(bool);
	}

	[Token(Token = "0x60290AE")]
	[Address(RVA = "0x4AEA198", Offset = "0x4AEA198", VA = "0x104AEA198")]
	private static int TranslateBoneIndex(int index, int[] bonesHashes, Matrix4x4[] bindPoses, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList)
	{
		return default(int);
	}

	[Token(Token = "0x60290AF")]
	[Address(RVA = "0x4AEF44C", Offset = "0x4AEF44C", VA = "0x104AEF44C")]
	private static void CopyColorsToColors32(Color[] source, int sourceIndex, Color32[] dest, int destIndex, int count)
	{
	}

	[Token(Token = "0x60290B0")]
	[Address(RVA = "0x4AEE75C", Offset = "0x4AEE75C", VA = "0x104AEE75C")]
	private static void FillArray(Vector4[] array, int index, int count, Vector4 value)
	{
	}

	[Token(Token = "0x60290B1")]
	[Address(RVA = "0x4AEE6B4", Offset = "0x4AEE6B4", VA = "0x104AEE6B4")]
	private static void FillArray(Vector3[] array, int index, int count, Vector3 value)
	{
	}

	[Token(Token = "0x60290B2")]
	[Address(RVA = "0x4AEECDC", Offset = "0x4AEECDC", VA = "0x104AEECDC")]
	private static void FillArray(Vector2[] array, int index, int count, Vector2 value)
	{
	}

	[Token(Token = "0x60290B3")]
	[Address(RVA = "0x4AEF5F4", Offset = "0x4AEF5F4", VA = "0x104AEF5F4")]
	private static void FillArray(Color[] array, int index, int count, Color value)
	{
	}

	[Token(Token = "0x60290B4")]
	[Address(RVA = "0x4AEED68", Offset = "0x4AEED68", VA = "0x104AEED68")]
	private static void FillArray(Color32[] array, int index, int count, Color32 value)
	{
	}

	[Token(Token = "0x60290B5")]
	[Address(RVA = "0x4AEF0C8", Offset = "0x4AEF0C8", VA = "0x104AEF0C8")]
	private static void CopyIntArrayAdd(int[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60290B6")]
	[Address(RVA = "0x4AEEFF4", Offset = "0x4AEEFF4", VA = "0x104AEEFF4")]
	private static void CopyIntArrayAdd(int[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60290B7")]
	[Address(RVA = "0x4AEEEF8", Offset = "0x4AEEEF8", VA = "0x104AEEEF8")]
	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60290B8")]
	[Address(RVA = "0x4AEEDEC", Offset = "0x4AEEDEC", VA = "0x104AEEDEC")]
	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60290B9")]
	private static T[] EnsureArrayLength<T>(T[] oldArray, int newLength)
	{
		return null;
	}

	[Token(Token = "0x60290BA")]
	[Address(RVA = "0x4AEE948", Offset = "0x4AEE948", VA = "0x104AEE948")]
	private static void AddSourceUVToDes(int uvIndex, UMAMeshData sourceMeshData, int vertexCount, int vertexIndex, ref List<Vector2> uvList, Vector2[] uv)
	{
	}

	[Token(Token = "0x60290BB")]
	[Address(RVA = "0x4AEE7FC", Offset = "0x4AEE7FC", VA = "0x104AEE7FC")]
	private static void AddSourceUVToDes(int uvIndex, UMAMeshData sourceMeshData, ref List<Vector2> uvList)
	{
	}
}
