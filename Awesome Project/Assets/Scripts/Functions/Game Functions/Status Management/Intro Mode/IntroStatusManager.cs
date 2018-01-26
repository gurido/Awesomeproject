using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroStatusManager : MonoBehaviour {
	public int IntroStatus; // 1 intro, 2 select game
	private IntroUIManager introuimanager;
	private MainDatabaseManager maindatabasemanager;
	private WriteJsonManager writejsonmanager;

	private IntroMenuManager intromenumanager;
	private SelectGameMenuManager selectgamemenumanager;



	public void StartIntroStatusManager(){

		IntroStatus = 1;
		FindScripts ();
		SwitchToIntroMenu ();
		maindatabasemanager.LoadMainDatabase ();
		writejsonmanager.StartWriteJsonManager ();

	}

	private void FindScripts(){
		introuimanager = GetComponent<IntroUIManager> ();
		intromenumanager = GetComponent<IntroMenuManager> ();
		maindatabasemanager = GetComponent<MainDatabaseManager> ();
		writejsonmanager = GetComponent<WriteJsonManager> ();
		selectgamemenumanager = GameObject.Find("MainCanvas").GetComponentInChildren<SelectGameMenuManager>();
	}


	public void SwitchToIntroMenu(){
		introuimanager.SwitchToIntroMenuPanel ();
		intromenumanager.IntroMenuManagerStart();
	}

	public void SwitchToSelectGame(){
		introuimanager.SwitchToSelectGameMenuPanel ();
		selectgamemenumanager.SelectGameMenuManagerStart ();
	}


	public void SwitchToPlaySession(){


	}



	public void SwitchToBuidSession(){
		SceneManager.LoadScene ("Build Game");

	}


	public void SwitchToBuildAssets(){
		SceneManager.LoadScene ("Build Asset");

	}

	public void SwitchToOnlineSession(){
		SceneManager.LoadScene ("Online Session");

	}


	public void IntroMenuUpdate(){

		switch(IntroStatus){
		case 1://intro menu
			intromenumanager.IntroMenuManagerGetKey();
			break;
		case 2:
			break;
		default:
			break;

		}


	}


}
