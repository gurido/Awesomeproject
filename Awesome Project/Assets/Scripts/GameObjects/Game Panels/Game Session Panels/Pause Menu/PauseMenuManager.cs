using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour {
	public bool IsPauseMenuActive = false;
	private TimeManager timemanager;
	private GameStatusManager gamestatusmanager;

	public void PauseMenuManagerStart(){
		IsPauseMenuActive = true;
		timemanager = GameObject.Find ("_GameManager").GetComponent<TimeManager> ();
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
		timemanager.StopTime ();
	}

	public void PauseMenuManagerUpdate(){
	}

	public void ExitPauseMenu(){
		IsPauseMenuActive = false;
		gamestatusmanager.TurnOffPauseMenu ();
		timemanager.PlayTime ();

	}
}
