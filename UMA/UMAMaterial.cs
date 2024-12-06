using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006112")]
public class UMAMaterial : ScriptableObject
{
	[Token(Token = "0x2006113")]
	public enum MaskType
	{
		[Token(Token = "0x402D981")]
		None,
		[Token(Token = "0x402D982")]
		UseSkin,
		[Token(Token = "0x402D983")]
		ColorMask
	}

	[Token(Token = "0x2006114")]
	public enum MaterialType
	{
		[Token(Token = "0x402D985")]
		Atlas = 1,
		[Token(Token = "0x402D986")]
		NoAtlas
	}

	[Token(Token = "0x2006115")]
	public enum ChannelType
	{
		[Token(Token = "0x402D988")]
		Texture,
		[Token(Token = "0x402D989")]
		NormalMap,
		[Token(Token = "0x402D98A")]
		MaterialColor,
		[Token(Token = "0x402D98B")]
		TintedTexture,
		[Token(Token = "0x402D98C")]
		DiffuseTexture
	}

	[Serializable]
	[Token(Token = "0x2006116")]
	public class MaterialChannel
	{
		[Token(Token = "0x402D98D")]
		[FieldOffset(Offset = "0x10")]
		public ChannelType channelType;

		[Token(Token = "0x402D98E")]
		[FieldOffset(Offset = "0x14")]
		public RenderTextureFormat textureFormat;

		[Token(Token = "0x402D98F")]
		[FieldOffset(Offset = "0x18")]
		public string materialPropertyName;

		[NonSerialized]
		[Token(Token = "0x402D990")]
		[FieldOffset(Offset = "0x20")]
		private int _materialPropertyID;

		[Token(Token = "0x17002993")]
		public int materialPropertyID
		{
			[MethodImpl(512)]
			[Token(Token = "0x6029222")]
			[Address(RVA = "0x4B0C648", Offset = "0x4B0C648", VA = "0x104B0C648")]
			get
			{
				return default(int);
			}
		}

		[MethodImpl(768)]
		[Token(Token = "0x6029221")]
		[Address(RVA = "0x4B0C67C", Offset = "0x4B0C67C", VA = "0x104B0C67C")]
		public MaterialChannel()
		{
		}
	}

	[Token(Token = "0x402D97A")]
	[FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x402D97B")]
	[FieldOffset(Offset = "0x20")]
	public MaterialType materialType;

	[Token(Token = "0x402D97C")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool useSkin;

	[Token(Token = "0x402D97D")]
	[FieldOffset(Offset = "0x28")]
	public MaskType maskType;

	[Token(Token = "0x402D97E")]
	[FieldOffset(Offset = "0x30")]
	public MaterialChannel[] channels;

	[NonSerialized]
	[Token(Token = "0x402D97F")]
	[FieldOffset(Offset = "0x38")]
	private bool validated;

	[MethodImpl(768)]
	[Token(Token = "0x602921C")]
	[Address(RVA = "0x4B0C350", Offset = "0x4B0C350", VA = "0x104B0C350")]
	public UMAMaterial()
	{
	}

	[MethodImpl(1024)]
	[Token(Token = "0x602921D")]
	[Address(RVA = "0x4B0C360", Offset = "0x4B0C360", VA = "0x104B0C360")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x602921E")]
	[Address(RVA = "0x4B0C388", Offset = "0x4B0C388", VA = "0x104B0C388")]
	public bool Equals(UMAMaterial material)
	{
		return default(bool);
	}

	[Token(Token = "0x602921F")]
	[Address(RVA = "0x4B0C530", Offset = "0x4B0C530", VA = "0x104B0C530")]
	public bool ValidateChannels()
	{
		return default(bool);
	}

	[Token(Token = "0x6029220")]
	[Address(RVA = "0x4B0C564", Offset = "0x4B0C564", VA = "0x104B0C564")]
	private bool DoValidateChannels()
	{
		return default(bool);
	}
}
