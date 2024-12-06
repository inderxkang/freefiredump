using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x200611E")]
public class UMABlendShape
{
	[Token(Token = "0x402D9A5")]
	[FieldOffset(Offset = "0x10")]
	public string shapeName;

	[Token(Token = "0x402D9A6")]
	[FieldOffset(Offset = "0x18")]
	public UMABlendFrame[] frames;

	[MethodImpl(768)]
	[Token(Token = "0x6029237")]
	[Address(RVA = "0x4AF893C", Offset = "0x4AF893C", VA = "0x104AF893C")]
	public UMABlendShape()
	{
	}
}
