using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060E5")]
[ExecuteInEditMode]
public class SeamRemoval : MonoBehaviour
{
	[Token(Token = "0x402D7E5")]
	[FieldOffset(Offset = "0x18")]
	public bool runScript;

	[Token(Token = "0x402D7E6")]
	[FieldOffset(Offset = "0x1C")]
	public float threshold;

	[Token(Token = "0x402D7E7")]
	[FieldOffset(Offset = "0x20")]
	public Transform separatedMesh;

	[Token(Token = "0x402D7E8")]
	[FieldOffset(Offset = "0x28")]
	public Transform unifiedMesh;

	[MethodImpl(768)]
	[Token(Token = "0x602909A")]
	[Address(RVA = "0x4ACE5E0", Offset = "0x4ACE5E0", VA = "0x104ACE5E0")]
	public SeamRemoval()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x602909B")]
	[Address(RVA = "0x4ACE5F4", Offset = "0x4ACE5F4", VA = "0x104ACE5F4")]
	private void Update()
	{
	}

	[Token(Token = "0x602909C")]
	[Address(RVA = "0x4ACE794", Offset = "0x4ACE794", VA = "0x104ACE794")]
	public static Mesh PerformSeamRemoval(SkinnedMeshRenderer originalMesh, SkinnedMeshRenderer referenceMesh, float threshold)
	{
		return null;
	}

	[Token(Token = "0x602909D")]
	[Address(RVA = "0x4ACED2C", Offset = "0x4ACED2C", VA = "0x104ACED2C")]
	public static void calculateMeshTangents(Mesh mesh)
	{
	}
}
