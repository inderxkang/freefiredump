using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UMA.Simple;

namespace UMA;

[Token(Token = "0x20060C6")]
public static class UmaSimpleUtils
{
	[Token(Token = "0x20060C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x208B68", Offset = "0x208B68")]
	private sealed class _003CStringToBits_003Ec__AnonStorey0
	{
		[Token(Token = "0x402D779")]
		[FieldOffset(Offset = "0x10")]
		internal Func<string, int> strToIdx;

		[Token(Token = "0x402D77A")]
		[FieldOffset(Offset = "0x18")]
		internal int ret;

		[MethodImpl(768)]
		[Token(Token = "0x6028FE6")]
		[Address(RVA = "0x4B154E0", Offset = "0x4B154E0", VA = "0x104B154E0")]
		public _003CStringToBits_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6028FE7")]
		[Address(RVA = "0x4B16D84", Offset = "0x4B16D84", VA = "0x104B16D84")]
		internal void _003C_003Em__0(string s)
		{
		}
	}

	[Token(Token = "0x402D776")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<string, int> RaceNameToEnums;

	[Token(Token = "0x402D777")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<string, int> BaseSlotNameToEnums;

	[Token(Token = "0x402D778")]
	[FieldOffset(Offset = "0x10")]
	public static Dictionary<string, int> WardrobeSlotNameToEnums;

	[Token(Token = "0x6028FCC")]
	[Address(RVA = "0x4B15404", Offset = "0x4B15404", VA = "0x104B15404")]
	public static void LogErrorNonLive(string msg)
	{
	}

	[Token(Token = "0x6028FCD")]
	[Address(RVA = "0x4B15408", Offset = "0x4B15408", VA = "0x104B15408")]
	public static int StringToBits(List<string> ss, Func<string, int> strToIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6028FCE")]
	[Address(RVA = "0x4B154E8", Offset = "0x4B154E8", VA = "0x104B154E8")]
	private static int StringToBitsMasked(List<string> ss, Func<string, int> strToIdx, int invalidBits = 1)
	{
		return default(int);
	}

	[Token(Token = "0x6028FCF")]
	[Address(RVA = "0x4B1550C", Offset = "0x4B1550C", VA = "0x104B1550C")]
	private static Dictionary<string, int> InitNameToEnumMap(string[] ss)
	{
		return null;
	}

	[Token(Token = "0x6028FD0")]
	[Address(RVA = "0x4B15600", Offset = "0x4B15600", VA = "0x104B15600")]
	private static int GetEnumByName(Dictionary<string, int> dic, string s, int @default = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6028FD1")]
	[Address(RVA = "0x4B15698", Offset = "0x4B15698", VA = "0x104B15698")]
	public static string GetRaceName(ERace e)
	{
		return null;
	}

	[Token(Token = "0x6028FD2")]
	[Address(RVA = "0x4B15734", Offset = "0x4B15734", VA = "0x104B15734")]
	public static bool IsFemale(ERace e)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FD3")]
	[Address(RVA = "0x4B15744", Offset = "0x4B15744", VA = "0x104B15744")]
	public static EBaseSlot GetBaseSlot(string s)
	{
		return default(EBaseSlot);
	}

	[Token(Token = "0x6028FD4")]
	[Address(RVA = "0x4B157E8", Offset = "0x4B157E8", VA = "0x104B157E8")]
	public static string GetWardrobeSlotName(EWardrobeSlot e)
	{
		return null;
	}

	[Token(Token = "0x6028FD5")]
	[Address(RVA = "0x4B15884", Offset = "0x4B15884", VA = "0x104B15884")]
	public static EWardrobeSlot GetWardrobeSlot(string s)
	{
		return default(EWardrobeSlot);
	}

	[Token(Token = "0x6028FD6")]
	[Address(RVA = "0x4B15928", Offset = "0x4B15928", VA = "0x104B15928")]
	public static string GetWardrobeSlotName(EAdditiveTargetSlot e)
	{
		return null;
	}

	[Token(Token = "0x6028FD7")]
	[Address(RVA = "0x4B15934", Offset = "0x4B15934", VA = "0x104B15934")]
	public static EWardrobeSlot GetTargetWardrobeSlot(EAdditiveTargetSlot e)
	{
		return default(EWardrobeSlot);
	}

	[Token(Token = "0x6028FD8")]
	[Address(RVA = "0x4B15940", Offset = "0x4B15940", VA = "0x104B15940")]
	public static int GetTargetBaseSlots(EAdditiveTargetSlot e)
	{
		return default(int);
	}

	[Token(Token = "0x6028FD9")]
	[Address(RVA = "0x4B15954", Offset = "0x4B15954", VA = "0x104B15954")]
	public static bool IsPotensialAdditiveSlot(string slotName)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDA")]
	[Address(RVA = "0x4B15A14", Offset = "0x4B15A14", VA = "0x104B15A14")]
	public static bool IsPotensialAdditiveSrcSlot(string wardrobeSlot)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDB")]
	[Address(RVA = "0x4B15A84", Offset = "0x4B15A84", VA = "0x104B15A84")]
	public static bool GetRecipe(int recipe, out UMATextRecipe textRecipe, out UmaRecipeSimple simpleRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDC")]
	[Address(RVA = "0x4B15EB0", Offset = "0x4B15EB0", VA = "0x104B15EB0")]
	public static bool IsConflict(int selectRecipe, int targetRecipe, bool considerHidingTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDD")]
	[Address(RVA = "0x4B16180", Offset = "0x4B16180", VA = "0x104B16180")]
	public static bool IsHidenByTarget(UmaRecipeSimple srcRecipe, UmaRecipeSimple targetRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDE")]
	[Address(RVA = "0x4B161FC", Offset = "0x4B161FC", VA = "0x104B161FC")]
	public static bool IsHidenByTarget(UMATextRecipe srcRecipe, UMATextRecipe targetRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FDF")]
	[Address(RVA = "0x4B162E4", Offset = "0x4B162E4", VA = "0x104B162E4")]
	public static bool HasSuppress(int recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FE0")]
	[Address(RVA = "0x4B164D8", Offset = "0x4B164D8", VA = "0x104B164D8")]
	public static bool HasSuppress(UmaRecipeSimple recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FE1")]
	[Address(RVA = "0x4B163FC", Offset = "0x4B163FC", VA = "0x104B163FC")]
	public static bool HasSuppress(UMATextRecipe recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FE2")]
	[Address(RVA = "0x4B16514", Offset = "0x4B16514", VA = "0x104B16514")]
	public static void MergeAdditiveSlot(SlotData dst, OverlayData srcOverlay, AdditiveInfo srcInfo)
	{
	}

	[Token(Token = "0x6028FE3")]
	[Address(RVA = "0x4B16950", Offset = "0x4B16950", VA = "0x104B16950")]
	public static void SortReplaceSlotsInNeed(List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	[Token(Token = "0x6028FE4")]
	[Address(RVA = "0x4B16AB4", Offset = "0x4B16AB4", VA = "0x104B16AB4")]
	public static bool NoClothTextureMerge(List<OverlayData> overlayList)
	{
		return default(bool);
	}

	[Token(Token = "0x6028FE5")]
	[Address(RVA = "0x4B16C24", Offset = "0x4B16C24", VA = "0x104B16C24")]
	public static bool NoSkinTextureMerge(List<OverlayData> overlayList)
	{
		return default(bool);
	}
}
