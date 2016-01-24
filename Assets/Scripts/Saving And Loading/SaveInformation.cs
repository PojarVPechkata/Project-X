using UnityEngine;
using System.Collections;

public class SaveInformation  {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("PlayerLevel", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PlayerName", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("Stamina", GameInformation.Stamina);
		PlayerPrefs.SetInt ("Endurance", GameInformation.Endurance);
		PlayerPrefs.SetInt ("Intellect", GameInformation.Intellect);
		PlayerPrefs.SetInt ("Strenght", GameInformation.Strenght);
		if (GameInformation.EquipmentOne != null) {
			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}
		Debug.Log ("The information was saved");
	}
}
