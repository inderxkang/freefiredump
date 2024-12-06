using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x200612D")]
public abstract class WorkerCoroutine
{
	[Token(Token = "0x402DA02")]
	[FieldOffset(Offset = "0x10")]
	private IEnumerator workerInstance;

	[Token(Token = "0x402DA03")]
	[FieldOffset(Offset = "0x18")]
	private WorkerCoroutine subWorker;

	[Token(Token = "0x402DA04")]
	[FieldOffset(Offset = "0x20")]
	public int TimeHint;

	[Token(Token = "0x402DA05")]
	[FieldOffset(Offset = "0x28")]
	public WorkerCoroutine lastWorker;

	[Token(Token = "0x402DA06")]
	[FieldOffset(Offset = "0x30")]
	public int lastWorkerCount;

	[MethodImpl(768)]
	[Token(Token = "0x60292B7")]
	[Address(RVA = "0x4B176C0", Offset = "0x4B176C0", VA = "0x104B176C0")]
	protected WorkerCoroutine()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60292B8")]
	protected abstract void Start();

	[MethodImpl(256)]
	[Token(Token = "0x60292B9")]
	protected abstract IEnumerator workerMethod();

	[MethodImpl(256)]
	[Token(Token = "0x60292BA")]
	protected abstract void Stop();

	[MethodImpl(256)]
	[Token(Token = "0x60292BB")]
	[Address(RVA = "0x4B176C8", Offset = "0x4B176C8", VA = "0x104B176C8", Slot = "7")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x60292BC")]
	[Address(RVA = "0x4B176DC", Offset = "0x4B176DC", VA = "0x104B176DC")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60292BD")]
	[Address(RVA = "0x4B17724", Offset = "0x4B17724", VA = "0x104B17724")]
	public bool Work()
	{
		return default(bool);
	}
}
