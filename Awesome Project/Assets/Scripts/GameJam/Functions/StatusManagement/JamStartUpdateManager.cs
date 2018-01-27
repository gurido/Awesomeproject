using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamStartUpdateManager : MonoBehaviour {

	JamStatusManager statusmanager;


	void Start () {
		statusmanager = GetComponent<JamStatusManager> ();
		statusmanager.StatusManagerStart ();

	}
	
	void Update () {
		statusmanager.StatusManagerUpdate ();
	}
}
