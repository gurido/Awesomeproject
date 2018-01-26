using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class WriteJsonManager : MonoBehaviour {

	private MainDatabaseManager maindatabase;
	JsonData writejson;

	public void StartWriteJsonManager(){
		maindatabase = GetComponent<MainDatabaseManager> ();

	}


	public void WriteDatabase(){

	}


	public void WriteDatabaseMap(){
		writejson = JsonMapper.ToJson (maindatabase.DatabaseMapList);
		File.WriteAllText(Application.streamingAssetsPath + "/Main Database/MapDatabase.json", writejson.ToString());
	}


	public void WriteMapLogic(){
		writejson = JsonMapper.ToJson (maindatabase.DatabaseMapLogic);
		File.WriteAllText(Application.streamingAssetsPath + "/Main Database/MapType.json", writejson.ToString());

	}

	public void WritePlayerData(){

	}


	public void WriteGameFile(){

	}


	public void WriteSaveFile(){


	}










}
