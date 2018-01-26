using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryEntryMenuManager : MonoBehaviour {

	private GameStatusManager gamestatusmanager;

	public void DiaryEntryMenuManagerStart(){
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
	}

	public void DiaryEntryMenuManagerUpdate(){

	}

	public void EnterMainMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();
		
	}

	public void EnterWriteDiaryMenu(){
		gamestatusmanager.ChangeStatusToWriteDiary ();

	}

	public void ViewPastDiaryEntry(){

	}

}
