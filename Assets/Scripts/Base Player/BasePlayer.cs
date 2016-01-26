using UnityEngine;
using System.Collections;

public class BasePlayer {
	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int stamina;
	private int endurance;
	private int intellect;
	private int strenght;
	private float currentXP;
	private float requiredXP;

	public float CurrentXP{ get; set; }
	public float RequiredXP{ get; set; }

	public string PlayerName{
		get{ return playerName; }
		set{ playerName = value; }
	}
		
	public int PlayerLevel{
		get{ return playerLevel; }
		set{ playerLevel = value; }
	}
	public BaseCharacterClass PlayerClass{
		get{ return playerClass; }
		set{ playerClass = value; }
	}
	public int Stamina{
		get{ return stamina; }
		set{ stamina = value; }
	}
	public int Endurance{
		get{ return endurance; }
		set{ endurance = value; }
	}	
	public int Intellect{
		get{ return intellect; }
		set{ intellect = value; }
	}
	public int Strenght{
		get{ return strenght; }
		set{ strenght = value; }
	}

}
