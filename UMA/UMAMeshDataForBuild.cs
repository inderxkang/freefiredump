using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006122")]
public class UMAMeshDataForBuild : UMAMeshData
{
	[Token(Token = "0x402D9D1")]
	[FieldOffset(Offset = "0x148")]
	public List<int> boneNameHashesList;

	[Token(Token = "0x402D9D2")]
	[FieldOffset(Offset = "0x150")]
	public List<Matrix4x4> bindPosesList;

	[Token(Token = "0x402D9D3")]
	[FieldOffset(Offset = "0x0")]
	private static int[] s_EmptyTris;

	[Token(Token = "0x402D9D4")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] s_EmptyVerts;

	[Token(Token = "0x402D9D5")]
	[FieldOffset(Offset = "0x10")]
	private static Vector2[] s_WarmupVect2;

	[Token(Token = "0x402D9D6")]
	[FieldOffset(Offset = "0x18")]
	private static Vector3[] s_WarmupVect3;

	[Token(Token = "0x402D9D7")]
	[FieldOffset(Offset = "0x20")]
	private static Vector4[] s_WarmupVect4;

	[Token(Token = "0x402D9D8")]
	[FieldOffset(Offset = "0x28")]
	private static BoneWeight[] s_WarmupBoneWeight;

	[MethodImpl(768)]
	[Token(Token = "0x6029270")]
	[Address(RVA = "0x4B0F9D0", Offset = "0x4B0F9D0", VA = "0x104B0F9D0")]
	public UMAMeshDataForBuild()
	{
	}

	[Token(Token = "0x6029271")]
	[Address(RVA = "0x4B0F9D4", Offset = "0x4B0F9D4", VA = "0x104B0F9D4")]
	public void ApplyDataToUnityMesh(SkinnedMeshRenderer renderer, UMASkeleton skeleton, List<Vector3> verticesList, List<Vector4> tangentsList, List<Vector3> normalsList, List<Vector2> uvList, List<Vector2> uv2List)
	{
	}

	[Token(Token = "0x6029272")]
	[Address(RVA = "0x4B1065C", Offset = "0x4B1065C", VA = "0x104B1065C")]
	public void ApplySharedMesh(UMAData umaData)
	{
	}

	[Token(Token = "0x6029273")]
	[Address(RVA = "0x4B104B8", Offset = "0x4B104B8", VA = "0x104B104B8")]
	private void CreateTransforms(UMASkeleton skeleton)
	{
	}

	[Token(Token = "0x6029274")]
	[Address(RVA = "0x4B10650", Offset = "0x4B10650", VA = "0x104B10650")]
	private bool OwnSharedBuffers()
	{
		return default(bool);
	}

	[Token(Token = "0x6029275")]
	[Address(RVA = "0x4B10658", Offset = "0x4B10658", VA = "0x104B10658")]
	private void ApplySharedBuffers(Mesh mesh)
	{
	}

	[Token(Token = "0x6029276")]
	[Address(RVA = "0x4B10858", Offset = "0x4B10858", VA = "0x104B10858")]
	public bool ClaimSharedBuffers()
	{
		return default(bool);
	}

	[Token(Token = "0x6029277")]
	[Address(RVA = "0x4B10860", Offset = "0x4B10860", VA = "0x104B10860")]
	public void ReleaseSharedBuffers()
	{
	}
}
