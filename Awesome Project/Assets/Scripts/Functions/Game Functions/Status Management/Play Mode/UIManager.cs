using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.IO;



public class UIManager : MonoBehaviour {

	private string maincanvaspath = "MainCanvas";
	private GameObject maincanvas;
	private GameObject canvasObj1;
	private GameObject canvasObj2;
	private GameObject canvasObj3;
	private List<int> Layer2PanelList = new List<int>();

	private DatabaseManager database;

	public void UIManagerStart(){
		database = GetComponent<DatabaseManager> ();
		maincanvas = GameObject.Find ( GameobjectPathDictionary.GamePanelPath[maincanvaspath]);

	    LoadLayers ();
	}


	public void UIManagerEnterGame(){
		LoadPauseMenu ();
		SetLayer2PanelList ();
		CreateLayer2 ();
		LoadLayer1 (3);
	}


	private void LoadLayers(){
		//Debug.Log (database.uipanelList[0].PanelName);
		canvasObj1 = Instantiate (database.uipanelList[0].Panel);
		canvasObj1.transform.SetParent (maincanvas.transform,false);
		canvasObj2 = Instantiate (database.uipanelList[0].Panel);
		canvasObj2.transform.SetParent (maincanvas.transform,false);
		canvasObj3 = Instantiate (database.uipanelList[0].Panel);
		canvasObj3.transform.SetParent (maincanvas.transform,false);
	}
		
	//Layer 1

	private void LoadLayer1(int id){
		GameObject obj = Instantiate (database.uipanelList[id].Panel);
		obj.transform.SetParent (canvasObj1.transform,false);
	}

	private void SwitchLayer1(int id){
		DestroyLayer1Child ();
		LoadLayer1 (id);

	}

	private void DestroyLayer1Child(){
		int numChildren = canvasObj1.transform.childCount;
		if (numChildren > 0) {
			for(int i = 0; i < numChildren; i ++){
				DestroyImmediate (canvasObj1.transform.GetChild(i).gameObject);
			}
		}
	}


	//Layer 2

	private void SetLayer2PanelList(){
		for (int i = 4; i < 14; i++) {
			Layer2PanelList.Add (i);
		}
	}

	private void CreateLayer2(){
		for (int i = 0; i < Layer2PanelList.Count; i++) {
			LoadLayer2 (Layer2PanelList[i]);
		}
		SetLayer2Deactive ();

	}

	private void SetLayer2Deactive(){
		int numChildren = canvasObj2.transform.childCount;
		for (int i = 0; i < numChildren; i ++){
			canvasObj2.transform.GetChild (i).gameObject.SetActive (false);
		}
	}

	private void DeactiveLayer2(){

	}

	private void LoadLayer2(int id){
		GameObject obj = Instantiate (database.uipanelList[id].Panel);
		obj.transform.SetParent (canvasObj2.transform,false);
	}	


	private void SwitchLayer2(int id){
		canvasObj2.SetActive (true);
		SetLayer2Deactive ();
		switch (id) {
		case 4://npc view
			canvasObj2.transform.GetChild (0).gameObject.SetActive (true);
			break;
		case 5://character inventory
			canvasObj2.transform.GetChild (1).gameObject.SetActive (true);
			break;
		case 6://character inspection
			canvasObj2.transform.GetChild (2).gameObject.SetActive (true);
			break;
		case 7://character creation
			canvasObj2.transform.GetChild (3).gameObject.SetActive (true);
			break;
		case 8://player menu
			canvasObj2.transform.GetChild (4).gameObject.SetActive (true);
			break;
		case 9://dialogue panel
			canvasObj2.transform.GetChild (5).gameObject.SetActive (true);
			break;
		case 10://diary panel
			canvasObj2.transform.GetChild (6).gameObject.SetActive (true);
			break;
		case 11://write diary panel
			canvasObj2.transform.GetChild (7).gameObject.SetActive (true);
			break;
		case 12://map panel
			canvasObj2.transform.GetChild (8).gameObject.SetActive (true);
			break;
		default:
			break;
		}

	}



	public void SwitchToMainGamePanel(){//3
		canvasObj2.SetActive (false);
		canvasObj1.SetActive (true);
		//SwitchLayer1(3);
	}

	public void SwitchToNPCViewPanel(){//4
		SwitchLayer2(4);
	}

	public void SwitchToCharacterInventoryPanel(){//5
		SwitchLayer2(5);
	}

	public void SwitchToCharacterInspectionPanel(){//6
		SwitchLayer2(6);
	}

	public void SwitchToCharacterCreationPanel(){//7
		SwitchLayer2(7);
	}

	public void SwitchToPlayerMenuPanel(){//8
		SwitchLayer2(8);
	}

	public void SwitchToDialoguePanel(){//9
		SwitchLayer2(9);
	}
		
	public void SwitchToDiaryPanel(){//10
		SwitchLayer2(10);
	}


	public void SwitchToWriteDiaryPanel(){//11
		SwitchLayer2(11);
	}

	public void SwitchToMapPanel(){
		SwitchLayer2 (12);
	}



	//Layer 3

	private void LoadPauseMenu(){
		GameObject obj = Instantiate (database.uipanelList[2].Panel);
		obj.transform.SetParent (canvasObj3.transform,false);
		canvasObj3.SetActive (false);
	}


	public void SwitchToPausePanel(){
		canvasObj3.SetActive (true);
	}
	public void TurnOffPausePanel(){
		canvasObj3.SetActive (false);
	}


}

