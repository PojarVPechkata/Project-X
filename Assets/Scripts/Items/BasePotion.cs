using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePotion : BaseStatItem {

	public enum PotionTypes{
		HEALTH,
		ENERGY,
		STRENGHT,
		INTELLECT,
		VITALITY,
		ENDURANCE,
		SPEED
	}
	private PotionTypes potionType;
	private int potionEffectID;

	public PotionTypes PotionType{
		get{ return potionType; }
		set{ potionType = value; }
	}
	public int PotionEffectID{
		get{ return potionEffectID; }
		set{ potionEffectID = value; }
	}
}