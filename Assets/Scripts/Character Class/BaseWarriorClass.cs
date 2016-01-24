using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {
	public BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharacterClassDescription = "He is strong and powerful melee hero.";
		Stamina = 15;
		Endurance = 12;
		Strenght = 14;
		Intellect = 11;
	}
}
