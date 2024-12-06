using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x20060B8")]
public abstract class UmaAvatarWithSlots<T> : UMAAvatarBase, IUmaAvatarWithSlots, IUmaAvatarBase where T : IUintId
{
	[Token(Token = "0x402D6E3")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<string, T> _wardrobeRecipes;

	[Token(Token = "0x17002979")]
	public Dictionary<string, T> WardrobeRecipes
	{
		[MethodImpl(512)]
		[Token(Token = "0x6028F70")]
		get
		{
			return null;
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6028F6F")]
	protected UmaAvatarWithSlots()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F71")]
	protected abstract T FindSlotRecipe(int recipe);

	[MethodImpl(256)]
	[Token(Token = "0x6028F72")]
	protected abstract string GetRecipeSlot(T recipe);

	[MethodImpl(256)]
	[Token(Token = "0x6028F73")]
	public void SetSlot(int recipe)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F74")]
	public void SetSlot(int recipe, uint id)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F75")]
	public virtual void SetSlot(string slot, T utr)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F76")]
	public void ClearSlot(string ws)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F77")]
	public void ClearSlots()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F78")]
	public virtual bool IsSlotVisible(string slot)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F79")]
	public bool HasSlot(string slot)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028F7A")]
	public List<uint> GetIds()
	{
		return null;
	}
}
