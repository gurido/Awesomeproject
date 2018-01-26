using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCMenuManager : MonoBehaviour {

	private GameStatusManager gamestatusmanager;
	public void NPCMenuManagerStart () {
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();

	}
	
	public void NPCMenuManagerUpdate () {
	}

	public void ExitNPCMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();
		//GetComponent<CharacterCreationManager> ().ClearCharacterList ();
	}

	public void InspectACharacter(){
		gamestatusmanager.ChangeStatusToCharacterInspectionMenu ();
	}
		
	void RefreshNPCMenuManager(){
		//GetComponent<NPCMenuDescriptionManager>().InspectCharacterDetailsManager ();
		//GetComponent<NPCMenuDescriptionManager>().NPCDescriptionTextUpdate ();

	}



}
