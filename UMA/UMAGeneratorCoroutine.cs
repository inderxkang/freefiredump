using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x200610F")]
public class UMAGeneratorCoroutine : WorkerCoroutine
{
	[Token(Token = "0x2006110")]
	public class MaterialDefinitionComparer : IComparer<UMAData.MaterialFragment>
	{
		[MethodImpl(768)]
		[Token(Token = "0x6029214")]
		[Address(RVA = "0x4B0C304", Offset = "0x4B0C304", VA = "0x104B0C304")]
		public MaterialDefinitionComparer()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029215")]
		[Address(RVA = "0x4B0C30C", Offset = "0x4B0C30C", VA = "0x104B0C30C", Slot = "4")]
		public int Compare(UMAData.MaterialFragment x, UMAData.MaterialFragment y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2006111")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x208C00", Offset = "0x208C00")]
	private sealed class _003CworkerMethod_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x402D976")]
		[FieldOffset(Offset = "0x10")]
		internal UMAGeneratorCoroutine _0024this;

		[Token(Token = "0x402D977")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x402D978")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x402D979")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17002991")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x6029218")]
			[Address(RVA = "0x4B0C278", Offset = "0x4B0C278", VA = "0x104B0C278", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17002992")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x6029219")]
			[Address(RVA = "0x4B0C280", Offset = "0x4B0C280", VA = "0x104B0C280", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(768)]
		[Token(Token = "0x6029216")]
		[Address(RVA = "0x4B0BD38", Offset = "0x4B0BD38", VA = "0x104B0BD38")]
		[DebuggerHidden]
		public _003CworkerMethod_003Ec__Iterator0()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029217")]
		[Address(RVA = "0x4B0BD40", Offset = "0x4B0BD40", VA = "0x104B0BD40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x602921A")]
		[Address(RVA = "0x4B0C288", Offset = "0x4B0C288", VA = "0x104B0C288", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x602921B")]
		[Address(RVA = "0x4B0C29C", Offset = "0x4B0C29C", VA = "0x104B0C29C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x402D967")]
	[FieldOffset(Offset = "0x38")]
	private TextureProcessBaseCoroutine textureProcessCoroutine;

	[Token(Token = "0x402D968")]
	[FieldOffset(Offset = "0x40")]
	private MaxRectsBinPack packTexture;

	[Token(Token = "0x402D969")]
	[FieldOffset(Offset = "0x48")]
	private UMAGeneratorBase umaGenerator;

	[Token(Token = "0x402D96A")]
	[FieldOffset(Offset = "0x50")]
	private UMAData umaData;

	[Token(Token = "0x402D96B")]
	[FieldOffset(Offset = "0x58")]
	private bool updateMaterialList;

	[Token(Token = "0x402D96C")]
	[FieldOffset(Offset = "0x5C")]
	private int scaleFactor;

	[Token(Token = "0x402D96D")]
	[FieldOffset(Offset = "0x60")]
	private MaterialDefinitionComparer comparer;

	[Token(Token = "0x402D96E")]
	[FieldOffset(Offset = "0x68")]
	private List<UMAData.GeneratedMaterial> generatedMaterials;

	[Token(Token = "0x402D96F")]
	[FieldOffset(Offset = "0x70")]
	private List<UMAData.GeneratedMaterial> atlassedMaterials;

	[Token(Token = "0x402D970")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<List<OverlayData>, UMAData.GeneratedMaterial> generatedMaterialLookup;

	[Token(Token = "0x402D971")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<int, List<Material>> recycledMaterials;

	[Token(Token = "0x402D972")]
	[FieldOffset(Offset = "0x88")]
	private List<UMAData.textureData> m_RecycledTextureData;

	[Token(Token = "0x402D973")]
	[FieldOffset(Offset = "0x90")]
	private List<UMAData.MaterialFragment> m_RecycledMaterialFragments;

	[Token(Token = "0x402D974")]
	[FieldOffset(Offset = "0x98")]
	private List<UMAData.GeneratedMaterial> m_RecycledGeneratedMaterials;

	[Token(Token = "0x402D975")]
	[FieldOffset(Offset = "0xA0")]
	private List<UMAData.GeneratedMaterial> m_RecycledGeneratedMaterialsList;

	[MethodImpl(768)]
	[Token(Token = "0x6029204")]
	[Address(RVA = "0x4B07BC8", Offset = "0x4B07BC8", VA = "0x104B07BC8")]
	public UMAGeneratorCoroutine()
	{
	}

	[Token(Token = "0x6029205")]
	private static T GetOrCreate<T>(List<T> list) where T : new()
	{
		return (T)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029206")]
	[Address(RVA = "0x4B08AE0", Offset = "0x4B08AE0", VA = "0x104B08AE0", Slot = "7")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6029207")]
	[Address(RVA = "0x4B05204", Offset = "0x4B05204", VA = "0x104B05204")]
	public void Prepare(UMAGeneratorBase _umaGenerator, UMAData _umaData, TextureProcessBaseCoroutine textureProcessCoroutine, Dictionary<int, List<Material>> recycledMaterials, bool updateMaterialList, int InitialScaleFactor)
	{
	}

	[Token(Token = "0x6029208")]
	[Address(RVA = "0x4B08B80", Offset = "0x4B08B80", VA = "0x104B08B80")]
	private UMAData.GeneratedMaterial FindOrCreateGeneratedMaterial(UMAMaterial umaMaterial, bool noMerge)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029209")]
	[Address(RVA = "0x4B08F50", Offset = "0x4B08F50", VA = "0x104B08F50", Slot = "4")]
	protected override void Start()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602920A")]
	[Address(RVA = "0x4B0A898", Offset = "0x4B0A898", VA = "0x104B0A898", Slot = "5")]
	[DebuggerHidden]
	protected override IEnumerator workerMethod()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x602920B")]
	[Address(RVA = "0x4B0A908", Offset = "0x4B0A908", VA = "0x104B0A908", Slot = "6")]
	protected override void Stop()
	{
	}

	[Token(Token = "0x602920C")]
	[Address(RVA = "0x4B0A90C", Offset = "0x4B0A90C", VA = "0x104B0A90C")]
	private void GenerateAtlasData()
	{
	}

	[Token(Token = "0x602920D")]
	[Address(RVA = "0x4B0AF44", Offset = "0x4B0AF44", VA = "0x104B0AF44")]
	private void UpdateSharedRect(UMAData.GeneratedMaterial generatedMaterial)
	{
	}

	[Token(Token = "0x602920E")]
	[Address(RVA = "0x4B0AAFC", Offset = "0x4B0AAFC", VA = "0x104B0AAFC")]
	private bool CalculateRects(UMAData.GeneratedMaterial material)
	{
		return default(bool);
	}

	[Token(Token = "0x602920F")]
	[Address(RVA = "0x4B0B030", Offset = "0x4B0B030", VA = "0x104B0B030")]
	private void OptimizeAtlas()
	{
	}

	[Token(Token = "0x6029210")]
	[Address(RVA = "0x4B0B550", Offset = "0x4B0B550", VA = "0x104B0B550")]
	private void UpdateUV()
	{
	}

	[Token(Token = "0x6029211")]
	[Address(RVA = "0x4B0A4A0", Offset = "0x4B0A4A0", VA = "0x104B0A4A0")]
	private void ApplyMaskColors(UMAData.MaterialFragment matFragment)
	{
	}

	[Token(Token = "0x6029212")]
	[Address(RVA = "0x4B0B7E4", Offset = "0x4B0B7E4", VA = "0x104B0B7E4")]
	private void RecyckeGeneratedMaterialsList(List<UMAData.GeneratedMaterial> list)
	{
	}

	[Token(Token = "0x6029213")]
	private static void RemoveTailRange<T>(List<T> list, int maxSize)
	{
	}
}
