using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006105")]
public class UMADefaultMeshCombiner : UMAMeshCombiner
{
	[Token(Token = "0x402D901")]
	[FieldOffset(Offset = "0x18")]
	protected List<SkinnedMeshCombiner.CombineInstance> combinedMeshList;

	[Token(Token = "0x402D902")]
	[FieldOffset(Offset = "0x20")]
	protected List<SkinnedMeshCombiner.CombineInstance> combinedMeshListPool;

	[Token(Token = "0x402D903")]
	[FieldOffset(Offset = "0x28")]
	protected Material[] combinedMaterialList;

	[Token(Token = "0x402D904")]
	protected const int MaxCacheMatArrayLength = 10;

	[Token(Token = "0x402D905")]
	[FieldOffset(Offset = "0x30")]
	protected Material[][] cachedMatArrays;

	[Token(Token = "0x402D906")]
	[FieldOffset(Offset = "0x38")]
	private int atlasResolution;

	[Token(Token = "0x402D907")]
	[FieldOffset(Offset = "0x0")]
	public static int MAX_VERT_NUM;

	[Token(Token = "0x402D908")]
	[FieldOffset(Offset = "0x4")]
	public static int MAX_VERT_NUM_LOWMEM;

	[Token(Token = "0x402D909")]
	[FieldOffset(Offset = "0x8")]
	private static List<Vector3> verticesList;

	[Token(Token = "0x402D90A")]
	[FieldOffset(Offset = "0x10")]
	private static List<Vector4> tangentsList;

	[Token(Token = "0x402D90B")]
	[FieldOffset(Offset = "0x18")]
	private static List<Vector3> normalsList;

	[Token(Token = "0x402D90C")]
	[FieldOffset(Offset = "0x20")]
	private static List<Vector2> uvList;

	[Token(Token = "0x402D90D")]
	[FieldOffset(Offset = "0x28")]
	private static List<Vector2> uv2List;

	[Token(Token = "0x402D90E")]
	[FieldOffset(Offset = "0x30")]
	private static List<List<int>> trianglesList;

	[Token(Token = "0x402D90F")]
	[FieldOffset(Offset = "0x38")]
	private static BoneWeight[] boneWeightsCache;

	[Token(Token = "0x402D910")]
	[FieldOffset(Offset = "0x40")]
	private static BoneWeight[] emptyBoneWeights;

	[Token(Token = "0x402D911")]
	[FieldOffset(Offset = "0x40")]
	private string useSpecialUVShaderName;

	[Token(Token = "0x402D912")]
	[FieldOffset(Offset = "0x48")]
	private string noTangentShaderName;

	[Token(Token = "0x402D913")]
	[FieldOffset(Offset = "0x48")]
	public static bool OptGc;

	[Token(Token = "0x402D914")]
	[FieldOffset(Offset = "0x50")]
	private static UMAMeshDataForBuild s_SharedUMAMeshData;

	[MethodImpl(768)]
	[Token(Token = "0x60291AF")]
	[Address(RVA = "0x4AFF5CC", Offset = "0x4AFF5CC", VA = "0x104AFF5CC")]
	public UMADefaultMeshCombiner()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x60291B0")]
	[Address(RVA = "0x4AFF630", Offset = "0x4AFF630", VA = "0x104AFF630")]
	public void Start()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x60291B1")]
	[Address(RVA = "0x4AFFAC4", Offset = "0x4AFFAC4", VA = "0x104AFFAC4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60291B2")]
	[Address(RVA = "0x4AFF9CC", Offset = "0x4AFF9CC", VA = "0x104AFF9CC")]
	public static int GetMaxTriangleNum()
	{
		return default(int);
	}

	[Token(Token = "0x60291B3")]
	[Address(RVA = "0x4AFFB6C", Offset = "0x4AFFB6C", VA = "0x104AFFB6C")]
	protected void EnsureUMADataSetup(UMAData umaData)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291B4")]
	[Address(RVA = "0x4B004C4", Offset = "0x4B004C4", VA = "0x104B004C4", Slot = "4")]
	public override void UpdateUMAMesh(bool updatedAtlas, UMAData umaData, int atlasResolution)
	{
	}

	[Token(Token = "0x60291B5")]
	[Address(RVA = "0x4B00F4C", Offset = "0x4B00F4C", VA = "0x104B00F4C")]
	protected void BuildCombineInstances(UMAData umaData)
	{
	}

	[Token(Token = "0x60291B6")]
	[Address(RVA = "0x4B01368", Offset = "0x4B01368", VA = "0x104B01368")]
	protected bool NeedTangent(UMAData umaData)
	{
		return default(bool);
	}

	[Token(Token = "0x60291B7")]
	[Address(RVA = "0x4B014C0", Offset = "0x4B014C0", VA = "0x104B014C0")]
	protected void RecalculateUV(UMAMeshData umaMesh, UMAData umaData, ref List<Vector2> uv2List)
	{
	}
}
