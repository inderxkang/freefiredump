using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060F5")]
public abstract class UMAAvatarBase : MonoBehaviour, IUmaAvatarBase
{
	[Token(Token = "0x402D85D")]
	[FieldOffset(Offset = "0x18")]
	public UMAContext context;

	[Token(Token = "0x402D85E")]
	[FieldOffset(Offset = "0x20")]
	public UMAData umaData;

	[Token(Token = "0x402D85F")]
	[FieldOffset(Offset = "0x28")]
	public UMARecipeBase umaRecipe;

	[Token(Token = "0x402D860")]
	[FieldOffset(Offset = "0x30")]
	public UMARecipeBase[] mUmaAdditionalRecipes;

	[Token(Token = "0x402D861")]
	[FieldOffset(Offset = "0x38")]
	public UMAGeneratorBase umaGenerator;

	[Token(Token = "0x402D862")]
	[FieldOffset(Offset = "0x40")]
	public RuntimeAnimatorController animationController;

	[Token(Token = "0x402D863")]
	[FieldOffset(Offset = "0x48")]
	protected RaceData umaRace;

	[Token(Token = "0x402D864")]
	[FieldOffset(Offset = "0x50")]
	public UMADataEvent CharacterCreated;

	[Token(Token = "0x402D865")]
	[FieldOffset(Offset = "0x58")]
	public UMADataEvent CharacterDestroyed;

	[Token(Token = "0x402D866")]
	[FieldOffset(Offset = "0x60")]
	public UMADataEvent CharacterUpdated;

	[Token(Token = "0x402D867")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x2D33AC", Offset = "0x2D33AC")]
	public bool rebuildSkeleton;

	[Token(Token = "0x402D868")]
	[FieldOffset(Offset = "0x0")]
	public static bool ReleaseDataOnRaceChange;

	[Token(Token = "0x402D869")]
	[FieldOffset(Offset = "0x70")]
	public string override1PSlotName;

	[Token(Token = "0x402D86A")]
	[FieldOffset(Offset = "0x78")]
	public UMAMaterial source1PMaterial;

	[Token(Token = "0x402D86B")]
	[FieldOffset(Offset = "0x80")]
	public UMAMaterial override1PMaterial;

	[Token(Token = "0x402D86C")]
	[FieldOffset(Offset = "0x88")]
	public bool m_IsForceChangeRace;

	[Token(Token = "0x402D86D")]
	[FieldOffset(Offset = "0x89")]
	protected bool m_UpdateWeaponFlag;

	[Token(Token = "0x1700298B")]
	public UMAData UmaData
	{
		[MethodImpl(768)]
		[Token(Token = "0x602911B")]
		[Address(RVA = "0x4AF7220", Offset = "0x4AF7220", VA = "0x104AF7220", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700298C")]
	public RaceData[] AvailableRaces
	{
		[MethodImpl(512)]
		[Token(Token = "0x602911F")]
		[Address(RVA = "0x4AF7424", Offset = "0x4AF7424", VA = "0x104AF7424")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700298D")]
	public OverlayColorData[] CurrentSharedColors
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029120")]
		[Address(RVA = "0x4AF7480", Offset = "0x4AF7480", VA = "0x104AF7480")]
		get
		{
			return null;
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029113")]
	[Address(RVA = "0x4AF6D60", Offset = "0x4AF6D60", VA = "0x104AF6D60")]
	protected UMAAvatarBase()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029114")]
	[Address(RVA = "0x4AF6D68", Offset = "0x4AF6D68", VA = "0x104AF6D68", Slot = "21")]
	public void SetForceChangeRace()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029115")]
	[Address(RVA = "0x4AF6D74", Offset = "0x4AF6D74", VA = "0x104AF6D74", Slot = "22")]
	public void SetUpdateWeaponFlag(bool flag)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029116")]
	[Address(RVA = "0x4AF6D78", Offset = "0x4AF6D78", VA = "0x104AF6D78", Slot = "23")]
	public bool GetUpdateWeaponFlag()
	{
		return default(bool);
	}

	[MethodImpl(1280)]
	[Token(Token = "0x6029117")]
	[Address(RVA = "0x4AF6D80", Offset = "0x4AF6D80", VA = "0x104AF6D80", Slot = "24")]
	public virtual void Awake()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029118")]
	[Address(RVA = "0x4AF6DC4", Offset = "0x4AF6DC4", VA = "0x104AF6DC4", Slot = "25")]
	public virtual void Initialize()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029119")]
	[Address(RVA = "0x4AF707C", Offset = "0x4AF707C", VA = "0x104AF707C", Slot = "26")]
	public virtual UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x602911A")]
	[Address(RVA = "0x4AF7218", Offset = "0x4AF7218", VA = "0x104AF7218", Slot = "4")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x602911C")]
	[Address(RVA = "0x4AF7228", Offset = "0x4AF7228", VA = "0x104AF7228", Slot = "27")]
	public void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false)
	{
	}

	[Token(Token = "0x602911D")]
	[Address(RVA = "0x4AF72F0", Offset = "0x4AF72F0", VA = "0x104AF72F0")]
	public void UpdateSameRace()
	{
	}

	[Token(Token = "0x602911E")]
	[Address(RVA = "0x4AF7328", Offset = "0x4AF7328", VA = "0x104AF7328")]
	public void UpdateNewRace()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029121")]
	[Address(RVA = "0x4AF74BC", Offset = "0x4AF74BC", VA = "0x104AF74BC", Slot = "6")]
	public void SetEnableMipMap(bool enableMipMap)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029122")]
	[Address(RVA = "0x4AF7554", Offset = "0x4AF7554", VA = "0x104AF7554", Slot = "7")]
	public void SetEnableRenderTexturePool(bool flag)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029123")]
	[Address(RVA = "0x4AF75EC", Offset = "0x4AF75EC", VA = "0x104AF75EC", Slot = "8")]
	public void SetTextureScaleFactor(int scale)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029124")]
	[Address(RVA = "0x4AF7684", Offset = "0x4AF7684", VA = "0x104AF7684", Slot = "9")]
	public void SetNormalSpecTexScale(float scale)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029125")]
	[Address(RVA = "0x4AF771C", Offset = "0x4AF771C", VA = "0x104AF771C", Slot = "10")]
	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029126")]
	[Address(RVA = "0x4AF787C", Offset = "0x4AF787C", VA = "0x104AF787C", Slot = "11")]
	public void SetNeedGenerateMesh(bool needMesh)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029127")]
	[Address(RVA = "0x4AF7914", Offset = "0x4AF7914", VA = "0x104AF7914", Slot = "12")]
	public void SetUsingRGB565(bool needMesh)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029128")]
	[Address(RVA = "0x4AF79AC", Offset = "0x4AF79AC", VA = "0x104AF79AC", Slot = "13")]
	public void SetAtlasResolutionScale(float scale)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029129")]
	[Address(RVA = "0x4AF7A44", Offset = "0x4AF7A44", VA = "0x104AF7A44", Slot = "14")]
	public void SetNoMergeTexture(bool noMerge)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602912A")]
	[Address(RVA = "0x4AF7ADC", Offset = "0x4AF7ADC", VA = "0x104AF7ADC", Slot = "15")]
	public void SetNoClothMergeTexture(bool noMerge)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602912B")]
	[Address(RVA = "0x4AF7B74", Offset = "0x4AF7B74", VA = "0x104AF7B74", Slot = "16")]
	public void SetNoSkinMergeWithCondition(bool noMerge)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602912C")]
	[Address(RVA = "0x4AF7C0C", Offset = "0x4AF7C0C", VA = "0x104AF7C0C", Slot = "17")]
	public void SetUpdateTextureSizeByChannelType(bool update)
	{
	}

	[Token(Token = "0x602912D")]
	[Address(RVA = "0x4AF7CA4", Offset = "0x4AF7CA4", VA = "0x104AF7CA4")]
	protected void SetBaseOverlayLimitSize(RaceData racedata)
	{
	}

	[Token(Token = "0x602912E")]
	[Address(RVA = "0x4AF7CF0", Offset = "0x4AF7CF0", VA = "0x104AF7CF0")]
	protected void SetOverlayLimitSize(int limitSize, UMAData.UMARecipe cachedRecipe, bool ignoreSkin = false)
	{
	}

	[Token(Token = "0x602912F")]
	[Address(RVA = "0x4AF7D90", Offset = "0x4AF7D90", VA = "0x104AF7D90")]
	public static void SetOverlayLimitSize(int limitSize, SlotData s, bool ignoreSkin = false)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029130")]
	[Address(RVA = "0x4AF7EE0", Offset = "0x4AF7EE0", VA = "0x104AF7EE0", Slot = "28")]
	public virtual void EnableDebugLog(bool enable)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029131")]
	[Address(RVA = "0x4AF7EE4", Offset = "0x4AF7EE4", VA = "0x104AF7EE4", Slot = "29")]
	public virtual void SetVisible(bool visible)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029132")]
	[Address(RVA = "0x4AF7EE8", Offset = "0x4AF7EE8", VA = "0x104AF7EE8", Slot = "30")]
	public void SetMaskColors(Color[] mask, Color[] additive, bool updateTexture = false)
	{
	}

	[Token(Token = "0x6029133")]
	[Address(RVA = "0x4AF7F64", Offset = "0x4AF7F64", VA = "0x104AF7F64")]
	protected void Override1PSlotMaterials()
	{
	}

	[Token(Token = "0x6029134")]
	[Address(RVA = "0x4AF81D0", Offset = "0x4AF81D0", VA = "0x104AF81D0")]
	protected void CleanMeshForRebuildSkeleton()
	{
	}

	[Token(Token = "0x6029135")]
	[Address(RVA = "0x4AF8660", Offset = "0x4AF8660", VA = "0x104AF8660")]
	protected void RemoveUGCHidenSlots()
	{
	}
}
