using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x20060DC")]
public interface INameProvider
{
	[MethodImpl(256)]
	[Token(Token = "0x602904B")]
	string GetAssetName();

	[MethodImpl(256)]
	[Token(Token = "0x602904C")]
	int GetNameHash();
}
