using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroUIManager : MonoBehaviour {
	public GameObject IntroMenuPanel;
	public GameObject SelectGamePanel;

	public void IntroUIManagerStart(){
		


	}



	public void SwitchToIntroMenuPanel(){
		IntroMenuPanel.SetActive (true);
		SelectGamePanel.SetActive (false);

	}

	public void SwitchToSelectGameMenuPanel(){

		IntroMenuPanel.SetActive (false);
		SelectGamePanel.SetActive (true);
	}





}
