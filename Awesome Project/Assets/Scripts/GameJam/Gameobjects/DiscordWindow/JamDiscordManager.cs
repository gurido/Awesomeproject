using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamDiscordManager : MonoBehaviour {

	private JamStatusManager statusmanager;

	public void StartDiscordManager(){
		statusmanager = GetComponent<JamStatusManager> ();


	}


	public void UpdateDiscordManager(){


	}

	public void ExitButton(){
		statusmanager.SwitchToDesktopMenu ();
	}

	public void MinButton(){
		statusmanager.SwitchToDesktopMenu ();

	}

	public void MaxButton(){


	}




}
