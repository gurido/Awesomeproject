using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamUIManager : MonoBehaviour {


	public GameObject MainCanvas;

	public GameObject DiscordWindow;
	public GameObject CalendarWindow;
	public GameObject BrowserWindow;
	public GameObject DesktopMenu;



	public void StartUIManager(){
		SwitchToDeskTop ();
		DesktopMenu.SetActive (false);
	}
		

	public void SwitchToMainMenu(){

	}

	private void DisableWindow(){
		DiscordWindow.SetActive (false);
		CalendarWindow.SetActive (false);
		BrowserWindow.SetActive (false);

	}

	public void ToggleDesktopMenu(){
		if (DesktopMenu.activeSelf == true) {
			DesktopMenu.SetActive (false);
		} else {
			DesktopMenu.SetActive (true);
		}
	}




	public void SwitchToDeskTop(){
		DisableWindow ();

	}

	public void SwitchToDiscordWindow(){
		DisableWindow ();
		DiscordWindow.SetActive (true);
	

	}
	public void SwitchToBrowserWindow(){
		DisableWindow ();
		BrowserWindow.SetActive (true);

	}
	public void SwitchToCalendarWindow(){
		DisableWindow ();
		CalendarWindow.SetActive (true);

	}

}
