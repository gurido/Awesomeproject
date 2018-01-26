using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatusManager : MonoBehaviour {
	public bool IsGameInSession = false;
	public int GameStatus;

	private GameObject Layer1;
	private GameObject Layer2;
	private GameObject Layer3;

	private DatabaseManager databasemanager;
	private UIManager uimanager;
	private TimeManager timemanager;
	//private WriteJsonManager writejsonmanager;

	private MainMenuManager mainmenumanager;
	private PauseMenuManager pausemenumanager;
	private NPCMenuManager npcmenumanager;
	private InventoryMenuManager inventorymenumanager;
	private CharacterCreationMenuManager charactercreationmenumanager;
	private CharacterInspectionManager characterinspectionmenumanager;
	private DiaryEntryMenuManager diaryentrymenumanager;
	private DiaryInputManager diaryinputmenumanager;
	private PlayerCharacterMenuManager playercharactermenumanager;
	private MapMenuManager mapmenumanager;

	public void StatusManagerAwake(){


	}

	public void StatusManagerStart(){
		FindHigherUpScript ();
		databasemanager.ConstructGame ();
		uimanager.UIManagerStart ();
		StartCoroutines ();
		EnterGame ();


	}


	public void EnterGame(){
		StartHigherUpScripts ();
		FindLayers ();
		FindScripts ();
		ChangeStatusToMainMenu ();
		IsGameInSession = true;

	}

	private void FindHigherUpScript(){
		uimanager = GetComponent<UIManager> ();
		timemanager = GetComponent<TimeManager> ();
		databasemanager = GetComponent<DatabaseManager> ();
		//writejsonmanager = GetComponent<WriteJsonManager> ();
	}

	private void StartHigherUpScripts(){
		uimanager.UIManagerEnterGame ();
		GetComponent<PlayerManager> ().PlayerManagerStart ();
		GetComponent<TimeManager>().StartTimeManager();
		GetComponent<ItemManager> ().StartItemManager ();
		GetComponent<InventoryManager> ().InventoryManagerStart ();
		GetComponent<CharacterManager> ().CharacterManagerStart ();
		GetComponent<CharacterCreationManager> ().CharacterCreationManagerStart ();
	}


	private void FindLayers(){
		Layer1 = GameObject.Find ("MainCanvas").gameObject.transform.GetChild (0).gameObject;
		Layer2 = GameObject.Find ("MainCanvas").gameObject.transform.GetChild (1).gameObject;
		Layer3 = GameObject.Find ("MainCanvas").gameObject.transform.GetChild (2).gameObject;
	}

	private void FindScripts(){
		pausemenumanager = Layer3.GetComponentInChildren<PauseMenuManager>();
		mainmenumanager = Layer1.GetComponentInChildren<MainMenuManager>();
		inventorymenumanager = Layer2.transform.GetChild (1).GetComponent<InventoryMenuManager> ();
		characterinspectionmenumanager = Layer2.transform.GetChild (2).GetComponent<CharacterInspectionManager> ();
		charactercreationmenumanager = Layer2.transform.GetChild (3).GetComponent<CharacterCreationMenuManager> ();
		playercharactermenumanager = Layer2.transform.GetChild (4).GetComponent<PlayerCharacterMenuManager> ();
		diaryinputmenumanager = Layer2.transform.GetChild (7).GetComponent<DiaryInputManager> ();
		npcmenumanager = Layer2.transform.GetChild (0).GetComponent<NPCMenuManager> ();
		diaryentrymenumanager = Layer2.transform.GetChild (6).GetComponent<DiaryEntryMenuManager> ();
		mapmenumanager = Layer2.transform.GetChild (8).GetComponent<MapMenuManager> ();

	}



	public void UpdateGameStatus(){
		
		if (IsGameInSession == true) {
			GameSessionKeyInputs ();

		} else {

		}

	}



	private void GetEscapeKey(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(pausemenumanager.IsPauseMenuActive == false){
				//writejsonmanager.WriteJson ();
				ChangeStatusToPauseMenu ();

			}
			else{
				pausemenumanager.ExitPauseMenu ();
			}
		}
	}

	


	public void ChangeStatusToMainMenu(){
		GameStatus = 0;
		uimanager.SwitchToMainGamePanel ();
		mainmenumanager.MainMenuManagerStart();
	}

	public void ChangeStatusToWriteDiary(){
		GameStatus = 1;
		uimanager.SwitchToWriteDiaryPanel ();
		diaryinputmenumanager.DiaryManagerStart ();

	}

	public void ChangeStatusToNPCMenu(){
		GameStatus = 2;
		uimanager.SwitchToNPCViewPanel ();
		npcmenumanager.NPCMenuManagerStart ();
	}




	public void ChangeStatusToDiaryMenu(){
		GameStatus = 3;
		uimanager.SwitchToDiaryPanel ();
		diaryentrymenumanager.DiaryEntryMenuManagerStart ();
	}

	public void ChangeStatusToPlayerMenu(){
		GameStatus = 4;
		uimanager.SwitchToPlayerMenuPanel ();
		playercharactermenumanager.PlayerCharacterMenuStart ();
	}

	public void ChangeStatusToCharacterCreationMenu(){
		GameStatus = 5;
		uimanager.SwitchToCharacterCreationPanel ();
		charactercreationmenumanager.CharacterCreationMenuStart ();

	}

	public void ChangeStatusToCharacterInspectionMenu(){
		GameStatus = 6;
		uimanager.SwitchToCharacterInspectionPanel ();
		characterinspectionmenumanager.CharacterInspectoinMenuStart ();
	}


	public void ChangeStatusToCharacterInventoryMenu(){
		GameStatus = 7;
		uimanager.SwitchToCharacterInventoryPanel ();
		inventorymenumanager.InventoryMenuManagerStart ();

	}

	public void ChangeStatusToMapMenu(){
		GameStatus = 8;
		uimanager.SwitchToMapPanel ();
		mapmenumanager.MapMenuManagerStart ();
	}

	public void ChangeStatusToPauseMenu(){
		uimanager.SwitchToPausePanel ();
		pausemenumanager.PauseMenuManagerStart ();
	}

	public void TurnOffPauseMenu(){
		uimanager.TurnOffPausePanel ();
	}


	private void StartCoroutines(){
		//StartCoroutine (Example (5f));
	}


	IEnumerator Example(float wait){

		Debug.Log ("1");
		yield return new WaitForSeconds(wait);
		Debug.Log ("2");
	}

	private void GameSessionKeyInputs(){
		GetEscapeKey ();

		if (pausemenumanager.IsPauseMenuActive == true) {
			//game is paused
		} else {
			switch (GameStatus) {
			case 0: //Main Menu Mode
				mainmenumanager.MainMenuManagerUpdate();
				break;
			case 1://Write Diary Mode
				diaryinputmenumanager.DiaryManagerUpdate();
				//GetComponent<DiaryInputManager> ().DiaryManagerUpdate ();
				break;
			case 2: //NPC Menu Mode
				npcmenumanager.NPCMenuManagerUpdate();
				//GetComponent<NPCMenuManager>().NPCMenuManagerUpdate();
				break;
			case 3: //Diary Menu Mode
				break;
			case 4://Player Menu Mode 
				break;
			case 5:// Character Creation Menu Mode
				break;
			case 6://Character Inspection Menu Mode
				characterinspectionmenumanager.CharacterInspectionMenuUpdate();
				//GetComponent<CharacterInspectionManager>().CharacterInspectionMenuUpdate();
				break;
			case 7://Character Inventory Menu Mode
				inventorymenumanager.InventoryMenuManagerUpdate();
				//GetComponent<InventoryMenuManager>().InventoryMenuManagerUpdate();
				break;
			default:
				break;
			}
			timemanager.UpdateTimeManager ();
		}

	}

}
