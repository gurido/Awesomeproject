using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class MainDatabaseManager : MonoBehaviour {
	private JsonData CurrentJsonData;

	private List<MainDatabaseMap> CurrentMapList = new List<MainDatabaseMap> ();
	private List<DataLogic> CurrentDataLogic = new List<DataLogic>();


	public List<MainDatabaseMap> DatabaseMapList = new List<MainDatabaseMap>();
	public List<DataLogic> DatabaseMapLogic = new List<DataLogic>();
	//public List<MainDatabaseCharacter> DatabaseCharacterList = new List<MainDatabaseCharacter>();




	public void LoadPlayer(){
	}

	public void LoadMainDatabase(){
	}
		

	private void LoadLogicContent(){
		for(int i = 0; i < CurrentJsonData.Count; i ++){
			int ID = (int)CurrentJsonData [i] ["ID"];
			string Name = CurrentJsonData [i] ["Name"].ToString ();
			List<LogicTypeContent> TypeList = new List<LogicTypeContent> ();

			for(int x = 0; x < CurrentJsonData[i]["Content"].Count; x ++){
				int TypeID = (int)CurrentJsonData [i] ["Content"] [x] ["ID"];
				string TypeName = CurrentJsonData [i] ["Content"] [x] ["Name"].ToString();
				string TypeDescription = CurrentJsonData [i] ["Content"] [x] ["Description"].ToString ();
				List<LogicSubTypeContent> SubTypeList = new List<LogicSubTypeContent> ();

				for(int y = 0; y < CurrentJsonData[i]["Content"][x]["SubtypeList"].Count; y ++){
					int SubtypeID = (int)CurrentJsonData [i] ["Content"] [x] ["SubtypeList"] [y] ["ID"];
					string SubtypeName = CurrentJsonData[i]["Content"][x]["SubtypeList"][y]["Name"].ToString();
					string SubtypeDescription = CurrentJsonData [i] ["Content"] [x] ["SubtypeList"] [y] ["Description"].ToString ();
					LogicSubTypeContent NewSubtype = new LogicSubTypeContent (SubtypeID, SubtypeName,SubtypeDescription);
					SubTypeList.Add (NewSubtype);
				}
				LogicTypeContent NewType = new LogicTypeContent (TypeID,TypeName,TypeDescription,SubTypeList);	
				TypeList.Add (NewType);
			}

			DataLogic newlogic = new DataLogic (ID,Name, TypeList);
			CurrentDataLogic.Add (newlogic);
		}
	}




	#region LoadMap

	public void LoadMapLogicContent(){
		DatabaseMapLogic.Clear ();
		CurrentJsonData = JsonMapper.ToObject(File.ReadAllText(Application.streamingAssetsPath + "/Main Database/MapType.json"));
		LoadLogicContent ();
		DatabaseMapLogic = CurrentDataLogic;

	}
	public void LoadMainDatabaseMap(){
		DatabaseMapList.Clear ();
		CurrentJsonData = JsonMapper.ToObject(File.ReadAllText(Application.streamingAssetsPath + "/Main Database/MapDatabase.json"));
		LoadMapList ();
		DatabaseMapList = CurrentMapList;
	}


	private void LoadMapList(){
		for (int i = 0; i < CurrentJsonData.Count; i++) {


			int mapid = (int)CurrentJsonData[i]["Map"][0]["ID"];
			string mapname = CurrentJsonData[i]["Map"][0]["Name"].ToString();
			string mapdescription = CurrentJsonData[i]["Map"][0]["Description"].ToString();
			int maptype = (int)CurrentJsonData[i]["Map"][0]["Type"];
			int mapsizex = (int)CurrentJsonData[i]["Map"][0]["SizeX"];
			int mapsizey = (int)CurrentJsonData[i]["Map"][0]["SizeY"];
			List<MapObject> mapobjectlist = new List<MapObject>();
			List<MapTile> maptilelist = new List<MapTile> ();

			for (int x = 0; x < CurrentJsonData [i] ["Map"] [0]["MapObjectList"].Count; x++) {
				int mapobjecttype = (int)CurrentJsonData[i]["Map"][0]["MapObjectList"][x]["Type"];
				int mapobjectid = (int)CurrentJsonData[i]["Map"][0]["MapObjectList"][x]["ID"];
				int mapobjectpositionx = (int)CurrentJsonData[i]["Map"][0]["MapObjectList"][x]["PositionX"];
				int mapobjectpositiony = (int)CurrentJsonData[i]["Map"][0]["MapObjectList"][x]["PositionY"];
				MapObject mapobject = new MapObject (mapobjecttype,mapobjectid,mapobjectpositionx,mapobjectpositiony);
				mapobjectlist.Add (mapobject);
			}

			for (int y = 0; y < CurrentJsonData [i] ["Map"] [0]["MapTileList"].Count; y++) {
				int maptiletype = (int)CurrentJsonData[i]["Map"][0]["MapTileList"][y]["TileType"];
				int maptileid = (int)CurrentJsonData[i]["Map"][0]["MapTileList"][y]["ID"];
				int maptilepositionx = (int)CurrentJsonData[i]["Map"][0]["MapTileList"][y]["PositionX"];
				int maptilepositiony = (int)CurrentJsonData[i]["Map"][0]["MapTileList"][y]["PositionY"];
				MapTile maptile = new MapTile (maptiletype,maptileid,maptilepositionx,maptilepositiony);
				maptilelist.Add (maptile);
			}
			GameMap CurrentGameMap = new GameMap (mapid,mapname,mapdescription,maptype,mapsizex,mapsizey,maptilelist, mapobjectlist);
			List<GameMap> CurrentGameMapList = new List<GameMap> ();
			CurrentGameMapList.Add (CurrentGameMap);
			CurrentMapList.Add (new MainDatabaseMap((int)CurrentJsonData[i]["RealID"],(int)CurrentJsonData[i]["EditorID"],(int)CurrentJsonData[i]["Timesused"],CurrentGameMapList));
		}





	}
	#endregion

	private void LoadMainDatabaseCharacter(){



	}



}
