using UnityEngine;
using System.Collections;

public class IncreaseExperience {
	private static float xpToGive;

	public static void AddExperience(){
		xpToGive = GameInformation.PlayerLevel * Random.Range(1,200);
		GameInformation.CurrentXP += xpToGive;
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			//then player has leveled up
			CheckToSeeIfPlayerLeveled();
			GameInformation.PlayerLevel = GameInformation.PlayerLevel + 1;
		}else
		Debug.Log (xpToGive);

	}
//	public static void AddExperienceOnExplore(){
//		xpToGive = GameInformation.PlayerLevel * area of exploration,maybe xyz? or ID.
//	}
	public static void AddExperienceOnExplore(){
		xpToGive = GameInformation.PlayerLevel * Random.Range (1, 50);
		GameInformation.CurrentXP += xpToGive;
	}

	private static void CheckToSeeIfPlayerLeveled(){
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {

		}
	}
}
