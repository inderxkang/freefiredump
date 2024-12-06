using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x200611B")]
public class UMATransform
{
	[Token(Token = "0x200611C")]
	public class UMATransformComparer : IComparer<UMATransform>
	{
		[MethodImpl(768)]
		[Token(Token = "0x6029234")]
		[Address(RVA = "0x4B13588", Offset = "0x4B13588", VA = "0x104B13588")]
		public UMATransformComparer()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029235")]
		[Address(RVA = "0x4B13590", Offset = "0x4B13590", VA = "0x104B13590", Slot = "4")]
		public int Compare(UMATransform x, UMATransform y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x402D99A")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 position;

	[Token(Token = "0x402D99B")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion rotation;

	[Token(Token = "0x402D99C")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 scale;

	[Token(Token = "0x402D99D")]
	[FieldOffset(Offset = "0x38")]
	public string name;

	[Token(Token = "0x402D99E")]
	[FieldOffset(Offset = "0x40")]
	public int hash;

	[Token(Token = "0x402D99F")]
	[FieldOffset(Offset = "0x44")]
	public int parent;

	[Token(Token = "0x402D9A0")]
	[FieldOffset(Offset = "0x0")]
	public static UMATransformComparer TransformComparer;

	[MethodImpl(768)]
	[Token(Token = "0x602922F")]
	[Address(RVA = "0x4B13514", Offset = "0x4B13514", VA = "0x104B13514")]
	public UMATransform()
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029230")]
	[Address(RVA = "0x4B1213C", Offset = "0x4B1213C", VA = "0x104B1213C")]
	public UMATransform(Transform transform, int nameHash, int parentHash)
	{
	}

	[Token(Token = "0x6029231")]
	[Address(RVA = "0x4B123C4", Offset = "0x4B123C4", VA = "0x104B123C4")]
	public UMATransform Duplicate()
	{
		return null;
	}

	[Token(Token = "0x6029232")]
	[Address(RVA = "0x4B131D4", Offset = "0x4B131D4", VA = "0x104B131D4")]
	public void Assign(UMATransform other)
	{
	}
}
