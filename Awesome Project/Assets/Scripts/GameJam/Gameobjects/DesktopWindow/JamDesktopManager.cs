using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamDesktopManager : MonoBehaviour {

	private JamStatusManager statusmanager;

	public void StartDesktopManager(){
		statusmanager = GetComponent<JamStatusManager> ();

	}


	public void UpdateDesktopManager(){

	}


	public void ClickDiscord(){
		statusmanager.SwitchToDiscordWindow ();

	}

	public void ClickBrowser(){
		statusmanager.SwitchToBrowserWindow ();

	}

	public void ClickCalendar(){
		statusmanager.SwitchToCalendarWindow ();

	}


}
