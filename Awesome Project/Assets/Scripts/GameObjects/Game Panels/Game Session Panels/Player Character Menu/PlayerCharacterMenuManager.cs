using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMenuManager : MonoBehaviour {

	private GameStatusManager gamestatusmanager;

	public void PlayerCharacterMenuStart(){
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
	}

	public void PlayerCharacterMenuUpdate(){

	}

	public void ExitToMainMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();

	}

}
