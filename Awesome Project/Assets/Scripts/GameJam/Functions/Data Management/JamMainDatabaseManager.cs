using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class JamMainDatabaseManager : MonoBehaviour {

	private JsonData CurrentJsonData;

	private List<JamChat> CurrentChatDatabase = new List<JamChat>();
	private List<JamNPC> CurrentNPCDatabase = new List<JamNPC>();
	private List<JamPlayer> CurrentPlayerDatabase = new List<JamPlayer>();
	private List<JamCalendarClass> CurrentCalendarDatabase = new List<JamCalendarClass>();

	public JamPlayer JamPlayer = new JamPlayer(0,"player");

	public List<JamChat> ChatDatabase = new List<JamChat>();
	public List<JamNPC> NPCDatabase = new List<JamNPC>();
	public List<JamPlayer> PlayerDatabase = new List<JamPlayer>();
	public List<JamCalendarClass> CalendarDatabase = new List<JamCalendarClass>();


	public void LoadMainDatabase(){
		LoadPlayerData ();
		LoadChatData ();
		LoadNPCData ();
		LoadCalendarData ();


	}


	public void LoadPlayerData(){
		NPCDatabase.Clear ();
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.streamingAssetsPath + "/GameJam/PlayerData.json"));
		NPCDatabase = CurrentNPCDatabase;


	}


	public void LoadChatData(){
		NPCDatabase.Clear ();
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.streamingAssetsPath + "/GameJam/ChatDatabase.json"));
		LoadChatList ();
		ChatDatabase = CurrentChatDatabase;


	}


	public void LoadCalendarData(){
		NPCDatabase.Clear ();
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.streamingAssetsPath + "/GameJam/CalendarDatabase.json"));
		LoadCalendarList ();
		CalendarDatabase = CurrentCalendarDatabase;


	}


	public void LoadNPCData(){
		NPCDatabase.Clear ();
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.streamingAssetsPath + "/GameJam/NPCDatabase.json"));
		LoadNPCList();
		NPCDatabase = CurrentNPCDatabase;

		
	}




	private void LoadPlayerList(){
		CurrentPlayerDatabase.Clear ();
		for(int i =0; i < CurrentJsonData.Count; i++){
			int jamid = (int)CurrentJsonData[i]["ID"];
			string jamnname = CurrentJsonData [i] ["Name"].ToString ();
			CurrentPlayerDatabase.Add (new JamPlayer(jamid,jamnname));
		}


	}

	private void LoadChatList(){
		CurrentChatDatabase.Clear ();
		for(int i =0; i < CurrentJsonData.Count; i++){
			int chatid = (int)CurrentJsonData[i]["ID"];
			int chatname = (int)CurrentJsonData [i] ["User"];
			List<JamMessage> CurrentMessageList = new List<JamMessage> ();
			for(int x = 0; x < CurrentJsonData[i]["Message"].Count; x++){
				int messageid = (int)CurrentJsonData[i]["Message"][x]["ID"];
				int messageuser = (int)CurrentJsonData[i]["Message"][x]["User"];
				string messagecontent = CurrentJsonData[i]["Message"][x]["Content"].ToString();

				CurrentMessageList.Add (new JamMessage(messageid,messageuser,messagecontent));

			}


			CurrentChatDatabase.Add (new JamChat(chatid,chatname,CurrentMessageList));
		}

	}


	private void LoadCalendarList(){
		CurrentCalendarDatabase.Clear ();
		for(int i =0; i < CurrentJsonData.Count; i++){
			int calendarday = (int)CurrentJsonData[i]["Day"];
			int calendardayweek = (int)CurrentJsonData [i] ["Weekday"];
			int calendarevent = (int)CurrentJsonData[i]["Event"];

			CurrentCalendarDatabase.Add (new JamCalendarClass(calendarday,calendardayweek,calendarevent));
		}

	}






	private void LoadNPCList(){
		CurrentNPCDatabase.Clear ();
		for(int i =0; i < CurrentJsonData.Count; i++){
			int jamnpcid = (int)CurrentJsonData[i]["ID"];
			string jamnpcname = CurrentJsonData [i] ["Name"].ToString ();
			int jamnpcgender = (int)CurrentJsonData[i]["Gender"];
			CurrentNPCDatabase.Add (new JamNPC(jamnpcid,jamnpcname,jamnpcgender));
		}
	}



}
