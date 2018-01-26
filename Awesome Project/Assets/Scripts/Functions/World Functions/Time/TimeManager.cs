using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public int CurrentYear;
	public int CurrentMonth;
	public int CurrentDay;
	public int CurrentHour;
	public int CurrentMinute;


	private float RealSecond;
	private bool IsTimeStopped;
	private TimePosition CurrentTimePosition;
	private float GlobalTimeSpeed = 1000f;
	private TimePosition PreviousTimePosition;

	public void StartTimeManager(){


		ResetTime ();
		//StopTime ();
		PlayTime ();
		//mainmenumanager = GetComponent<MainMenuManager> ();
	}

	public void UpdateTimeManager(){
		TimePassing ();
	}



	public void StopTime(){
		IsTimeStopped = true;
	}


	public void PlayTime(){
		IsTimeStopped = false;
	}



	private void TimePassing(){
		if(!IsTimeStopped){
			if (RealSecond >= 60f) {
				RealSecond = 0f;
				MinutePassing ();

			} else {
			}
			RealSecond = RealSecond + GlobalTimeSpeed * Time.deltaTime;
		}
		else{
			//time stopped
		}

	}


	public void WriteDownTimePosition(){
		//CurrentTimePosition = new TimePosition(CurrentYear, CurrentMonth,CurrentDay,CurrentHour,CurrentMinute);
	}


	private void ResetTime(){
		CurrentYear = 1;
		CurrentMonth = 1;
		CurrentDay = 1;
		CurrentHour = 1;
		CurrentMinute = 0;
		//mainmenumanager.FullTextUpdate ();

	}

	private void MinutePassing(){
		CurrentMinute = CurrentMinute + 10;
		if(CurrentMinute == 60){
			CurrentMinute = 0;
			HourPassing ();
		}
		else{
		}
			
		//mainmenumanager.MinuteTextUpdate ();
		//mainmenumanager.TimeTextUpdate ();

	}


	private void HourPassing(){
		CurrentHour = CurrentHour + 1;

		if (CurrentHour == 25) {
			CurrentHour = 1;
			DayPassing ();
		} else {
		}
		//mainmenumanager.HourTextUpdate ();
	}


	private void DayPassing(){
		CurrentDay = CurrentDay + 1;
		if (CurrentDay == 31) {
			CurrentDay = 1;
			MonthPassing ();
		}
		else{}
	}


	private void MonthPassing(){
		CurrentMonth =CurrentMonth + 1;

		if (CurrentMonth == 13) {
			CurrentMonth = 1;
			YearPassing ();
		} else {
		}
	}

	private void YearPassing(){
		CurrentYear = CurrentYear + 1;
	}



}


