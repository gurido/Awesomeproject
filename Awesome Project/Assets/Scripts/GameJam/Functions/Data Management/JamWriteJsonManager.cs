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


	/*
	public void WriteDatabaseMap(){
		writejson = JsonMapper.ToJson (maindatabase.DatabaseMapList);
		File.WriteAllText(Application.streamingAssetsPath + "/Main Database/MapDatabase.json", writejson.ToString());
	}

	public void WriteMapLogic(){
	writejson = JsonMapper.ToJson (maindatabase.DatabaseMapLogic);
	File.WriteAllText(Application.streamingAssetsPath + "/Main Database/MapType.json", writejson.ToString());

	}*/

}
