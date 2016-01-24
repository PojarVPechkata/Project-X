using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
	public BaseMageClass (){
		CharacterClassName = "Wizard";
		CharacterClassDescription = "Intelligent man who uses magic";
		Stamina = 14;
		Endurance = 12;
		Strenght = 11;
		Intellect = 15;
	}
}
