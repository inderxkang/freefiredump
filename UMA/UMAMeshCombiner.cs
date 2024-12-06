using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2006118")]
public abstract class UMAMeshCombiner : MonoBehaviour
{
	[MethodImpl(768)]
	[Token(Token = "0x602922C")]
	[Address(RVA = "0x4B0C9B0", Offset = "0x4B0C9B0", VA = "0x104B0C9B0")]
	protected UMAMeshCombiner()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x602922D")]
	public abstract void UpdateUMAMesh(bool updatedAtlas, UMAData umaData, int atlasResolution);

	[MethodImpl(256)]
	[Token(Token = "0x602922E")]
	[Address(RVA = "0x4B0C9B8", Offset = "0x4B0C9B8", VA = "0x104B0C9B8", Slot = "5")]
	public virtual void Preprocess(UMAData umaData)
	{
	}
}
