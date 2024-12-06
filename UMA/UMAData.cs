using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060FB")]
public class UMAData : MonoBehaviour
{
	[Token(Token = "0x20060FC")]
	public enum EffectType
	{
		[Token(Token = "0x402D8CE")]
		EFFECTTYPE_NONE,
		[Token(Token = "0x402D8CF")]
		EFFECTTYPE_GOD,
		[Token(Token = "0x402D8D0")]
		EFFECTTYPE_FROZEN,
		[Token(Token = "0x402D8D1")]
		EFFECTTYPE_FREESTYLE,
		[Token(Token = "0x402D8D2")]
		EFFECTTYPE_SNOWBALLFROZEN
	}

	[Token(Token = "0x20060FD")]
	public enum DynamicBoneType
	{
		[Token(Token = "0x402D8D4")]
		None,
		[Token(Token = "0x402D8D5")]
		DynamicBone,
		[Token(Token = "0x402D8D6")]
		Flux
	}

	[Token(Token = "0x20060FE")]
	public delegate void CharacterUpdatedDelgate(UMAData umaData);

	[Token(Token = "0x20060FF")]
	public delegate void CharacterBeginCreationDelgate(UMAData umaData);

	[Serializable]
	[Token(Token = "0x2006100")]
	public class GeneratedMaterials
	{
		[Token(Token = "0x402D8D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<GeneratedMaterial> materials;

		[Token(Token = "0x402D8D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<GeneratedMaterial> EmptyMaterials;

		[MethodImpl(768)]
		[Token(Token = "0x6029197")]
		[Address(RVA = "0x4AF8F44", Offset = "0x4AF8F44", VA = "0x104AF8F44")]
		public GeneratedMaterials()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2006101")]
	public class GeneratedMaterial
	{
		[Token(Token = "0x402D8D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UMAMaterial umaMaterial;

		[Token(Token = "0x402D8DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x402D8DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<MaterialFragment> materialFragments;

		[Token(Token = "0x402D8DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture[] resultingAtlasList;

		[Token(Token = "0x402D8DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 cropResolution;

		[Token(Token = "0x402D8DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float resolutionScale;

		[Token(Token = "0x402D8DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string[] textureNameList;

		[Token(Token = "0x402D8E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float normalHeightRatio;

		[Token(Token = "0x402D8E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float normalWidthRatio;

		[Token(Token = "0x402D8E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float textureHeightRatio;

		[Token(Token = "0x402D8E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float textureWidthRatio;

		[Token(Token = "0x402D8E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool noMerge;

		[MethodImpl(768)]
		[Token(Token = "0x6029199")]
		[Address(RVA = "0x4AFE584", Offset = "0x4AFE584", VA = "0x104AFE584")]
		public GeneratedMaterial()
		{
		}

		[Token(Token = "0x602919A")]
		[Address(RVA = "0x4AFE5F4", Offset = "0x4AFE5F4", VA = "0x104AFE5F4")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2006102")]
	public class MaterialFragment
	{
		[Token(Token = "0x402D8E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int size;

		[Token(Token = "0x402D8E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Color baseColor;

		[Token(Token = "0x402D8E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UMAMaterial umaMaterial;

		[Token(Token = "0x402D8E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rect[] rects;

		[Token(Token = "0x402D8E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public textureData[] overlays;

		[Token(Token = "0x402D8EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color32[] overlayColors;

		[Token(Token = "0x402D8EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color[][] channelMask;

		[Token(Token = "0x402D8EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color[][] channelAdditiveMask;

		[Token(Token = "0x402D8ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SlotData slotData;

		[Token(Token = "0x402D8EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OverlayData[] overlayData;

		[Token(Token = "0x402D8EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Rect atlasRegion;

		[Token(Token = "0x402D8F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isRectShared;

		[Token(Token = "0x402D8F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<OverlayData> overlayList;

		[Token(Token = "0x402D8F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public MaterialFragment rectFragment;

		[Token(Token = "0x402D8F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public textureData baseOverlay;

		[Token(Token = "0x402D8F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int width;

		[Token(Token = "0x402D8F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int height;

		[Token(Token = "0x402D8F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float channelTypeNormalWidthRatio;

		[Token(Token = "0x402D8F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float channelTypeNormalHeightRatio;

		[Token(Token = "0x402D8F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float channelTypeTextureWidthRatio;

		[Token(Token = "0x402D8F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float channelTypeTextureHeightRatio;

		[MethodImpl(768)]
		[Token(Token = "0x602919B")]
		[Address(RVA = "0x4AFE714", Offset = "0x4AFE714", VA = "0x104AFE714")]
		public MaterialFragment()
		{
		}

		[Token(Token = "0x602919C")]
		[Address(RVA = "0x4AF25C8", Offset = "0x4AF25C8", VA = "0x104AF25C8")]
		public Color GetMultiplier(int overlay, int textureType)
		{
			return default(Color);
		}

		[Token(Token = "0x602919D")]
		[Address(RVA = "0x4AF2458", Offset = "0x4AF2458", VA = "0x104AF2458")]
		public Color32 GetAdditive(int overlay, int textureType)
		{
			return default(Color32);
		}

		[Token(Token = "0x602919E")]
		[Address(RVA = "0x4AFE71C", Offset = "0x4AFE71C", VA = "0x104AFE71C")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2006103")]
	public class textureData
	{
		[Token(Token = "0x402D8FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture[] textureList;

		[Token(Token = "0x402D8FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture alphaTexture;

		[Token(Token = "0x402D8FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverlayDataAsset.OverlayType overlayType;

		[MethodImpl(768)]
		[Token(Token = "0x602919F")]
		[Address(RVA = "0x4AFF3D8", Offset = "0x4AFF3D8", VA = "0x104AFF3D8")]
		public textureData()
		{
		}

		[Token(Token = "0x60291A0")]
		[Address(RVA = "0x4AFF3E0", Offset = "0x4AFF3E0", VA = "0x104AFF3E0")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2006104")]
	public class UMARecipe
	{
		[Token(Token = "0x402D8FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaceData raceData;

		[Token(Token = "0x402D8FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, int> mergedSharedColors;

		[Token(Token = "0x402D8FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SlotData[] slotDataList;

		[Token(Token = "0x402D900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayColorData[] sharedColors;

		[MethodImpl(768)]
		[Token(Token = "0x60291A1")]
		[Address(RVA = "0x4AF9788", Offset = "0x4AF9788", VA = "0x104AF9788")]
		public UMARecipe()
		{
		}

		[Token(Token = "0x60291A2")]
		[Address(RVA = "0x4AF9970", Offset = "0x4AF9970", VA = "0x104AF9970")]
		public bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x60291A3")]
		[Address(RVA = "0x4AFE84C", Offset = "0x4AFE84C", VA = "0x104AFE84C")]
		public void SetRace(RaceData raceData)
		{
		}

		[Token(Token = "0x60291A4")]
		[Address(RVA = "0x4AFE854", Offset = "0x4AFE854", VA = "0x104AFE854")]
		public RaceData GetRace()
		{
			return null;
		}

		[Token(Token = "0x60291A5")]
		[Address(RVA = "0x4AFE85C", Offset = "0x4AFE85C", VA = "0x104AFE85C")]
		public void SetSlot(int index, SlotData slot)
		{
		}

		[Token(Token = "0x60291A6")]
		[Address(RVA = "0x4AFE958", Offset = "0x4AFE958", VA = "0x104AFE958")]
		public void SetSlots(SlotData[] slots)
		{
		}

		[Token(Token = "0x60291A7")]
		[Address(RVA = "0x4AFE960", Offset = "0x4AFE960", VA = "0x104AFE960")]
		public void MergeSlot(SlotData slot, bool dontSerialize)
		{
		}

		[Token(Token = "0x60291A8")]
		[Address(RVA = "0x4AFB8B8", Offset = "0x4AFB8B8", VA = "0x104AFB8B8")]
		public SlotData GetSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x60291A9")]
		[Address(RVA = "0x4AF81C8", Offset = "0x4AF81C8", VA = "0x104AF81C8")]
		public SlotData[] GetAllSlots()
		{
			return null;
		}

		[Token(Token = "0x60291AA")]
		[Address(RVA = "0x4AFB978", Offset = "0x4AFB978", VA = "0x104AFB978")]
		public int GetSlotArraySize()
		{
			return default(int);
		}

		[Token(Token = "0x60291AB")]
		[Address(RVA = "0x4AFF1DC", Offset = "0x4AFF1DC", VA = "0x104AFF1DC")]
		public static bool OverlayListsMatch(List<OverlayData> list1, List<OverlayData> list2)
		{
			return default(bool);
		}

		[Token(Token = "0x60291AC")]
		[Address(RVA = "0x4AFEFA8", Offset = "0x4AFEFA8", VA = "0x104AFEFA8")]
		public void MergeMatchingOverlays()
		{
		}

		[Token(Token = "0x60291AD")]
		[Address(RVA = "0x4AFF358", Offset = "0x4AFF358", VA = "0x104AFF358")]
		public UMARecipe Mirror()
		{
			return null;
		}

		[Token(Token = "0x60291AE")]
		[Address(RVA = "0x4AFC00C", Offset = "0x4AFC00C", VA = "0x104AFC00C")]
		public void Merge(UMARecipe recipe, bool dontSerialize)
		{
		}
	}

	[Token(Token = "0x402D883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool OptimizeMeshMemory;

	[Token(Token = "0x402D884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SkinnedMeshRenderer myRenderer;

	[NonSerialized]
	[Token(Token = "0x402D885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint avatarId;

	[NonSerialized]
	[Token(Token = "0x402D886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isSharedModel;

	[NonSerialized]
	[Token(Token = "0x402D887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool isUsingSharedTex;

	[NonSerialized]
	[Token(Token = "0x402D888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool isUsingSharedMesh;

	[NonSerialized]
	[Token(Token = "0x402D889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool firstBake;

	[Token(Token = "0x402D88A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UMAGeneratorBase umaGenerator;

	[NonSerialized]
	[Token(Token = "0x402D88B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GeneratedMaterials generatedMaterials;

	[Token(Token = "0x402D88C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedListNode<UMAData> listNode;

	[Token(Token = "0x402D88D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float atlasResolutionScale;

	[Token(Token = "0x402D88E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool atlasRelease;

	[Token(Token = "0x402D88F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool meshRelease;

	[Token(Token = "0x402D890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool isMeshDirty;

	[Token(Token = "0x402D891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	public bool isShapeDirty;

	[Token(Token = "0x402D892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isTextureDirty;

	[Token(Token = "0x402D893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool isAtlasDirty;

	[Token(Token = "0x402D894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool isLocalPlayer;

	[Token(Token = "0x402D895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	public bool isTeammate;

	[Token(Token = "0x402D896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool isCastShadow;

	[Token(Token = "0x402D897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool isHideHead;

	[Token(Token = "0x402D898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool noTextureMerge;

	[Token(Token = "0x402D899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool noClothTextureMerge;

	[Token(Token = "0x402D89A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool noSkinMergeWithCondition;

	[Token(Token = "0x402D89B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool updateTextureSizeByType;

	[NonSerialized]
	[Token(Token = "0x402D89C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public DynamicBoneType dynamicBoneType;

	[NonSerialized]
	[Token(Token = "0x402D89D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool dynamicBoneAnimatePhysicsMode;

	[Token(Token = "0x402D89E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ignoreBlendShapes;

	[Token(Token = "0x402D89F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool updateWhenOffsceen;

	[Token(Token = "0x402D8A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public EffectType effectType;

	[Token(Token = "0x402D8A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string m_OverrideShaderName;

	[Token(Token = "0x402D8A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private IPJMHLGGAIK m_OverrideMaterialPropertyInfo;

	[Token(Token = "0x402D8A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<int, IPJMHLGGAIK> m_DefaultMaterialPropertyInfo;

	[Token(Token = "0x402D8A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int? m_OverrideRenderQ;

	[Token(Token = "0x402D8A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Dictionary<int, int> m_DefaultRenderQ;

	[Token(Token = "0x402D8A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RuntimeAnimatorController animationController;

	[Token(Token = "0x402D8A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Dictionary<int, int> animatedBonesTable;

	[Token(Token = "0x402D8A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator mAnimator;

	[Token(Token = "0x402D8A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isThermalView;

	[Token(Token = "0x402D8AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool isPlanarShadow;

	[Token(Token = "0x402D8AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool isManuallyTickAnimator;

	[Token(Token = "0x402D8AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2D33E4", Offset = "0x2D33E4")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2D33E4", Offset = "0x2D33E4")]
	private bool _003Ccancelled_003Ek__BackingField;

	[NonSerialized]
	[Token(Token = "0x402D8AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool dirty;

	[NonSerialized]
	[Token(Token = "0x402D8AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool breakUpdate;

	[Token(Token = "0x402D8AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
	private bool isOfficiallyCreated;

	[Token(Token = "0x402D8B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CharacterUpdatedDelgate OnCharacterUpdatedFixed;

	[Token(Token = "0x402D8B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public CharacterBeginCreationDelgate OnCharacterBeginCreation;

	[Token(Token = "0x402D8B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UMADataEvent CharacterCreated;

	[Token(Token = "0x402D8B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public UMADataEvent CharacterDestroyed;

	[Token(Token = "0x402D8B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public UMADataEvent CharacterUpdated;

	[Token(Token = "0x402D8B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject umaRoot;

	[Token(Token = "0x402D8B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public UMARecipe umaRecipe;

	[Token(Token = "0x402D8B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Animator animator;

	[Token(Token = "0x402D8B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public UMASkeleton skeleton;

	[Token(Token = "0x402D8B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float characterHeight;

	[Token(Token = "0x402D8BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float characterRadius;

	[Token(Token = "0x402D8BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float characterMass;

	[Token(Token = "0x402D8BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool textureReady;

	[Token(Token = "0x402D8BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
	private bool meshReady;

	[Token(Token = "0x402D8BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
	public bool enableMipmap;

	[Token(Token = "0x402D8BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
	public bool usingRendertargetPool;

	[Token(Token = "0x402D8C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int textureScale;

	[Token(Token = "0x402D8C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float normalSpecTexScale;

	[Token(Token = "0x402D8C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool mIsPausedDuringGenerating;

	[Token(Token = "0x402D8C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool needGenerateMesh;

	[Token(Token = "0x402D8C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	public bool usingRGB565;

	[Token(Token = "0x402D8C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PauseFrameCount;

	[Token(Token = "0x402D8C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<Texture> backUpTexture;

	[Token(Token = "0x402D8C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Color[] maskColors;

	[Token(Token = "0x402D8C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Color[] maskAdditiveColors;

	[Token(Token = "0x402D8C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool m_Hide;

	[Token(Token = "0x402D8CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool m_releaseResource;

	[Token(Token = "0x402D8CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
	private bool m_HasPendingDirtyData;

	[Token(Token = "0x402D8CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int m_ColorEffectParamID;

	[Token(Token = "0x1700298E")]
	public bool cancelled
	{
		[MethodImpl(512)]
		[Token(Token = "0x602915A")]
		[Address(RVA = "0x4AF92F0", Offset = "0x4AF92F0", VA = "0x104AF92F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3187C8", Offset = "0x3187C8")]
		get
		{
			return default(bool);
		}
		[MethodImpl(512)]
		[Token(Token = "0x602915B")]
		[Address(RVA = "0x4AF92F8", Offset = "0x4AF92F8", VA = "0x104AF92F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3187D8", Offset = "0x3187D8")]
		private set
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action<UMAData> OnCharacterCreated
	{
		[MethodImpl(512)]
		[Token(Token = "0x602915C")]
		[Address(RVA = "0x4AF9300", Offset = "0x4AF9300", VA = "0x104AF9300")]
		add
		{
		}
		[MethodImpl(512)]
		[Token(Token = "0x602915D")]
		[Address(RVA = "0x4AF9414", Offset = "0x4AF9414", VA = "0x104AF9414")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action<UMAData> OnCharacterDestroyed
	{
		[MethodImpl(512)]
		[Token(Token = "0x602915E")]
		[Address(RVA = "0x4AF94B8", Offset = "0x4AF94B8", VA = "0x104AF94B8")]
		add
		{
		}
		[MethodImpl(512)]
		[Token(Token = "0x602915F")]
		[Address(RVA = "0x4AF957C", Offset = "0x4AF957C", VA = "0x104AF957C")]
		remove
		{
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029155")]
	[Address(RVA = "0x4AF8E70", Offset = "0x4AF8E70", VA = "0x104AF8E70")]
	public UMAData()
	{
	}

	[Token(Token = "0x6029156")]
	[Address(RVA = "0x4AF8FB4", Offset = "0x4AF8FB4", VA = "0x104AF8FB4")]
	public void MoveToList(LinkedList<UMAData> list)
	{
	}

	[Token(Token = "0x6029157")]
	[Address(RVA = "0x4AF9090", Offset = "0x4AF9090", VA = "0x104AF9090")]
	public void ResetAnimatedBones()
	{
	}

	[Token(Token = "0x6029158")]
	[Address(RVA = "0x4AF9118", Offset = "0x4AF9118", VA = "0x104AF9118")]
	public void RegisterAnimatedBone(int hash)
	{
	}

	[Token(Token = "0x6029159")]
	[Address(RVA = "0x4AF9204", Offset = "0x4AF9204", VA = "0x104AF9204")]
	public void RegisterAnimatedBoneHierarchy(int hash)
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x6029160")]
	[Address(RVA = "0x4AF9620", Offset = "0x4AF9620", VA = "0x104AF9620")]
	private void Awake()
	{
	}

	[Token(Token = "0x6029161")]
	[Address(RVA = "0x4AF96A4", Offset = "0x4AF96A4", VA = "0x104AF96A4")]
	private void EnsureGenerator()
	{
	}

	[Token(Token = "0x6029162")]
	[Address(RVA = "0x4AF97F8", Offset = "0x4AF97F8", VA = "0x104AF97F8")]
	public void SetupOnAwake()
	{
	}

	[Token(Token = "0x6029163")]
	[Address(RVA = "0x4AF986C", Offset = "0x4AF986C", VA = "0x104AF986C")]
	public bool Validate()
	{
		return default(bool);
	}

	[Token(Token = "0x6029164")]
	[Address(RVA = "0x4AF9B84", Offset = "0x4AF9B84", VA = "0x104AF9B84")]
	public bool UMAReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6029165")]
	[Address(RVA = "0x4AF9E68", Offset = "0x4AF9E68", VA = "0x104AF9E68")]
	public void FireUpdatedEvent(bool cancelled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029166")]
	[Address(RVA = "0x4AFA404", Offset = "0x4AFA404", VA = "0x104AFA404", Slot = "4")]
	public virtual void Dirty()
	{
	}

	[Token(Token = "0x6029167")]
	[Address(RVA = "0x4AFA41C", Offset = "0x4AFA41C", VA = "0x104AFA41C")]
	private void AddToDirtyUMA()
	{
	}

	[Token(Token = "0x6029168")]
	[Address(RVA = "0x4AFA4F0", Offset = "0x4AFA4F0", VA = "0x104AFA4F0")]
	public bool NeedGenerateCombinedMesh()
	{
		return default(bool);
	}

	[Token(Token = "0x6029169")]
	[Address(RVA = "0x4AFA58C", Offset = "0x4AFA58C", VA = "0x104AFA58C")]
	public bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x602916A")]
	[Address(RVA = "0x4AFA59C", Offset = "0x4AFA59C", VA = "0x104AFA59C")]
	public void VisibilitySwitch(bool v, bool releaseResource = false)
	{
	}

	[Token(Token = "0x602916B")]
	[Address(RVA = "0x4AFACC0", Offset = "0x4AFACC0", VA = "0x104AFACC0")]
	public void SetUMARendererActive(bool active)
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x602916C")]
	[Address(RVA = "0x4AFAD88", Offset = "0x4AFAD88", VA = "0x104AFAD88")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x602916D")]
	[Address(RVA = "0x4AFB490", Offset = "0x4AFB490", VA = "0x104AFB490")]
	public void ClearSlotOverlays()
	{
	}

	[Token(Token = "0x602916E")]
	[Address(RVA = "0x4AFB048", Offset = "0x4AFB048", VA = "0x104AFB048")]
	public void CleanAvatar()
	{
	}

	[Token(Token = "0x602916F")]
	[Address(RVA = "0x4AFB51C", Offset = "0x4AFB51C", VA = "0x104AFB51C")]
	public void CleanTextureSingle(Texture tempTexture)
	{
	}

	[Token(Token = "0x6029170")]
	[Address(RVA = "0x4AFAA18", Offset = "0x4AFAA18", VA = "0x104AFAA18")]
	public void CleanTextures()
	{
	}

	[Token(Token = "0x6029171")]
	[Address(RVA = "0x4AF8478", Offset = "0x4AF8478", VA = "0x104AF8478")]
	public void CleanMesh(bool destroyRenderer)
	{
	}

	[Token(Token = "0x6029172")]
	[Address(RVA = "0x4AFA7F0", Offset = "0x4AFA7F0", VA = "0x104AFA7F0")]
	public void ReleaseMesh()
	{
	}

	[Token(Token = "0x6029173")]
	[Address(RVA = "0x4AF7F5C", Offset = "0x4AF7F5C", VA = "0x104AF7F5C")]
	public void SetMaskColors(Color[] mask, Color[] additive)
	{
	}

	[Token(Token = "0x6029174")]
	[Address(RVA = "0x4AFB664", Offset = "0x4AFB664", VA = "0x104AFB664")]
	public void backUpTextures()
	{
	}

	[Token(Token = "0x6029175")]
	[Address(RVA = "0x4AFAF10", Offset = "0x4AFAF10", VA = "0x104AFAF10")]
	public void CleanBackUpTextures()
	{
	}

	[Token(Token = "0x6029176")]
	[Address(RVA = "0x4AF7274", Offset = "0x4AF7274", VA = "0x104AF7274")]
	public void Dirty(bool dnaDirty, bool textureDirty, bool meshDirty)
	{
	}

	[Token(Token = "0x6029177")]
	[Address(RVA = "0x4AFB884", Offset = "0x4AFB884", VA = "0x104AFB884")]
	public SlotData GetSlot(int index)
	{
		return null;
	}

	[Token(Token = "0x6029178")]
	[Address(RVA = "0x4AFB93C", Offset = "0x4AFB93C", VA = "0x104AFB93C")]
	public int GetSlotArraySize()
	{
		return default(int);
	}

	[Token(Token = "0x6029179")]
	[Address(RVA = "0x4AFB9A4", Offset = "0x4AFB9A4", VA = "0x104AFB9A4")]
	public void GotoTPose()
	{
	}

	[Token(Token = "0x602917A")]
	[Address(RVA = "0x4AFBCD4", Offset = "0x4AFBCD4", VA = "0x104AFBCD4")]
	public void FireCharacterBegunEvents()
	{
	}

	[Token(Token = "0x602917B")]
	[Address(RVA = "0x4AFA000", Offset = "0x4AFA000", VA = "0x104AFA000")]
	public void FireCharacterCompletedEvents()
	{
	}

	[Token(Token = "0x602917C")]
	[Address(RVA = "0x4AFBF48", Offset = "0x4AFBF48", VA = "0x104AFBF48")]
	public void AddAdditionalRecipes(UMARecipeBase[] umaAdditionalRecipes, UMAContext context)
	{
	}

	[Token(Token = "0x602917D")]
	[Address(RVA = "0x4AFC67C", Offset = "0x4AFC67C", VA = "0x104AFC67C")]
	public void SetMeshReady()
	{
	}

	[Token(Token = "0x602917E")]
	[Address(RVA = "0x4AFC690", Offset = "0x4AFC690", VA = "0x104AFC690")]
	public void SetTextureReady()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x602917F")]
	[Address(RVA = "0x4AFC6A0", Offset = "0x4AFC6A0", VA = "0x104AFC6A0")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6029180")]
	[Address(RVA = "0x4AFC7EC", Offset = "0x4AFC7EC", VA = "0x104AFC7EC")]
	public void SetAnimator(Animator amtr)
	{
	}

	[Token(Token = "0x6029181")]
	[Address(RVA = "0x4AFA004", Offset = "0x4AFA004", VA = "0x104AFA004")]
	public void UpdateRenderVisible(bool visible)
	{
	}

	[Token(Token = "0x6029182")]
	[Address(RVA = "0x4AF77C8", Offset = "0x4AF77C8", VA = "0x104AF77C8")]
	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	[Token(Token = "0x6029183")]
	[Address(RVA = "0x4AFC7F4", Offset = "0x4AFC7F4", VA = "0x104AFC7F4")]
	public void SwitchEffect(EffectType effect)
	{
	}

	[Token(Token = "0x6029184")]
	[Address(RVA = "0x4AFC934", Offset = "0x4AFC934", VA = "0x104AFC934")]
	public static void ChangeRenderEffect(SkinnedMeshRenderer renderer, EffectType effect)
	{
	}

	[Token(Token = "0x6029185")]
	[Address(RVA = "0x4AFCD60", Offset = "0x4AFCD60", VA = "0x104AFCD60")]
	public void SetAvatartColor(Color color)
	{
	}

	[Token(Token = "0x6029186")]
	[Address(RVA = "0x4AFCEEC", Offset = "0x4AFCEEC", VA = "0x104AFCEEC")]
	public bool GetMeshBounds(ref Bounds bound)
	{
		return default(bool);
	}

	[Token(Token = "0x6029187")]
	[Address(RVA = "0x4AF9D94", Offset = "0x4AF9D94", VA = "0x104AF9D94")]
	private void OverrideShaderAfterUMAReady()
	{
	}

	[Token(Token = "0x6029188")]
	[Address(RVA = "0x4AFCFB0", Offset = "0x4AFCFB0", VA = "0x104AFCFB0")]
	public void SetShader(string shaderPath, [Optional] IPJMHLGGAIK overrideProperty, bool force = false)
	{
	}

	[Token(Token = "0x6029189")]
	[Address(RVA = "0x4AFE448", Offset = "0x4AFE448", VA = "0x104AFE448")]
	public void RevertToDefaultShader()
	{
	}

	[Token(Token = "0x602918A")]
	[Address(RVA = "0x4AFDE04", Offset = "0x4AFDE04", VA = "0x104AFDE04")]
	public void RevertToDefaultShaderInternal(bool clearOverrideShaderInfo)
	{
	}

	[Token(Token = "0x602918B")]
	[Address(RVA = "0x4AFDA2C", Offset = "0x4AFDA2C", VA = "0x104AFDA2C")]
	public void SetRenderQ(int renderQ, bool force = false)
	{
	}

	[Token(Token = "0x602918C")]
	[Address(RVA = "0x4AFE450", Offset = "0x4AFE450", VA = "0x104AFE450")]
	public void RevertToDefaultRenderQ()
	{
	}

	[Token(Token = "0x602918D")]
	[Address(RVA = "0x4AFDC74", Offset = "0x4AFDC74", VA = "0x104AFDC74")]
	public void RevertToDefaultRenderQInternal(bool clearOverrideInfo)
	{
	}
}
