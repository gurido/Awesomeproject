using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamDesktopManager : MonoBehaviour {

	private JamStatusManager statusmanager;
	private JamUIManager uimanager;
	private JamAudioManager audiomanager;


	public void StartDesktopManager(){
		statusmanager = GetComponent<JamStatusManager> ();
		uimanager = GetComponent<JamUIManager> ();
		audiomanager = GameObject.Find ("_AudioManager").GetComponent<JamAudioManager> ();

	}


	public void UpdateDesktopManager(){

	}


	public void ClickDiscord(){
		statusmanager.SwitchToDiscordWindow ();
		audiomanager.Play ("Click");

	}

	public void ClickBrowser(){
		statusmanager.SwitchToBrowserWindow ();
		FindObjectOfType<JamAudioManager> ().Play ("Click");

	}

	public void ClickCalendar(){
		statusmanager.SwitchToCalendarWindow ();
		audiomanager.Play ("Click");


	}

	public void LogOut(){
		statusmanager.SwitchToLogInScreen ();
		uimanager.ToggleDesktopMenu ();
		audiomanager.Play ("LogOut");
	}



}
