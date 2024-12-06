using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x20060C5")]
public static class UmaSettings
{
	[Token(Token = "0x402D74F")]
	[FieldOffset(Offset = "0x0")]
	public static bool LogError;

	[Token(Token = "0x402D750")]
	[FieldOffset(Offset = "0x1")]
	public static bool LogDetail;

	[Token(Token = "0x402D751")]
	[FieldOffset(Offset = "0x2")]
	public static bool LogTimes;

	[Token(Token = "0x402D752")]
	[FieldOffset(Offset = "0x3")]
	public static bool UsingAvatarSimple;

	[Token(Token = "0x402D753")]
	[FieldOffset(Offset = "0x4")]
	public static bool SkipBuildIfNotVisibleV2;

	[Token(Token = "0x402D754")]
	[FieldOffset(Offset = "0x5")]
	public static bool SkipBuildIfNotVisible;

	[Token(Token = "0x402D755")]
	[FieldOffset(Offset = "0x6")]
	public static bool SkipBuildIfNoVisibleChange;

	[Token(Token = "0x402D756")]
	[FieldOffset(Offset = "0x7")]
	public static bool ReAddBaseSlotsWhenWardrobeLoadFailed;

	[Token(Token = "0x402D757")]
	[FieldOffset(Offset = "0x8")]
	public static bool PoolSlotOverlayData;

	[Token(Token = "0x402D758")]
	[FieldOffset(Offset = "0x9")]
	public static bool PoolSlotOverlayDataFixMatchOverlay;

	[Token(Token = "0x402D759")]
	[FieldOffset(Offset = "0xA")]
	public static bool OptBuildGc;

	[Token(Token = "0x402D75A")]
	[FieldOffset(Offset = "0xB")]
	public static bool FaceFlow;

	[Token(Token = "0x402D75B")]
	[FieldOffset(Offset = "0xC")]
	public static bool FixNoClothTextureMergeForAdditive;

	[Token(Token = "0x402D75C")]
	[FieldOffset(Offset = "0xD")]
	public static bool BRUMAHeadSlotsAsyncLoading;

	[Token(Token = "0x402D75D")]
	public const string StrAvatarAssetsDir = "umas/";

	[Token(Token = "0x402D75E")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int StrAvatarAssetsDirLength;

	[Token(Token = "0x402D75F")]
	public const bool SkipSlotOverlayesItemNames = true;

	[Token(Token = "0x402D760")]
	public const bool RenameInApkSlotOverlayFileToHashes = true;

	[Token(Token = "0x402D761")]
	[FieldOffset(Offset = "0x14")]
	public static bool UseSharedSbStrForSlotOverlayHashNames;

	[Token(Token = "0x402D762")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int SlotOverlayHashNameSbCap;

	[Token(Token = "0x402D763")]
	[FieldOffset(Offset = "0x1C")]
	public static bool UsingPreAsyncLoading;

	[Token(Token = "0x402D764")]
	[FieldOffset(Offset = "0x1D")]
	public static bool UsingPostAsyncLoading;

	[Token(Token = "0x402D765")]
	[FieldOffset(Offset = "0x1E")]
	public static bool BuildAfterWardrobeSlotsLoadedProtect;

	[Token(Token = "0x402D766")]
	public const int MaxAssetCountPerType = 65535;

	[Token(Token = "0x402D767")]
	public const int MaxSlotsPerRecipe = 15;

	[Token(Token = "0x402D768")]
	public const int MaxOverlaysPerSlot = 1;

	[Token(Token = "0x402D769")]
	public const int MaxAdditiveSlotsPerRecipe = 7;

	[Token(Token = "0x402D76A")]
	public const bool SaveAdditiveInfoInRecipeBytes = false;

	[Token(Token = "0x402D76B")]
	public const bool SortReplaceSlotToFront = true;

	[Token(Token = "0x402D76C")]
	public const bool SortReplaceSlotToTail = true;

	[Token(Token = "0x402D76D")]
	public const int EnumInvalidBits = 1;

	[Token(Token = "0x402D76E")]
	[FieldOffset(Offset = "0x1F")]
	public static bool EnableDecompressDataNoGC;

	[Token(Token = "0x402D76F")]
	[FieldOffset(Offset = "0x20")]
	public static bool UsingSetBoneWeights;

	[Token(Token = "0x402D770")]
	[FieldOffset(Offset = "0x21")]
	public static bool UsingBindPosesList;

	[Token(Token = "0x402D771")]
	[FieldOffset(Offset = "0x22")]
	public static bool UsingUnloadFromGfxDevice;

	[Token(Token = "0x402D772")]
	[FieldOffset(Offset = "0x28")]
	public static string[] RaceNames;

	[Token(Token = "0x402D773")]
	[FieldOffset(Offset = "0x30")]
	public static string[] RaceRecipes;

	[Token(Token = "0x402D774")]
	[FieldOffset(Offset = "0x38")]
	public static string[] BaseSlotNames;

	[Token(Token = "0x402D775")]
	[FieldOffset(Offset = "0x40")]
	public static string[] WardrobeSlotNames;

	[Token(Token = "0x1700297F")]
	public static bool UsingAsyncLoading
	{
		[MethodImpl(512)]
		[Token(Token = "0x6028FCA")]
		[Address(RVA = "0x4B14078", Offset = "0x4B14078", VA = "0x104B14078")]
		get
		{
			return default(bool);
		}
	}
}
