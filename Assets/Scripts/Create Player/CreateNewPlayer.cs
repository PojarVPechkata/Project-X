using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreateNewPlayer : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter name:";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		playerName = GUILayout.TextArea (playerName,16);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if(GUILayout.Button("Create")){
			if(isMageClass){
				newPlayer.PlayerClass = new BaseMageClass();
			}else if(isWarriorClass){
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
			newPlayer.PlayerName = playerName;
			StoreNewPlayerInfo ();
			SaveInformation.SaveAllInformation ();
			//Debug Log
			Debug.Log ("Player Name: " + newPlayer.PlayerName);
			Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log("Stamina: " + newPlayer.Stamina);
			Debug.Log("Endurance: " + newPlayer.Endurance);
			Debug.Log("Intellect: " + newPlayer.Intellect);
			Debug.Log("Strenght: " + newPlayer.Strenght);

		}
		if(GUILayout.Button("Load")){
			SceneManager.LoadScene("test");
		}
	}
	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Stamina = newPlayer.Stamina;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Strenght = newPlayer.Strenght;
	}
}
