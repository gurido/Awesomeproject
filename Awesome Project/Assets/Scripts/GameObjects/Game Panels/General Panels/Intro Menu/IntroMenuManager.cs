using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IntroMenuManager : MonoBehaviour {

	private IntroStatusManager introstatusmanager;

	public void IntroMenuManagerStart(){
		introstatusmanager = GetComponent<IntroStatusManager> ();
	}

	public void IntroMenuManagerGetKey(){

	}

	public void SwitchToMyGames(){
		introstatusmanager.SwitchToSelectGame ();
	}
		
	public void SwitchToBuildGame(){
		introstatusmanager.SwitchToBuidSession ();
	}

	public void SwitchToBuildAssets(){
		introstatusmanager.SwitchToBuildAssets ();
	}

	public void SwitchToOnline(){
		introstatusmanager.SwitchToOnlineSession ();
	}




}
