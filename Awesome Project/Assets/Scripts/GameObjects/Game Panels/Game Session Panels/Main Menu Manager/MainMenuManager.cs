using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {
	
	//private GameObject maingamepanel;
	public Text CurrentTimeText;

	private string spc = "   ";
	private string CurrentMinuteString;
	private string CurrentHourString;
	private string CurrentAMPM;

	private GameObject gamemanager;
	private GameStatusManager gamestatusmanager;
	private TimeManager timemanager;

	public void MainMenuManagerStart(){
		gamemanager = GameObject.Find("_GameManager").gameObject;
		timemanager = gamemanager.GetComponent<TimeManager> ();
		gamestatusmanager = gamemanager.GetComponent<GameStatusManager> ();

		FullTextUpdate ();
	}


	public void MainMenuManagerUpdate(){
		FullTextUpdate ();

	}


	public void MainMenuManagerCheck(){

	}


	public void PressDiaryButton(){
		gamestatusmanager.ChangeStatusToWriteDiary ();
	}

	public void PressInventoryButton(){
		gamestatusmanager.ChangeStatusToCharacterInventoryMenu ();

	}

	public void PressNPCButton(){
		gamestatusmanager.ChangeStatusToNPCMenu ();
	}

	public void PressPlayerButton(){
		gamestatusmanager.ChangeStatusToPlayerMenu ();
	}

	public void PressCreateCharacterButton(){
		gamestatusmanager.ChangeStatusToCharacterCreationMenu ();
	}

	public void PressMapButton(){
		gamestatusmanager.ChangeStatusToMapMenu ();
	}













	public void MinuteTextUpdate(){
		if(timemanager.CurrentMinute == 0){
			CurrentMinuteString = "00";
		}
		else{
			CurrentMinuteString = "" + timemanager.CurrentMinute;
		}

	}

	public void HourTextUpdate(){


		if (timemanager.CurrentHour <= 12) {
			if (timemanager.CurrentHour <= 10) {
				CurrentHourString = "0" + (timemanager.CurrentHour - 1);
				CurrentAMPM = "AM";

			} else {
				CurrentHourString =  (timemanager.CurrentHour - 1) + "";
				CurrentAMPM = "AM";
			}
		}
		if (timemanager.CurrentHour == 13) {
			CurrentHourString =  "12";
			CurrentAMPM = "PM";
		}
		if (timemanager.CurrentHour >= 14) {
			CurrentHourString = "0" + (timemanager.CurrentHour - 13);
			CurrentAMPM = "PM";

		}
		if (timemanager.CurrentHour == 23 || timemanager.CurrentHour == 24) {
			CurrentHourString =  (timemanager.CurrentHour - 13) + "";
			CurrentAMPM = "PM";
		}

	}

	public void FullTextUpdate(){
		MinuteTextUpdate ();
		HourTextUpdate ();
		TimeTextUpdate ();
	}


	public void TimeTextUpdate(){

		CurrentTimeText.text = "Year " + timemanager.CurrentYear + spc + "Month " + timemanager.CurrentMonth + spc + "Day " + timemanager.CurrentDay + spc + CurrentHourString  + " : "+ CurrentMinuteString + CurrentAMPM ;
	}



}
