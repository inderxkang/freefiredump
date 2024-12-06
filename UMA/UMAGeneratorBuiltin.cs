using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200610C")]
public abstract class UMAGeneratorBuiltin : UMAGeneratorBase
{
	[Token(Token = "0x200610D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x208BE0", Offset = "0x208BE0")]
	private sealed class _003CRemoveFromCleanList_003Ec__AnonStorey1
	{
		[Token(Token = "0x402D955")]
		[FieldOffset(Offset = "0x10")]
		internal UMAData data;

		[MethodImpl(768)]
		[Token(Token = "0x60291FB")]
		[Address(RVA = "0x4B034E4", Offset = "0x4B034E4", VA = "0x104B034E4")]
		public _003CRemoveFromCleanList_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60291FC")]
		[Address(RVA = "0x4B07D24", Offset = "0x4B07D24", VA = "0x104B07D24")]
		internal bool _003C_003Em__0(UMAData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200610E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x208BF0", Offset = "0x208BF0")]
	private sealed class _003CSetupFluxFramebyFrame_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x402D956")]
		[FieldOffset(Offset = "0x10")]
		internal UMAData data;

		[Token(Token = "0x402D957")]
		[FieldOffset(Offset = "0x18")]
		internal HangManager _003ChanTemp_003E__1;

		[Token(Token = "0x402D958")]
		[FieldOffset(Offset = "0x20")]
		internal bool _003ChasFlux_003E__1;

		[Token(Token = "0x402D959")]
		[FieldOffset(Offset = "0x28")]
		internal List<GameObject> _003CgameObjects_003E__1;

		[Token(Token = "0x402D95A")]
		[FieldOffset(Offset = "0x30")]
		internal int _003CCount_003E__1;

		[Token(Token = "0x402D95B")]
		[FieldOffset(Offset = "0x34")]
		internal int _003Ci_003E__2;

		[Token(Token = "0x402D95C")]
		[FieldOffset(Offset = "0x38")]
		internal SlotData _003CslotData_003E__3;

		[Token(Token = "0x402D95D")]
		[FieldOffset(Offset = "0x40")]
		internal SlotDataAsset _003CslotDataAsset_003E__3;

		[Token(Token = "0x402D95E")]
		[FieldOffset(Offset = "0x48")]
		internal List<HangStringProperty> _003Cfluxassets_003E__3;

		[Token(Token = "0x402D95F")]
		[FieldOffset(Offset = "0x50")]
		internal int _003Cj_003E__4;

		[Token(Token = "0x402D960")]
		[FieldOffset(Offset = "0x58")]
		internal HangStringProperty _003Cproperty_003E__5;

		[Token(Token = "0x402D961")]
		[FieldOffset(Offset = "0x60")]
		internal GameObject _003Cobj_003E__6;

		[Token(Token = "0x402D962")]
		[FieldOffset(Offset = "0x68")]
		internal HangString _003Chang_003E__6;

		[Token(Token = "0x402D963")]
		[FieldOffset(Offset = "0x70")]
		internal UMAGeneratorBuiltin _0024this;

		[Token(Token = "0x402D964")]
		[FieldOffset(Offset = "0x78")]
		internal object _0024current;

		[Token(Token = "0x402D965")]
		[FieldOffset(Offset = "0x80")]
		internal bool _0024disposing;

		[Token(Token = "0x402D966")]
		[FieldOffset(Offset = "0x84")]
		internal int _0024PC;

		[Token(Token = "0x1700298F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x60291FF")]
			[Address(RVA = "0x4B08A44", Offset = "0x4B08A44", VA = "0x104B08A44", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17002990")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x6029200")]
			[Address(RVA = "0x4B08A4C", Offset = "0x4B08A4C", VA = "0x104B08A4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(768)]
		[Token(Token = "0x60291FD")]
		[Address(RVA = "0x4B07390", Offset = "0x4B07390", VA = "0x104B07390")]
		[DebuggerHidden]
		public _003CSetupFluxFramebyFrame_003Ec__Iterator0()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60291FE")]
		[Address(RVA = "0x4B07DA0", Offset = "0x4B07DA0", VA = "0x104B07DA0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029201")]
		[Address(RVA = "0x4B08A54", Offset = "0x4B08A54", VA = "0x104B08A54", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029202")]
		[Address(RVA = "0x4B08A78", Offset = "0x4B08A78", VA = "0x104B08A78", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6029203")]
		[Address(RVA = "0x4B089D8", Offset = "0x4B089D8", VA = "0x104B089D8")]
		private void _003C_003E__Finally0()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x402D931")]
	[FieldOffset(Offset = "0x30")]
	protected UMAData umaData;

	[NonSerialized]
	[Token(Token = "0x402D932")]
	[FieldOffset(Offset = "0x38")]
	protected List<UMAData> umaDirtyList;

	[Token(Token = "0x402D933")]
	[FieldOffset(Offset = "0x40")]
	private LinkedList<UMAData> cleanUmas;

	[Token(Token = "0x402D934")]
	[FieldOffset(Offset = "0x48")]
	private LinkedList<UMAData> dirtyUmas;

	[Token(Token = "0x402D935")]
	[FieldOffset(Offset = "0x50")]
	private UMAGeneratorCoroutine activeGeneratorCoroutine;

	[Token(Token = "0x402D936")]
	[FieldOffset(Offset = "0x58")]
	private UMAGeneratorCoroutine reusedGeneratorCoroutine;

	[Token(Token = "0x402D937")]
	[FieldOffset(Offset = "0x60")]
	public Transform textureMergePrefab;

	[Token(Token = "0x402D938")]
	[FieldOffset(Offset = "0x68")]
	public UMAMeshCombiner meshCombiner;

	[Token(Token = "0x402D939")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<string, Transform> tmpTransforms;

	[Token(Token = "0x402D93A")]
	[FieldOffset(Offset = "0x0")]
	public static bool EnableFixWorkSyncRemoveData;

	[Token(Token = "0x402D93B")]
	[FieldOffset(Offset = "0x1")]
	public static bool OptGc;

	[Token(Token = "0x402D93C")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2D3538", Offset = "0x2D3538")]
	public int InitialScaleFactor;

	[Token(Token = "0x402D93D")]
	[FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2D3570", Offset = "0x2D3570")]
	public bool fastGeneration;

	[Token(Token = "0x402D93E")]
	[FieldOffset(Offset = "0x2")]
	public static bool EnableGC;

	[Token(Token = "0x402D93F")]
	[FieldOffset(Offset = "0x80")]
	private int forceGarbageCollect;

	[Token(Token = "0x402D940")]
	[FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2D35A8", Offset = "0x2D35A8")]
	public int garbageCollectionRate;

	[Token(Token = "0x402D941")]
	[FieldOffset(Offset = "0x88")]
	private int garbageCollectionRateNew;

	[Token(Token = "0x402D942")]
	[FieldOffset(Offset = "0x90")]
	private Stopwatch stopWatch;

	[Token(Token = "0x402D943")]
	[FieldOffset(Offset = "0x4")]
	public static int lastExceptionFrame;

	[Token(Token = "0x402D944")]
	[FieldOffset(Offset = "0x8")]
	public static int logExceptionInterval;

	[NonSerialized]
	[Token(Token = "0x402D945")]
	[FieldOffset(Offset = "0x98")]
	public long ElapsedTicks;

	[NonSerialized]
	[Token(Token = "0x402D946")]
	[FieldOffset(Offset = "0xA0")]
	public long DnaChanged;

	[NonSerialized]
	[Token(Token = "0x402D947")]
	[FieldOffset(Offset = "0xA8")]
	public long TextureChanged;

	[NonSerialized]
	[Token(Token = "0x402D948")]
	[FieldOffset(Offset = "0xB0")]
	public long SlotsChanged;

	[NonSerialized]
	[Token(Token = "0x402D949")]
	[FieldOffset(Offset = "0xB8")]
	public bool ReuseDynamicBone;

	[NonSerialized]
	[Token(Token = "0x402D94A")]
	[FieldOffset(Offset = "0xB9")]
	private bool ReuseMaterial;

	[Token(Token = "0x402D94B")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, List<Material>> recycledMaterials;

	[Token(Token = "0x402D94C")]
	[FieldOffset(Offset = "0xC8")]
	private List<UMAMaterial> recyclingUmaMaterials;

	[Token(Token = "0x402D94D")]
	[FieldOffset(Offset = "0xD0")]
	private List<Material> recyclingMaterials;

	[Token(Token = "0x402D94E")]
	private const int RecycleMaterialMaxCntEach = 5;

	[Token(Token = "0x402D94F")]
	[FieldOffset(Offset = "0xD8")]
	private List<DynamicBone> dbBones;

	[Token(Token = "0x402D950")]
	[FieldOffset(Offset = "0xE0")]
	private List<HangCollider> hangColliders;

	[Token(Token = "0x402D951")]
	[FieldOffset(Offset = "0xE8")]
	private List<HangPivot> hangPivots;

	[Token(Token = "0x402D952")]
	[FieldOffset(Offset = "0xC")]
	private static bool s_SetupFluxCoroutineFinish;

	[Token(Token = "0x402D953")]
	[FieldOffset(Offset = "0xF0")]
	private WaitUntil waitUntilFluxSetupEnd;

	[Token(Token = "0x402D954")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2D35E0", Offset = "0x2D35E0")]
	private static Func<bool> _003C_003Ef__am_0024cache0;

	[MethodImpl(768)]
	[Token(Token = "0x60291D6")]
	[Address(RVA = "0x4B03284", Offset = "0x4B03284", VA = "0x104B03284")]
	protected UMAGeneratorBuiltin()
	{
	}

	[Token(Token = "0x60291D7")]
	[Address(RVA = "0x4AFB2C8", Offset = "0x4AFB2C8", VA = "0x104AFB2C8")]
	public void RemoveFromCleanList(UMAData data)
	{
	}

	[Token(Token = "0x60291D8")]
	[Address(RVA = "0x4B034EC", Offset = "0x4B034EC", VA = "0x104B034EC")]
	public int GetInitialScaleFactor(UMAData data)
	{
		return default(int);
	}

	[MethodImpl(1280)]
	[Token(Token = "0x60291D9")]
	[Address(RVA = "0x4B03520", Offset = "0x4B03520", VA = "0x104B03520", Slot = "12")]
	public virtual void OnEnable()
	{
	}

	[MethodImpl(1280)]
	[Token(Token = "0x60291DA")]
	[Address(RVA = "0x4B035C8", Offset = "0x4B035C8", VA = "0x104B035C8", Slot = "13")]
	public virtual void Awake()
	{
	}

	[MethodImpl(1280)]
	[Token(Token = "0x60291DB")]
	[Address(RVA = "0x4B0382C", Offset = "0x4B0382C", VA = "0x104B0382C", Slot = "10")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60291DC")]
	[Address(RVA = "0x4B03B58", Offset = "0x4B03B58", VA = "0x104B03B58")]
	public void SetGarbageCollectionRateNew(int rate, bool clearcount = false)
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x60291DD")]
	[Address(RVA = "0x4B03B68", Offset = "0x4B03B68", VA = "0x104B03B68")]
	private void Update()
	{
	}

	[Token(Token = "0x60291DE")]
	[Address(RVA = "0x4B03CF8", Offset = "0x4B03CF8", VA = "0x104B03CF8")]
	public void EnableReuseMaterial()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291DF")]
	[Address(RVA = "0x4B03DB8", Offset = "0x4B03DB8", VA = "0x104B03DB8", Slot = "8")]
	public override void WorkSync(UMAData umaData)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291E0")]
	[Address(RVA = "0x4B040B8", Offset = "0x4B040B8", VA = "0x104B040B8", Slot = "9")]
	public override void RemoveData(UMAData data)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291E1")]
	[Address(RVA = "0x4B04208", Offset = "0x4B04208", VA = "0x104B04208", Slot = "7")]
	public override void Work()
	{
	}

	[Token(Token = "0x60291E2")]
	[Address(RVA = "0x4B04308", Offset = "0x4B04308", VA = "0x104B04308")]
	private TextureProcessBaseCoroutine CreateAndPrepareTextureProcess(UMAData data)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291E3")]
	[Address(RVA = "0x4B043AC", Offset = "0x4B043AC", VA = "0x104B043AC", Slot = "14")]
	public virtual bool HandleDirtyUpdate(UMAData data, bool fastGen)
	{
		return default(bool);
	}

	[Token(Token = "0x60291E4")]
	[Address(RVA = "0x4B04938", Offset = "0x4B04938", VA = "0x104B04938")]
	private void PrepareGeneratedMaterialsToRecycle(UMAData umaData)
	{
	}

	[Token(Token = "0x60291E5")]
	[Address(RVA = "0x4B04CC0", Offset = "0x4B04CC0", VA = "0x104B04CC0")]
	private void RecycleGeneratedMaterials(SkinnedMeshRenderer renderer)
	{
	}

	[Token(Token = "0x60291E6")]
	[Address(RVA = "0x4B0533C", Offset = "0x4B0533C", VA = "0x104B0533C")]
	protected void SetupDynamicBones(bool bforceDyanamic)
	{
	}

	[Token(Token = "0x60291E7")]
	[Address(RVA = "0x4B06B38", Offset = "0x4B06B38", VA = "0x104B06B38")]
	private void InitFlux(Transform root, out GameObject Hang, out HangManager hangManager)
	{
	}

	[Token(Token = "0x60291E8")]
	[Address(RVA = "0x4B06D4C", Offset = "0x4B06D4C", VA = "0x104B06D4C")]
	private void ClearFluxRes(GameObject root)
	{
	}

	[Token(Token = "0x60291E9")]
	[Address(RVA = "0x4B05BC8", Offset = "0x4B05BC8", VA = "0x104B05BC8")]
	protected void SetupFlux(UMAData data)
	{
	}

	[Token(Token = "0x60291EA")]
	[Address(RVA = "0x4B05B48", Offset = "0x4B05B48", VA = "0x104B05B48")]
	[DebuggerHidden]
	protected IEnumerator SetupFluxFramebyFrame(UMAData data)
	{
		return null;
	}

	[Token(Token = "0x60291EB")]
	[Address(RVA = "0x4B064C0", Offset = "0x4B064C0", VA = "0x104B064C0")]
	private DynamicBone GetAndRemoveDynamicBone(List<DynamicBone> list, GameObject go, bool net)
	{
		return null;
	}

	[Token(Token = "0x60291EC")]
	[Address(RVA = "0x4B06660", Offset = "0x4B06660", VA = "0x104B06660")]
	protected void FilterDynamicBone(Transform tr, List<Transform> validDynamicBones)
	{
	}

	[Token(Token = "0x60291ED")]
	[Address(RVA = "0x4B067F4", Offset = "0x4B067F4", VA = "0x104B067F4")]
	protected void AddColliderForDynamicBone(DynamicBone db, UMADynamicBoneColliderProperties[] dbcps)
	{
	}

	[Token(Token = "0x60291EE")]
	[Address(RVA = "0x4B0616C", Offset = "0x4B0616C", VA = "0x104B0616C")]
	private Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	[Token(Token = "0x60291EF")]
	[Address(RVA = "0x4B07398", Offset = "0x4B07398", VA = "0x104B07398")]
	private void RemoveDirty()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F0")]
	[Address(RVA = "0x4B07490", Offset = "0x4B07490", VA = "0x104B07490", Slot = "15")]
	public virtual void OnDirtyUpdate()
	{
	}

	[Token(Token = "0x60291F1")]
	[Address(RVA = "0x4B0521C", Offset = "0x4B0521C", VA = "0x104B0521C")]
	private void UpdateUMAMesh(bool updatedAtlas)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F2")]
	[Address(RVA = "0x4B076BC", Offset = "0x4B076BC", VA = "0x104B076BC", Slot = "4")]
	public override void addDirtyUMA(UMAData umaToAdd)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F3")]
	[Address(RVA = "0x4B0789C", Offset = "0x4B0789C", VA = "0x104B0789C", Slot = "5")]
	public override bool IsIdle()
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F4")]
	[Address(RVA = "0x4B07908", Offset = "0x4B07908", VA = "0x104B07908", Slot = "6")]
	public override int QueueSize()
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F5")]
	[Address(RVA = "0x4B07968", Offset = "0x4B07968", VA = "0x104B07968", Slot = "16")]
	public virtual bool UMAReady()
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291F6")]
	[Address(RVA = "0x4B07A00", Offset = "0x4B07A00", VA = "0x104B07A00", Slot = "17")]
	public virtual void UpdateUMABody(UMAData umaData)
	{
	}

	[Token(Token = "0x60291F7")]
	[Address(RVA = "0x4B05150", Offset = "0x4B05150", VA = "0x104B05150")]
	private void InitGeneratorCoroutine()
	{
	}

	[Token(Token = "0x60291F8")]
	[Address(RVA = "0x4B03524", Offset = "0x4B03524", VA = "0x104B03524")]
	private void ResetGeneratorCoroutine()
	{
	}

	[Token(Token = "0x60291FA")]
	[Address(RVA = "0x4B07CBC", Offset = "0x4B07CBC", VA = "0x104B07CBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3187F8", Offset = "0x3187F8")]
	private static bool _003CwaitUntilFluxSetupEnd_003Em__0()
	{
		return default(bool);
	}
}
