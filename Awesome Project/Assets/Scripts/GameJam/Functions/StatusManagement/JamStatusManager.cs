using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamStatusManager : MonoBehaviour {
	public int statusmanagerstate;
	public int gameprogress;
	public GameObject maincanvasmenu;

	private JamUIManager uimanager;
	private JamWriteJsonManager writejsonmanager;
	private JamMainDatabaseManager maindatabasemanager;

	private JamCalendarManager calendarmanager;
	private JamDesktopManager desktopmanager;
	private JamDiscordManager discordmanager;
	private JamBrowserManager browsermanager;
	private JamLogInMenuManager loginmanager;

	public void StatusManagerStart(){
		FindScripts ();
		maindatabasemanager.LoadMainDatabase ();
		StartScripts ();

		SwitchToLogInScreen ();
		//SwitchToDesktopMenu ();

	}


	private void FindScripts(){
		uimanager = GetComponent<JamUIManager> ();
		writejsonmanager = GetComponent<JamWriteJsonManager> ();
		maindatabasemanager = GetComponent<JamMainDatabaseManager> ();

		calendarmanager = GetComponent<JamCalendarManager> ();
		desktopmanager = GetComponent<JamDesktopManager> ();
		discordmanager = GetComponent<JamDiscordManager> ();
		browsermanager = GetComponent<JamBrowserManager> ();
		loginmanager = GetComponent<JamLogInMenuManager> ();


	}

	private void StartScripts(){
		uimanager.StartUIManager ();
		writejsonmanager.StartWriteJsonManager ();

		calendarmanager.StartCalendarManager ();
		desktopmanager.StartDesktopManager ();
		discordmanager.StartDiscordManager ();
		browsermanager.StartBrowserManager ();
		loginmanager.StartLogInMenuManager ();


	}





	public void SwitchToLogInScreen(){
		statusmanagerstate = 0;
		uimanager.SwitchToLogInScreen ();

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



	public void SwitchToSettingsWindow(){

	}

	public void StatusManagerUpdate(){



	}





}
