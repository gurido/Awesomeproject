using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollPanelManager : MonoBehaviour {

	public int ID;
	public ScrollPanel Panel;

	public Text TitleText;
	public GameObject ScrollContentPanel;
	public List<GameObject> ContentList;

	public void StartScrollPanelManager(){


	}

	private void UpdatePanel(){
		DeleteContent ();
		LoadContent ();
	}


	private void LoadContent(){



	}



	private void DeleteContent(){
		ContentList = new List<GameObject> ();


	}



}
