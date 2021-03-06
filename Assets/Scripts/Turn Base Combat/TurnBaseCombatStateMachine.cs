﻿using UnityEngine;
using System.Collections;

public class TurnBaseCombatStateMachine : MonoBehaviour {

	private bool hasAddedXP;

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		PLAYERANIMATE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleStates currentState;


	// Use this for initialization
	void Start () {
		hasAddedXP = false;
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch (currentState) {

		case(BattleStates.START): 
			//SETUP BATTLE FUNCTION
			//It will run until something ends the battle
			break;
		case(BattleStates.PLAYERCHOICE):

			break;
		case(BattleStates.ENEMYCHOICE):

			break;
		case(BattleStates.LOSE):

			break;
		case(BattleStates.WIN):
			if (!hasAddedXP) {
				IncreaseExperience.AddExperience ();
				hasAddedXP = true;
			}
			break;
		}
	}

	void OnGUI(){
		if (GUILayout.Button ("Next State")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.PLAYERCHOICE;
			}else if (currentState == BattleStates.PLAYERCHOICE) {
				currentState = BattleStates.PLAYERANIMATE;
			}else if (currentState == BattleStates.PLAYERANIMATE) {
				currentState = BattleStates.ENEMYCHOICE;
			}else if (currentState == BattleStates.ENEMYCHOICE) {
				currentState = BattleStates.PLAYERANIMATE;
			}else if (currentState == BattleStates.PLAYERANIMATE) {
				currentState = BattleStates.LOSE;
			}else if (currentState == BattleStates.LOSE) {
				currentState = BattleStates.WIN;
			}else if (currentState == BattleStates.WIN) {
				currentState = BattleStates.START;
			}
		}
	}
}
