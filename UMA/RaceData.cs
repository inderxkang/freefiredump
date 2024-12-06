using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x20060D7")]
public class RaceData : ScriptableObject, INameProvider
{
	[Serializable]
	[Token(Token = "0x20060D8")]
	public class RaceThumbnails
	{
		[Serializable]
		[Token(Token = "0x20060D9")]
		public class WardrobeSlotThumb
		{
			[Token(Token = "0x402D7BC")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2D3344", Offset = "0x2D3344")]
			public string thumbIsFor;

			[Token(Token = "0x402D7BD")]
			[FieldOffset(Offset = "0x18")]
			public Sprite thumb;

			[MethodImpl(768)]
			[Token(Token = "0x602903B")]
			[Address(RVA = "0x4ACE560", Offset = "0x4ACE560", VA = "0x104ACE560")]
			public WardrobeSlotThumb()
			{
			}
		}

		[Token(Token = "0x402D7B9")]
		[FieldOffset(Offset = "0x10")]
		public Sprite fullThumb;

		[Token(Token = "0x402D7BA")]
		[FieldOffset(Offset = "0x18")]
		public Sprite faceThumb;

		[Token(Token = "0x402D7BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<WardrobeSlotThumb> wardrobeSlotThumbs;

		[MethodImpl(768)]
		[Token(Token = "0x6029039")]
		[Address(RVA = "0x4ACE120", Offset = "0x4ACE120", VA = "0x104ACE120")]
		public RaceThumbnails()
		{
		}

		[Token(Token = "0x602903A")]
		[Address(RVA = "0x4ACE190", Offset = "0x4ACE190", VA = "0x104ACE190")]
		public Sprite GetThumbFor(string thumbToGet = "")
		{
			return null;
		}
	}

	[Token(Token = "0x20060DA")]
	public enum UMATarget
	{
		[Token(Token = "0x402D7BF")]
		Humanoid,
		[Token(Token = "0x402D7C0")]
		Generic
	}

	[Token(Token = "0x402D7AC")]
	[FieldOffset(Offset = "0x18")]
	public UMARecipeBase baseRaceRecipe;

	[Token(Token = "0x402D7AD")]
	[FieldOffset(Offset = "0x20")]
	[UMAAssetFieldVisible]
	public int baseOverlayLimitSizes;

	[Token(Token = "0x402D7AE")]
	[FieldOffset(Offset = "0x28")]
	public List<string> wardrobeSlots;

	[Token(Token = "0x402D7AF")]
	[FieldOffset(Offset = "0x30")]
	public List<int> overlayLimitSizes;

	[Token(Token = "0x402D7B0")]
	[FieldOffset(Offset = "0x38")]
	public List<string> backwardsCompatibleWith;

	[Token(Token = "0x402D7B1")]
	[FieldOffset(Offset = "0x40")]
	public RaceThumbnails raceThumbnails;

	[Token(Token = "0x402D7B2")]
	[FieldOffset(Offset = "0x48")]
	public string raceName;

	[Token(Token = "0x402D7B3")]
	[FieldOffset(Offset = "0x50")]
	public UmaTPose TPose;

	[Token(Token = "0x402D7B4")]
	[FieldOffset(Offset = "0x58")]
	public UMATarget umaTarget;

	[Token(Token = "0x402D7B5")]
	[FieldOffset(Offset = "0x60")]
	public string genericRootMotionTransformName;

	[Token(Token = "0x402D7B6")]
	[FieldOffset(Offset = "0x68")]
	public float raceHeight;

	[Token(Token = "0x402D7B7")]
	[FieldOffset(Offset = "0x6C")]
	public float raceRadius;

	[Token(Token = "0x402D7B8")]
	[FieldOffset(Offset = "0x70")]
	public float raceMass;

	[MethodImpl(768)]
	[Token(Token = "0x6029031")]
	[Address(RVA = "0x4ACD840", Offset = "0x4ACD840", VA = "0x104ACD840")]
	public RaceData()
	{
	}

	[Token(Token = "0x6029032")]
	[Address(RVA = "0x4ACDA94", Offset = "0x4ACDA94", VA = "0x104ACDA94")]
	public void AddDefaultWardrobeSlots(bool forceOverride = false)
	{
	}

	[Token(Token = "0x6029033")]
	[Address(RVA = "0x4ACDCE0", Offset = "0x4ACDCE0", VA = "0x104ACDCE0")]
	public bool ValidateWardrobeSlots(bool setToDefault = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6029034")]
	[Address(RVA = "0x4ACDDA0", Offset = "0x4ACDDA0", VA = "0x104ACDDA0")]
	public bool findBackwardsCompatibleWith(List<string> compatibleStrings)
	{
		return default(bool);
	}

	[Token(Token = "0x6029035")]
	[Address(RVA = "0x4ACDEFC", Offset = "0x4ACDEFC", VA = "0x104ACDEFC")]
	public int GetSlotLimitSize(string s)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029036")]
	[Address(RVA = "0x4ACE050", Offset = "0x4ACE050", VA = "0x104ACE050", Slot = "4")]
	public string GetAssetName()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029037")]
	[Address(RVA = "0x4ACE058", Offset = "0x4ACE058", VA = "0x104ACE058", Slot = "5")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x6029038")]
	[Address(RVA = "0x4ACE060", Offset = "0x4ACE060", VA = "0x104ACE060")]
	public bool Validate()
	{
		return default(bool);
	}
}
