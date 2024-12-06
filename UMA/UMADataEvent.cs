using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UMA;

[Serializable]
[Token(Token = "0x2006108")]
public class UMADataEvent : UnityEvent<UMAData>
{
	[MethodImpl(768)]
	[Token(Token = "0x60291C0")]
	[Address(RVA = "0x4AF93C4", Offset = "0x4AF93C4", VA = "0x104AF93C4")]
	public UMADataEvent()
	{
	}

	[MethodImpl(768)]
	[Token(Token = "0x60291C1")]
	[Address(RVA = "0x4AFF3EC", Offset = "0x4AFF3EC", VA = "0x104AFF3EC")]
	public UMADataEvent(UMADataEvent source)
	{
	}
}
