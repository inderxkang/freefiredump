using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2006119")]
public struct SubMeshTriangles
{
	[Token(Token = "0x402D997")]
	[FieldOffset(Offset = "0x0")]
	public int[] triangles;

	[Token(Token = "0x402D998")]
	[FieldOffset(Offset = "0x8")]
	public List<int> trianglesList;
}
