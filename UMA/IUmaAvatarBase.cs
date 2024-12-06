using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;

namespace UMA;

[Token(Token = "0x200609F")]
public interface IUmaAvatarBase
{
	[Token(Token = "0x1700296A")]
	UMAData UmaData
	{
		[MethodImpl(768)]
		[Token(Token = "0x6028E2A")]
		get;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6028E29")]
	GameObject GetGameObject();

	[MethodImpl(256)]
	[Token(Token = "0x6028E2B")]
	void SetEnableMipMap(bool enableMipMap);

	[MethodImpl(256)]
	[Token(Token = "0x6028E2C")]
	void SetEnableRenderTexturePool(bool flag);

	[MethodImpl(256)]
	[Token(Token = "0x6028E2D")]
	void SetTextureScaleFactor(int scale);

	[MethodImpl(256)]
	[Token(Token = "0x6028E2E")]
	void SetNormalSpecTexScale(float scale);

	[MethodImpl(256)]
	[Token(Token = "0x6028E2F")]
	void SetUpdateWhenOffSceen(bool flag);

	[MethodImpl(256)]
	[Token(Token = "0x6028E30")]
	void SetNeedGenerateMesh(bool needMesh);

	[MethodImpl(256)]
	[Token(Token = "0x6028E31")]
	void SetUsingRGB565(bool use);

	[MethodImpl(256)]
	[Token(Token = "0x6028E32")]
	void SetAtlasResolutionScale(float scale);

	[MethodImpl(256)]
	[Token(Token = "0x6028E33")]
	void SetNoMergeTexture(bool noMerge);

	[MethodImpl(256)]
	[Token(Token = "0x6028E34")]
	void SetNoClothMergeTexture(bool noMerge);

	[MethodImpl(256)]
	[Token(Token = "0x6028E35")]
	void SetNoSkinMergeWithCondition(bool noMerge);

	[MethodImpl(256)]
	[Token(Token = "0x6028E36")]
	void SetUpdateTextureSizeByChannelType(bool update);

	[MethodImpl(256)]
	[Token(Token = "0x6028E37")]
	void EnableDebugLog(bool enable);

	[MethodImpl(256)]
	[Token(Token = "0x6028E38")]
	void SetVisible(bool visible);

	[MethodImpl(256)]
	[Token(Token = "0x6028E39")]
	UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache);
}
