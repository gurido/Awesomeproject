using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreationMenuManager : MonoBehaviour {

	private GameStatusManager gamestatusmanager;


	public void CharacterCreationMenuStart(){
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();

	}

	public void CharacterCreationMenuUpdate(){

	}

	public void ExitCharacterCreationMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();

	}

	public void PressSaveCharacterButton(){

	}

}
