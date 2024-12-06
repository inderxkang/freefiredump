using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060E4")]
public abstract class RaceLibraryBase : MonoBehaviour
{
	[MethodImpl(768)]
	[Token(Token = "0x6029093")]
	[Address(RVA = "0x4ACE5D8", Offset = "0x4ACE5D8", VA = "0x104ACE5D8")]
	protected RaceLibraryBase()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6029094")]
	public abstract void AddRace(RaceData race);

	[MethodImpl(256)]
	[Token(Token = "0x6029095")]
	public abstract RaceData GetRace(string raceName);

	[MethodImpl(256)]
	[Token(Token = "0x6029096")]
	public abstract RaceData GetRace(int raceHash);

	[MethodImpl(256)]
	[Token(Token = "0x6029097")]
	public abstract RaceData[] GetAllRaces();

	[MethodImpl(256)]
	[Token(Token = "0x6029098")]
	public abstract void UpdateDictionary();

	[MethodImpl(256)]
	[Token(Token = "0x6029099")]
	public abstract void ValidateDictionary();
}
