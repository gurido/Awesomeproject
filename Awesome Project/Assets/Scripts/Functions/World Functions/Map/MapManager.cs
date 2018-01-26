using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
	private MainDatabaseManager maindatabase;
	private WriteJsonManager writedata;

	public void MapManagerStart(){
		maindatabase = GetComponent<MainDatabaseManager> ();
		writedata = GetComponent<WriteJsonManager> ();
	}


	/*public void LoadDatabaseMap(){
		maindatabase.LoadMainDatabaseMap ();
	}*/

	#region GameMap

	public void AddMap(){
		int newmaprealid = maindatabase.DatabaseMapList.Count + 1;
		List<MapObject> mapobjectlist = new List<MapObject> ();
		List<MapTile> maptilelist = new List<MapTile> ();
		GameMap newgamemap = new GameMap (0,"New Map", "New Map",0,1,1,maptilelist, mapobjectlist);
		List<GameMap> newgamemaplist = new List<GameMap> ();
		newgamemaplist.Add (newgamemap);
		MainDatabaseMap CurrentMapSlot = new MainDatabaseMap (newmaprealid,newmaprealid,0,newgamemaplist);
		maindatabase.DatabaseMapList.Add (CurrentMapSlot);

		SaveDatabaseMap ();
	}


	public void DeleteMap(int id){
		if(maindatabase.DatabaseMapList[id].Timesused == 0){
			maindatabase.DatabaseMapList.RemoveAt (id);
		}
		else{
			Debug.Log ("can't delete this map");
		}
		SaveDatabaseMap ();
	}


	public void SaveGameMap(GameMap map){
		maindatabase.DatabaseMapList [BasicStaticVariables.CurrentElement].Map [0] = map;
		Debug.Log ("Current saved element is " + BasicStaticVariables.CurrentElement);
		SaveDatabaseMap ();


	}



	public void SaveDatabaseMap(){
		writedata.WriteDatabaseMap ();
	}

	#endregion


	#region MapLogic

	public void AddLogic(List<int> selection){
		switch(selection.Count){
		case 1:
			int currenttypeid = maindatabase.DatabaseMapLogic [selection[0]].Content.Count;
			List<LogicSubTypeContent> currentsubtypecontentlist = new List<LogicSubTypeContent> ();
			LogicTypeContent currenttypelogic = new LogicTypeContent(currenttypeid,"New type","New Type",currentsubtypecontentlist);
			maindatabase.DatabaseMapLogic [selection[0]].Content.Add (currenttypelogic);
			break;
		case 2:
			int currentsubtypeid = maindatabase.DatabaseMapLogic [selection[0]].Content[selection[1]].SubtypeList.Count;
			LogicSubTypeContent currentsubtypelogic = new LogicSubTypeContent(currentsubtypeid,"New type","New Subype");
			maindatabase.DatabaseMapLogic [selection[0]].Content[selection[1]].SubtypeList.Add (currentsubtypelogic);
			break;
		}
		SaveMapLogic ();
	}
		
	public void DeleteLogic(List<int> selection){
		switch(selection.Count){
		case 2:
			maindatabase.DatabaseMapLogic [selection[0]].Content.RemoveAt (selection[1]);
			break;
		case 3:
			maindatabase.DatabaseMapLogic [selection[0]].Content [selection[1]].SubtypeList.RemoveAt (selection[2]);
			break;
		}
		SaveMapLogic ();
	}
		
	public void SaveTypeLogic(List<int> selection, LogicTypeContent logiccontent){
		maindatabase.DatabaseMapLogic [selection[0]].Content[selection[1]] = logiccontent;
		SaveMapLogic ();
	}

	public void SaveSubtypeLogic(List<int> selection,  LogicSubTypeContent logicsubcontent){
		maindatabase.DatabaseMapLogic [selection[0]].Content[selection[1]].SubtypeList[selection[2]] = logicsubcontent;
		SaveMapLogic ();

	}



	public void SaveMapLogic(){
		writedata.WriteMapLogic ();

	}

	#endregion
}
