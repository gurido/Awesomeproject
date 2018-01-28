using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class JamWriteJsonManager : MonoBehaviour {
	private JamMainDatabaseManager maindatabase;
	JsonData writejson;

	public void StartWriteJsonManager(){
		maindatabase = GetComponent<JamMainDatabaseManager> ();

	}

	public void WriteDatabase(){

	}


	public void WriteChatDatabase(){
		writejson = JsonMapper.ToJson (maindatabase.ChatDatabase);
		File.WriteAllText (Application.streamingAssetsPath + "/GameJam/ChatDatabase.json", writejson.ToString ());

	}

	public void WriteNPCDatabase(){
		writejson = JsonMapper.ToJson (maindatabase.NPCDatabase);
		File.WriteAllText (Application.streamingAssetsPath + "/GameJam/NPCDatabase.json", writejson.ToString ());

	}

	public void WriteCalendarDatabase(){
		writejson = JsonMapper.ToJson (maindatabase.CalendarDatabase);
		File.WriteAllText (Application.streamingAssetsPath + "/GameJam/CalendarDatabase.json", writejson.ToString ());

	}


	public void WritePlayerDatabase(){
		writejson = JsonMapper.ToJson (maindatabase.PlayerDatabase);
		File.WriteAllText (Application.streamingAssetsPath + "/GameJam/PlayerData.json", writejson.ToString ());

	}


}
