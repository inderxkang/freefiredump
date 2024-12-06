using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060F2")]
public class TextureProcessPROCoroutine : TextureProcessBaseCoroutine
{
	[Token(Token = "0x20060F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x208BD0", Offset = "0x208BD0")]
	private sealed class _003CworkerMethod_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x402D83C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _003CsharedTexExist_003E__0;

		[Token(Token = "0x402D83D")]
		[FieldOffset(Offset = "0x18")]
		internal TextureMerge _003CtextureMerge_003E__0;

		[Token(Token = "0x402D83E")]
		[FieldOffset(Offset = "0x20")]
		internal int _003CatlasIndex_003E__1;

		[Token(Token = "0x402D83F")]
		[FieldOffset(Offset = "0x28")]
		internal UMAData.GeneratedMaterial _003Catlas_003E__2;

		[Token(Token = "0x402D840")]
		[FieldOffset(Offset = "0x30")]
		internal UMAData.MaterialFragment _003CfirstFragment_003E__2;

		[Token(Token = "0x402D841")]
		[FieldOffset(Offset = "0x38")]
		internal SlotData _003CslotData_003E__2;

		[Token(Token = "0x402D842")]
		[FieldOffset(Offset = "0x40")]
		internal int _003CmoduleCount_003E__2;

		[Token(Token = "0x402D843")]
		[FieldOffset(Offset = "0x44")]
		internal bool _003CusingRGB565_003E__2;

		[Token(Token = "0x402D844")]
		[FieldOffset(Offset = "0x48")]
		internal int _003CtextureType_003E__3;

		[Token(Token = "0x402D845")]
		[FieldOffset(Offset = "0x4C")]
		internal UMAMaterial.ChannelType _003CchannelType_003E__4;

		[Token(Token = "0x402D846")]
		[FieldOffset(Offset = "0x50")]
		internal bool _003Cmerge_003E__4;

		[Token(Token = "0x402D847")]
		[FieldOffset(Offset = "0x58")]
		internal List<OverlayData> _003CoverlayList_003E__4;

		[Token(Token = "0x402D848")]
		[FieldOffset(Offset = "0x60")]
		internal bool _003CisSkin_003E__4;

		[Token(Token = "0x402D849")]
		[FieldOffset(Offset = "0x64")]
		internal int _003Cwidth_003E__5;

		[Token(Token = "0x402D84A")]
		[FieldOffset(Offset = "0x68")]
		internal int _003Cheight_003E__5;

		[Token(Token = "0x402D84B")]
		[FieldOffset(Offset = "0x6C")]
		internal bool _003CenableMipMap_003E__5;

		[Token(Token = "0x402D84C")]
		[FieldOffset(Offset = "0x70")]
		internal float _003CnormalSpecTexScale_003E__5;

		[Token(Token = "0x402D84D")]
		[FieldOffset(Offset = "0x74")]
		internal float _003CtexWidthF_003E__5;

		[Token(Token = "0x402D84E")]
		[FieldOffset(Offset = "0x78")]
		internal float _003CtexHeightF_003E__5;

		[Token(Token = "0x402D84F")]
		[FieldOffset(Offset = "0x7C")]
		internal int _003CtexWidth_003E__5;

		[Token(Token = "0x402D850")]
		[FieldOffset(Offset = "0x80")]
		internal int _003CtexHeight_003E__5;

		[Token(Token = "0x402D851")]
		[FieldOffset(Offset = "0x84")]
		internal RenderTextureFormat _003Cformat_003E__5;

		[Token(Token = "0x402D852")]
		[FieldOffset(Offset = "0x88")]
		internal Texture2D _003CtempTexture_003E__6;

		[Token(Token = "0x402D853")]
		[FieldOffset(Offset = "0x90")]
		internal int _003Cxblocks_003E__6;

		[Token(Token = "0x402D854")]
		[FieldOffset(Offset = "0x94")]
		internal int _003Cyblocks_003E__6;

		[Token(Token = "0x402D855")]
		[FieldOffset(Offset = "0x98")]
		internal int _003Cx_003E__7;

		[Token(Token = "0x402D856")]
		[FieldOffset(Offset = "0x9C")]
		internal int _003Cy_003E__8;

		[Token(Token = "0x402D857")]
		[FieldOffset(Offset = "0xA0")]
		internal int _003Cx_003E__9;

		[Token(Token = "0x402D858")]
		[FieldOffset(Offset = "0xA4")]
		internal int _003Cy_003E__10;

		[Token(Token = "0x402D859")]
		[FieldOffset(Offset = "0xA8")]
		internal TextureProcessPROCoroutine _0024this;

		[Token(Token = "0x402D85A")]
		[FieldOffset(Offset = "0xB0")]
		internal object _0024current;

		[Token(Token = "0x402D85B")]
		[FieldOffset(Offset = "0xB8")]
		internal bool _0024disposing;

		[Token(Token = "0x402D85C")]
		[FieldOffset(Offset = "0xBC")]
		internal int _0024PC;

		[Token(Token = "0x17002989")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x602910E")]
			[Address(RVA = "0x4AF6CD4", Offset = "0x4AF6CD4", VA = "0x104AF6CD4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700298A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[MethodImpl(768)]
			[Token(Token = "0x602910F")]
			[Address(RVA = "0x4AF6CDC", Offset = "0x4AF6CDC", VA = "0x104AF6CDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(768)]
		[Token(Token = "0x602910C")]
		[Address(RVA = "0x4AF3868", Offset = "0x4AF3868", VA = "0x104AF3868")]
		[DebuggerHidden]
		public _003CworkerMethod_003Ec__Iterator0()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x602910D")]
		[Address(RVA = "0x4AF38D8", Offset = "0x4AF38D8", VA = "0x104AF38D8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029110")]
		[Address(RVA = "0x4AF6CE4", Offset = "0x4AF6CE4", VA = "0x104AF6CE4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6029111")]
		[Address(RVA = "0x4AF6CF8", Offset = "0x4AF6CF8", VA = "0x104AF6CF8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x402D834")]
	[FieldOffset(Offset = "0x38")]
	private UMAData umaData;

	[Token(Token = "0x402D835")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture destinationTexture;

	[Token(Token = "0x402D836")]
	[FieldOffset(Offset = "0x48")]
	private Texture[] resultingTextures;

	[Token(Token = "0x402D837")]
	[FieldOffset(Offset = "0x50")]
	private UMAGeneratorBase umaGenerator;

	[Token(Token = "0x402D838")]
	[FieldOffset(Offset = "0x58")]
	private Camera renderCamera;

	[Token(Token = "0x402D839")]
	[FieldOffset(Offset = "0x60")]
	private RenderTextureDescriptor mTextureDescriptor;

	[Token(Token = "0x402D83A")]
	[FieldOffset(Offset = "0x8C")]
	private int _alphaMaskID;

	[Token(Token = "0x402D83B")]
	[FieldOffset(Offset = "0x90")]
	private int _colorEffectParamID;

	[Token(Token = "0x17002987")]
	private int alphaMaskID
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029105")]
		[Address(RVA = "0x4AF36DC", Offset = "0x4AF36DC", VA = "0x104AF36DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17002988")]
	private int colorEffectParamID
	{
		[MethodImpl(512)]
		[Token(Token = "0x6029106")]
		[Address(RVA = "0x4AF373C", Offset = "0x4AF373C", VA = "0x104AF373C")]
		get
		{
			return default(int);
		}
	}

	[MethodImpl(768)]
	[Token(Token = "0x6029104")]
	[Address(RVA = "0x4AF3674", Offset = "0x4AF3674", VA = "0x104AF3674")]
	public TextureProcessPROCoroutine()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029107")]
	[Address(RVA = "0x4AF379C", Offset = "0x4AF379C", VA = "0x104AF379C", Slot = "8")]
	public override void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029108")]
	[Address(RVA = "0x4AF37F4", Offset = "0x4AF37F4", VA = "0x104AF37F4", Slot = "4")]
	protected override void Start()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029109")]
	[Address(RVA = "0x4AF37F8", Offset = "0x4AF37F8", VA = "0x104AF37F8", Slot = "5")]
	[DebuggerHidden]
	protected override IEnumerator workerMethod()
	{
		return null;
	}

	[Token(Token = "0x602910A")]
	[Address(RVA = "0x4AF3870", Offset = "0x4AF3870", VA = "0x104AF3870")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x602910B")]
	[Address(RVA = "0x4AF38D4", Offset = "0x4AF38D4", VA = "0x104AF38D4", Slot = "6")]
	protected override void Stop()
	{
	}
}
