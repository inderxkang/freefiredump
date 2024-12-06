using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200610A")]
public abstract class UMAGeneratorBase : MonoBehaviour
{
	[Token(Token = "0x200610B")]
	public class AnimatorState
	{
		[Token(Token = "0x402D92E")]
		[FieldOffset(Offset = "0x10")]
		private int[] stateHashes;

		[Token(Token = "0x402D92F")]
		[FieldOffset(Offset = "0x18")]
		private float[] stateTimes;

		[Token(Token = "0x402D930")]
		[FieldOffset(Offset = "0x20")]
		private AnimatorControllerParameter[] parameters;

		[MethodImpl(768)]
		[Token(Token = "0x60291D3")]
		[Address(RVA = "0x4B02980", Offset = "0x4B02980", VA = "0x104B02980")]
		public AnimatorState()
		{
		}

		[Token(Token = "0x60291D4")]
		[Address(RVA = "0x4B029F8", Offset = "0x4B029F8", VA = "0x104B029F8")]
		public void SaveAnimatorState(Animator animator)
		{
		}

		[Token(Token = "0x60291D5")]
		[Address(RVA = "0x4B02E10", Offset = "0x4B02E10", VA = "0x104B02E10")]
		public void RestoreAnimatorState(Animator animator)
		{
		}
	}

	[Token(Token = "0x402D928")]
	[FieldOffset(Offset = "0x18")]
	public bool fitAtlas;

	[Token(Token = "0x402D929")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public TextureMerge textureMerge;

	[Token(Token = "0x402D92A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x2D3490", Offset = "0x2D3490")]
	public bool convertRenderTexture;

	[Token(Token = "0x402D92B")]
	[FieldOffset(Offset = "0x29")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x2D34C8", Offset = "0x2D34C8")]
	public bool convertMipMaps;

	[Token(Token = "0x402D92C")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x2D3500", Offset = "0x2D3500")]
	public int atlasResolution;

	[Token(Token = "0x402D92D")]
	[FieldOffset(Offset = "0x0")]
	protected static UMAGeneratorBase Instance;

	[MethodImpl(768)]
	[Token(Token = "0x60291C5")]
	[Address(RVA = "0x4B02334", Offset = "0x4B02334", VA = "0x104B02334")]
	protected UMAGeneratorBase()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291C6")]
	public abstract void addDirtyUMA(UMAData umaToAdd);

	[MethodImpl(256)]
	[Token(Token = "0x60291C7")]
	public abstract bool IsIdle();

	[MethodImpl(256)]
	[Token(Token = "0x60291C8")]
	public abstract int QueueSize();

	[MethodImpl(256)]
	[Token(Token = "0x60291C9")]
	public abstract void Work();

	[MethodImpl(256)]
	[Token(Token = "0x60291CA")]
	public abstract void WorkSync(UMAData umadata);

	[MethodImpl(256)]
	[Token(Token = "0x60291CB")]
	public abstract void RemoveData(UMAData umadata);

	[Token(Token = "0x60291CC")]
	[Address(RVA = "0x4AFB1B8", Offset = "0x4AFB1B8", VA = "0x104AFB1B8")]
	public static UMAGeneratorBase FindInstance()
	{
		return null;
	}

	[MethodImpl(1280)]
	[Token(Token = "0x60291CD")]
	[Address(RVA = "0x4B0233C", Offset = "0x4B0233C", VA = "0x104B0233C", Slot = "10")]
	public virtual void OnDestroy()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60291CE")]
	[Address(RVA = "0x4B023D8", Offset = "0x4B023D8", VA = "0x104B023D8", Slot = "11")]
	public virtual void UpdateAvatar(UMAData umaData)
	{
	}

	[Token(Token = "0x60291CF")]
	[Address(RVA = "0x4B028A0", Offset = "0x4B028A0", VA = "0x104B028A0")]
	public static void SetAvatar(UMAData umaData, Animator animator)
	{
	}

	[Token(Token = "0x60291D0")]
	[Address(RVA = "0x4B03168", Offset = "0x4B03168", VA = "0x104B03168")]
	public static Avatar CreateAvatar(UMAData umaData, UmaTPose umaTPose)
	{
		return null;
	}

	[Token(Token = "0x60291D1")]
	[Address(RVA = "0x4B03194", Offset = "0x4B03194", VA = "0x104B03194")]
	public static Avatar CreateGenericAvatar(UMAData umaData)
	{
		return null;
	}

	[Token(Token = "0x60291D2")]
	[Address(RVA = "0x4B03210", Offset = "0x4B03210", VA = "0x104B03210")]
	public static HumanDescription CreateHumanDescription(UMAData umaData, UmaTPose umaTPose)
	{
		return default(HumanDescription);
	}
}
