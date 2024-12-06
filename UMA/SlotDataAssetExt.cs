using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x20060A3")]
public class SlotDataAssetExt : SlotDataAsset
{
	[Token(Token = "0x402D657")]
	[FieldOffset(Offset = "0x88")]
	public AdditiveInfo additiveInfo;

	[MethodImpl(768)]
	[Token(Token = "0x6028E4F")]
	[Address(RVA = "0x4AF1014", Offset = "0x4AF1014", VA = "0x104AF1014")]
	public SlotDataAssetExt()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028E50")]
	[Address(RVA = "0x4AF1018", Offset = "0x4AF1018", VA = "0x104AF1018", Slot = "8")]
	public override AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}
}
