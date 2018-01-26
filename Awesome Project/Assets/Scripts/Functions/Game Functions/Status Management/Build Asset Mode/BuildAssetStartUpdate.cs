using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildAssetStartUpdate : MonoBehaviour {

	BuildAssetStatusManager statusmanager;

	void Start () {
		statusmanager = GetComponent<BuildAssetStatusManager> ();
		statusmanager.StatusManagerStart ();
	}
	
	void Update () {
		statusmanager.StatusManagerUpdate ();
		
	}
}
