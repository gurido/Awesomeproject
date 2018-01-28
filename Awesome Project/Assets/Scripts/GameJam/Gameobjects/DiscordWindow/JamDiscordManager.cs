using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JamDiscordManager : MonoBehaviour {
	private JamStatusManager statusmanager;
	private JamMainDatabaseManager databasemanager;

	public GameObject ChatContainerPrefab;
	public GameObject ChatContentPrefab;

	public List<GameObject> CurrentChatPanelList;
	public GameObject ChatViewport;
	public GameObject ChatContentPanel;
	public Text ChatTitle;

	public int CurrentChatInt;
	public int CurrentChatProgressInt;
	public JamChat CurrentChatData;
	//public List<JamChat> CurrentChatData;

	public Text InputText;
	public bool IsThereInputText;
	public bool IsItYourTurn;

	public void StartDiscordManager(){
		statusmanager = GetComponent<JamStatusManager> ();
		databasemanager = GetComponent<JamMainDatabaseManager> ();
		CurrentChatInt = 0;
		CurrentChatProgressInt = 0;
		InputText.text = "";
		CreateChat ();

	}


	public void UpdateDiscordManager(){


	}

	public void PlayChat(){




	}

	public void CreateChat(){
		CurrentChatPanelList = new List<GameObject> ();
		CurrentChatData = databasemanager.ChatDatabase[CurrentChatInt];
		ChatTitle.text = "@" + databasemanager.NPCDatabase[CurrentChatData.User].Name ;
		for (int i = 0; i < CurrentChatData.Message.Count; i++) {

			string name = "";
			if (CurrentChatData.Message [i].User == -1) {
				//name = databasemanager.JamPlayer.Name;
				name = "Maria";
			} else {
				name = databasemanager.NPCDatabase [CurrentChatData.Message [i].User].Name;
			}
			string message = CurrentChatData.Message [i].Content;

			AddMessage (i,name,message);

		}
		Debug.Log (CurrentChatData.Message.Count);
	}


	private void AddMessage(int id,  string user, string content){

		CurrentChatPanelList.Add (Instantiate (ChatContentPrefab));
		CurrentChatPanelList [id].transform.SetParent (ChatContentPanel.transform, false);
		JamMessagePanel messagedata;
		messagedata = CurrentChatPanelList [id].GetComponent<JamMessagePanel> ();
		Sprite prosprite = Resources.Load<Sprite>("/GameJam/Sprites/Profilepic/pic1");

		messagedata.StartMessagePanel (prosprite,user,content);
	}




	public void ExitButton(){
		statusmanager.SwitchToDesktopMenu ();
	}

	public void MinButton(){
		statusmanager.SwitchToDesktopMenu ();

	}

	public void MaxButton(){


	}

	public void ClickInput(){
		if(IsThereInputText == true){
			InputMessage ();
		}
		else{
			Debug.Log ("It's not your turn to write");
		}
	}

	public void ClickSend(){
		if(IsThereInputText == true){
			SendMessage ();
			FindObjectOfType<JamAudioManager> ().Play ("SendMess");
		}
		else{
			Debug.Log ("Nothing to send");
		}

	}

	private void SendMessage(){

	}


	private void InputMessage(){


	}



}
