using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamLogInMenuManager : MonoBehaviour {

	private JamStatusManager statusmanager;


	public void StartLogInMenuManager(){
		statusmanager = GetComponent<JamStatusManager>();

	}


	public void ClickLogIn(){
		statusmanager.SwitchToDesktopMenu ();
		FindObjectOfType<JamAudioManager> ().Play ("Click");



	}





}
