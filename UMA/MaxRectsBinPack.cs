using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x20060DD")]
public class MaxRectsBinPack
{
	[Token(Token = "0x20060DE")]
	public enum FreeRectChoiceHeuristic
	{
		[Token(Token = "0x402D7CC")]
		RectBestShortSideFit,
		[Token(Token = "0x402D7CD")]
		RectBestLongSideFit,
		[Token(Token = "0x402D7CE")]
		RectBestAreaFit,
		[Token(Token = "0x402D7CF")]
		RectBottomLeftRule,
		[Token(Token = "0x402D7D0")]
		RectContactPointRule
	}

	[Token(Token = "0x402D7C6")]
	[FieldOffset(Offset = "0x10")]
	public int binWidth;

	[Token(Token = "0x402D7C7")]
	[FieldOffset(Offset = "0x14")]
	public int binHeight;

	[Token(Token = "0x402D7C8")]
	[FieldOffset(Offset = "0x18")]
	public bool allowRotations;

	[Token(Token = "0x402D7C9")]
	[FieldOffset(Offset = "0x20")]
	public List<Rect> usedRectangles;

	[Token(Token = "0x402D7CA")]
	[FieldOffset(Offset = "0x28")]
	public List<Rect> freeRectangles;

	[MethodImpl(768)]
	[Token(Token = "0x602904D")]
	[Address(RVA = "0x4AC688C", Offset = "0x4AC688C", VA = "0x104AC688C")]
	public MaxRectsBinPack(int width, int height, bool rotations)
	{
	}

	[Token(Token = "0x602904E")]
	[Address(RVA = "0x4AC694C", Offset = "0x4AC694C", VA = "0x104AC694C")]
	public void Init(int width, int height, bool rotations)
	{
	}

	[Token(Token = "0x602904F")]
	[Address(RVA = "0x4AC6A88", Offset = "0x4AC6A88", VA = "0x104AC6A88")]
	public Rect Insert(int width, int height, FreeRectChoiceHeuristic method)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029050")]
	[Address(RVA = "0x4AC8EDC", Offset = "0x4AC8EDC", VA = "0x104AC8EDC")]
	public void Insert(List<Rect> rects, List<Rect> dst, FreeRectChoiceHeuristic method)
	{
	}

	[Token(Token = "0x6029051")]
	[Address(RVA = "0x4AC9208", Offset = "0x4AC9208", VA = "0x104AC9208")]
	private void PlaceRect(Rect node)
	{
	}

	[Token(Token = "0x6029052")]
	[Address(RVA = "0x4AC9120", Offset = "0x4AC9120", VA = "0x104AC9120")]
	private Rect ScoreRect(int width, int height, FreeRectChoiceHeuristic method, ref int score1, ref int score2)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029053")]
	[Address(RVA = "0x4AC9364", Offset = "0x4AC9364", VA = "0x104AC9364")]
	public float Occupancy()
	{
		return default(float);
	}

	[Token(Token = "0x6029054")]
	[Address(RVA = "0x4AC7220", Offset = "0x4AC7220", VA = "0x104AC7220")]
	private Rect FindPositionForNewNodeBottomLeft(int width, int height, ref int bestY, ref int bestX)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029055")]
	[Address(RVA = "0x4AC6CC0", Offset = "0x4AC6CC0", VA = "0x104AC6CC0")]
	private Rect FindPositionForNewNodeBestShortSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029056")]
	[Address(RVA = "0x4AC7BA8", Offset = "0x4AC7BA8", VA = "0x104AC7BA8")]
	private Rect FindPositionForNewNodeBestLongSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029057")]
	[Address(RVA = "0x4AC8108", Offset = "0x4AC8108", VA = "0x104AC8108")]
	private Rect FindPositionForNewNodeBestAreaFit(int width, int height, ref int bestAreaFit, ref int bestShortSideFit)
	{
		return default(Rect);
	}

	[Token(Token = "0x6029058")]
	[Address(RVA = "0x4AC94A4", Offset = "0x4AC94A4", VA = "0x104AC94A4")]
	private int CommonIntervalLength(int i1start, int i1end, int i2start, int i2end)
	{
		return default(int);
	}

	[Token(Token = "0x6029059")]
	[Address(RVA = "0x4AC955C", Offset = "0x4AC955C", VA = "0x104AC955C")]
	private int ContactPointScoreNode(int x, int y, int width, int height)
	{
		return default(int);
	}

	[Token(Token = "0x602905A")]
	[Address(RVA = "0x4AC7710", Offset = "0x4AC7710", VA = "0x104AC7710")]
	private Rect FindPositionForNewNodeContactPoint(int width, int height, ref int bestContactScore)
	{
		return default(Rect);
	}

	[Token(Token = "0x602905B")]
	[Address(RVA = "0x4AC86D0", Offset = "0x4AC86D0", VA = "0x104AC86D0")]
	private bool SplitFreeNode(Rect freeNode, ref Rect usedNode)
	{
		return default(bool);
	}

	[Token(Token = "0x602905C")]
	[Address(RVA = "0x4AC8CCC", Offset = "0x4AC8CCC", VA = "0x104AC8CCC")]
	private void PruneFreeList()
	{
	}

	[Token(Token = "0x602905D")]
	[Address(RVA = "0x4AC99A4", Offset = "0x4AC99A4", VA = "0x104AC99A4")]
	private bool IsContainedIn(Rect a, Rect b)
	{
		return default(bool);
	}
}
