using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x200611D")]
public class UMABlendFrame
{
	[Token(Token = "0x402D9A1")]
	[FieldOffset(Offset = "0x10")]
	public float frameWeight;

	[Token(Token = "0x402D9A2")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] deltaVertices;

	[Token(Token = "0x402D9A3")]
	[FieldOffset(Offset = "0x20")]
	public Vector3[] deltaNormals;

	[Token(Token = "0x402D9A4")]
	[FieldOffset(Offset = "0x28")]
	public Vector3[] deltaTangents;

	[MethodImpl(768)]
	[Token(Token = "0x6029236")]
	[Address(RVA = "0x4AF88A0", Offset = "0x4AF88A0", VA = "0x104AF88A0")]
	public UMABlendFrame(int vertexCount)
	{
	}
}
