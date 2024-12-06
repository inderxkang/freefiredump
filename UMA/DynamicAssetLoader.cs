using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200607C")]
public class DynamicAssetLoader : MonoBehaviour
{
	[Token(Token = "0x402D5A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DynamicAssetLoader _instance;

	[Token(Token = "0x402D5A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool isInitialized;

	[Token(Token = "0x402D5A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2D2B34", Offset = "0x2D2B34")]
	public RaceData placeholderRace;

	[Token(Token = "0x402D5A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UMATextRecipe placeholderWardrobeRecipe;

	[Token(Token = "0x402D5A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SlotDataAsset placeholderSlot;

	[Token(Token = "0x402D5A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OverlayDataAsset placeholderOverlay;

	[Token(Token = "0x402D5A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool debugOnFail;

	[Token(Token = "0x1700294D")]
	public static DynamicAssetLoader Instance
	{
		[MethodImpl(512)]
		[Token(Token = "0x6028D25")]
		[Address(RVA = "0x4AC611C", Offset = "0x4AC611C", VA = "0x104AC611C")]
		get
		{
			return null;
		}
		[MethodImpl(512)]
		[Token(Token = "0x6028D26")]
		[Address(RVA = "0x4AC6304", Offset = "0x4AC6304", VA = "0x104AC6304")]
		set
		{
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6028D24")]
	[Address(RVA = "0x4AC610C", Offset = "0x4AC610C", VA = "0x104AC610C")]
	public DynamicAssetLoader()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x6028D27")]
	[Address(RVA = "0x4AC6358", Offset = "0x4AC6358", VA = "0x104AC6358")]
	private void Awake()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x6028D28")]
	[Address(RVA = "0x4AC64A4", Offset = "0x4AC64A4", VA = "0x104AC64A4")]
	private void Start()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x6028D29")]
	[Address(RVA = "0x4AC64B4", Offset = "0x4AC64B4", VA = "0x104AC64B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6028D2A")]
	[Address(RVA = "0x4AC6398", Offset = "0x4AC6398", VA = "0x104AC6398")]
	private void StartCO()
	{
	}

	[Token(Token = "0x6028D2B")]
	[Address(RVA = "0x4AC61BC", Offset = "0x4AC61BC", VA = "0x104AC61BC")]
	public static DynamicAssetLoader FindInstance()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028D2C")]
	public virtual bool AddAssets<T>(ref Dictionary<string, List<string>> assetBundlesUsedDict, bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", [Optional] int? assetNameHash, string assetName = "", [Optional] Action<T[]> callback, bool forceDownloadAll = false) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Token(Token = "0x6028D2D")]
	public bool AddAssets<T>(bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", [Optional] int? assetNameHash, string assetName = "", [Optional] Action<T[]> callback, bool forceDownloadAll = false) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Token(Token = "0x6028D2E")]
	public bool AddAssetsFromResourcesIndex<T>(ref List<T> assetsToReturn, string[] resourcesFolderPathArray, [Optional] int? assetNameHash, string assetName = "") where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Token(Token = "0x6028D2F")]
	[Address(RVA = "0x4AC6550", Offset = "0x4AC6550", VA = "0x104AC6550")]
	private string[] SearchStringToArray(string searchString = "")
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028D30")]
	[Address(RVA = "0x4AC6774", Offset = "0x4AC6774", VA = "0x104AC6774", Slot = "5")]
	public virtual void AddWardrobeRecipes(Action<UMAWardrobeRecipe[]> callback)
	{
	}
}
