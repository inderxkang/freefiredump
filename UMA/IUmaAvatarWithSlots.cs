using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x20060A1")]
public interface IUmaAvatarWithSlots : IUmaAvatarBase
{
	[MethodImpl(256)]
	[Token(Token = "0x6028E3C")]
	void SetSlot(int recipeHash);

	[MethodImpl(256)]
	[Token(Token = "0x6028E3D")]
	void SetSlot(int recipeHash, uint id);

	[MethodImpl(256)]
	[Token(Token = "0x6028E3E")]
	void ClearSlot(string slot);

	[MethodImpl(256)]
	[Token(Token = "0x6028E3F")]
	void ClearSlots();

	[MethodImpl(256)]
	[Token(Token = "0x6028E40")]
	bool IsSlotVisible(string slot);

	[MethodImpl(256)]
	[Token(Token = "0x6028E41")]
	bool HasSlot(string slot);

	[MethodImpl(256)]
	[Token(Token = "0x6028E42")]
	List<uint> GetIds();
}
