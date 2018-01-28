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
	public JamChat CurrentChatData;
	//public List<JamChat> CurrentChatData;

	public void StartDiscordManager(){
		statusmanager = GetComponent<JamStatusManager> ();
		databasemanager = GetComponent<JamMainDatabaseManager> ();
		CurrentChatInt = 0;
		CreateChat ();

	}


	public void UpdateDiscordManager(){


	}



	public void CreateChat(){
		CurrentChatPanelList = new List<GameObject> ();
		CurrentChatData = databasemanager.ChatDatabase[CurrentChatInt];
		ChatTitle.text = "@" + databasemanager.NPCDatabase[CurrentChatData.User].Name ;
		for (int i = 0; i < CurrentChatData.Message.Count; i++) {

			CurrentChatPanelList.Add (Instantiate (ChatContentPrefab));
			CurrentChatPanelList [i].transform.SetParent (ChatContentPanel.transform, false);
			JamMessagePanel messagedata;
			messagedata = CurrentChatPanelList [i].GetComponent<JamMessagePanel> ();
			Sprite prosprite = Resources.Load<Sprite>("/GameJam/Sprites/Profilepic/pic1");
			string name = databasemanager.NPCDatabase [CurrentChatData.Message [i].User].Name;
			string message = CurrentChatData.Message [i].Content;
			messagedata.StartMessagePanel (prosprite,name,message);

		}
		Debug.Log (CurrentChatData.Message.Count);





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
