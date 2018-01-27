using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamStatusManager : MonoBehaviour {
	public int statusmanagerstate;
	public GameObject maincanvasmenu;

	private JamUIManager uimanager;
	private JamWriteJsonManager writejsonmanager;

	private JamCalendarManager calendarmanager;
	private JamDesktopManager desktopmanager;
	private JamDiscordManager discordmanager;
	private JamBrowserManager browsermanager;

	public void StatusManagerStart(){
		FindScripts ();
		StartScripts ();
		SwitchToDesktopMenu ();

	}


	private void FindScripts(){
		uimanager = GetComponent<JamUIManager> ();
		writejsonmanager = GetComponent<JamWriteJsonManager> ();
		calendarmanager = GetComponent<JamCalendarManager> ();
		desktopmanager = GetComponent<JamDesktopManager> ();
		discordmanager = GetComponent<JamDiscordManager> ();
		browsermanager = GetComponent<JamBrowserManager> ();


	}

	private void StartScripts(){
		uimanager.StartUIManager ();
		writejsonmanager.StartWriteJsonManager ();
		calendarmanager.StartCalendarManager ();
		desktopmanager.StartDesktopManager ();
		discordmanager.StartDiscordManager ();
		browsermanager.StartBrowserManager ();


	}

	public void SwitchToDesktopMenu(){
		statusmanagerstate = 1;
		uimanager.SwitchToDeskTop ();


	}


	public void SwitchToDiscordWindow(){
		statusmanagerstate = 2;
		uimanager.SwitchToDiscordWindow ();

	}


	public void SwitchToBrowserWindow(){
		statusmanagerstate = 3;
		uimanager.SwitchToBrowserWindow ();



	}


	public void SwitchToCalendarWindow(){
		statusmanagerstate = 4;
		uimanager.SwitchToCalendarWindow ();


	}





	public void StatusManagerUpdate(){



	}





}
