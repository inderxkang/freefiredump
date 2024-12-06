using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UMACharacterSystem;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060A2")]
public interface IUmaAvatar : IUmaAvatarWithSlots, IUmaAvatarBase
{
	[MethodImpl(256)]
	[Token(Token = "0x6028E43")]
	void SetForceChangeRace();

	[MethodImpl(256)]
	[Token(Token = "0x6028E44")]
	void ChangeRace(string racename, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults);

	[MethodImpl(256)]
	[Token(Token = "0x6028E45")]
	void SetColor(string Name, OverlayColorData colorData, bool UpdateTexture = true);

	[MethodImpl(256)]
	[Token(Token = "0x6028E46")]
	void SetMaskColors(Color[] mask, Color[] additive, bool updateTexture = false);

	[MethodImpl(256)]
	[Token(Token = "0x6028E47")]
	void ForceUpdateColor();

	[MethodImpl(256)]
	[Token(Token = "0x6028E48")]
	void BuildCharacterImmediatly();

	[MethodImpl(256)]
	[Token(Token = "0x6028E49")]
	void BuildCharacter();

	[MethodImpl(256)]
	[Token(Token = "0x6028E4A")]
	void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false);

	[MethodImpl(256)]
	[Token(Token = "0x6028E4B")]
	void InitAsyncLoading(bool pre);

	[MethodImpl(256)]
	[Token(Token = "0x6028E4C")]
	bool IsAsyncLoading();

	[MethodImpl(256)]
	[Token(Token = "0x6028E4D")]
	void SetUpdateWeaponFlag(bool flag);

	[MethodImpl(256)]
	[Token(Token = "0x6028E4E")]
	bool GetUpdateWeaponFlag();
}
