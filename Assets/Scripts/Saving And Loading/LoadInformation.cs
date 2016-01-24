using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation(){
		GameInformation.PlayerName = PlayerPrefs.GetString ("PlayerName");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PlayerLevel");
		//Stats
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("Stamina");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("Endurance");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("Intellect");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("Strenght");

		if (PlayerPrefs.GetString ("EQUIPMENTITEM1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment) PPSerialization.Load ("EQUIPMENTITEM1");
		}
		Debug.Log ("The information was loaded");


	}
}
