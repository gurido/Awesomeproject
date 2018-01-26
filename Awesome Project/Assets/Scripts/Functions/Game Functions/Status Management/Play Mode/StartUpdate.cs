using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUpdate : MonoBehaviour {

	void Awake(){
		GetComponent<GameStatusManager> ().StatusManagerAwake ();
	}

	void Start () {
		GetComponent<GameStatusManager> ().StatusManagerStart ();

	}


	void Update () {
		GetComponent<GameStatusManager> ().UpdateGameStatus ();

	}
}
