using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x20060F1")]
public abstract class TextureProcessBaseCoroutine : WorkerCoroutine
{
	[MethodImpl(768)]
	[Token(Token = "0x6029102")]
	[Address(RVA = "0x4AF366C", Offset = "0x4AF366C", VA = "0x104AF366C")]
	protected TextureProcessBaseCoroutine()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029103")]
	public abstract void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator);
}
