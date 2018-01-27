using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamBrowserManager : MonoBehaviour {

	private JamStatusManager statusmanager;

	public void StartBrowserManager(){
		statusmanager = GetComponent<JamStatusManager> ();

	}

	public void UpdateBrowserManager(){

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
