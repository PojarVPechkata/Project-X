using UnityEngine;
using System.Collections;

public class BaseScroll : BaseItem {
	private int scrollEffectID;
	private ScrollTypes scrollType;
	public enum ScrollTypes{
		EXPERIENCE,
		DAMAGE,
		MAGIC
	}
	public int ScrollEffectID{
		get{ return scrollEffectID; }
		set{ scrollEffectID = value; }
	}
	public ScrollTypes ScrollType{
		get{ return scrollType; }
		set{ scrollType = value; }
	}
}
