using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamCalendarManager : MonoBehaviour {

	private JamStatusManager statusmanager;

	public void StartCalendarManager(){

		statusmanager = GetComponent<JamStatusManager> ();


	}



	public void UpdateCalendarManager(){


	}



	public void CreateCalendarMenu(){






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
