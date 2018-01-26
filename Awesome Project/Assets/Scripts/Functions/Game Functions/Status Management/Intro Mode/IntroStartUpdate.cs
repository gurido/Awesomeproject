using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroStartUpdate : MonoBehaviour {

	private IntroStatusManager introstatusmanager;

	void Awake(){

	}

	void Start () {
		introstatusmanager = GetComponent<IntroStatusManager> ();
		introstatusmanager.StartIntroStatusManager ();
	}
	
	void Update () {
		introstatusmanager.IntroMenuUpdate ();
	}
}
