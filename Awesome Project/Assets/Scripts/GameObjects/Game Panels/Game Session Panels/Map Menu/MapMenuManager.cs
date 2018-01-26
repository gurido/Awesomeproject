using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMenuManager : MonoBehaviour {
	private GameStatusManager gamestatusmanager;
	private DatabaseManager database;

	private bool IsWorldMapCreated = false;
	public GameObject WorldMapPanel;
	public Transform tilePrefab;

	private Vector3 TileScale = new Vector3(50,50,1);
	public int TileXScaleValue;
	public int TileyScaleValue;

	public List<MapObject> CurrentMapObjectList = new List<MapObject> ();
	public int CurrentGameMapID;
	public GameMap CurrentGameMap;

	public void MapMenuManagerStart(){

		if (IsWorldMapCreated == false) {
			gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
			database = GameObject.Find ("_GameManager").GetComponent<DatabaseManager> ();
			CurrentGameMapID = 1;
			LoadGameMapContent (CurrentGameMapID);
			CreateGameMap ();
		} else {
		}
	}




	public void PressOnTile(int type, int id){
		//Debug.Log ("Tile Object ID is " + id);
		//Debug.Log ( WorldDictionary.MapObjectTypeDictionary[type] );
		switch(type){
		case -1://does not exist
			break;
		case 1://wall
			break;
		case 2://access point
			SwitchGameMap(id);
			break;
		case 3://furniture
			break;
		case 4://water
			break;
		case 5://
			break;

		default:
			break;

		}


	}

	public void SwitchGameMap(int newmap){
		DestroyPreviousMap ();
		CurrentGameMapID = newmap;
		LoadGameMapContent (newmap);
		CreateGameMap ();

	}




	private void LoadGameMapContent(int map){

		CurrentGameMapID = map;
		CurrentGameMap = database.GameMapDatabase [map];
		CurrentMapObjectList = CurrentGameMap.MapObjectList;

		//Debug.Log (CurrentGameMap.Name);

	}

	private void DestroyPreviousMap(){

		foreach (Transform child in WorldMapPanel.transform) {
			Destroy (child.gameObject);
		}


	}



	private void CreateGameMap(){
		int tilenumber = 0;

		for (int x = 0; x < CurrentGameMap.SizeX; x++) {
			for (int y = 0; y < CurrentGameMap.SizeY; y++) {
					
				Vector3 tilePosition = new Vector3 ((-CurrentGameMap.SizeX / 2 + 0.5f + x)*TileScale.x ,( -CurrentGameMap.SizeY / 2 + 0.5f + y)*TileScale.y  , 0);
				Transform newTile = Instantiate (tilePrefab, tilePosition, Quaternion.Euler (Vector3.right * 0)) as Transform;
				newTile.gameObject.transform.localScale = TileScale;
				newTile.transform.SetParent (WorldMapPanel.transform, false);

				TileData tiledata = newTile.GetComponent<TileData> ();
				tiledata.TileID = tilenumber;
				tilenumber = tilenumber + 1;
				tiledata.Xposition = x;
				tiledata.Yposition = y;
				for(int i = 0; i < CurrentMapObjectList.Count; i ++){
					if (CurrentMapObjectList [i].PositionX == x && CurrentMapObjectList [i].PositionY == y) {
						tiledata.tileobject = CurrentMapObjectList [i];
						//Debug.Log ("Found " + tiledata.tileobject.Type + " thing at " + x + " and " + y);
						break;

					} else {
						tiledata.tileobject = new MapObject ();
					}
				}
				tiledata.StartTileData ();
			}
		}
		IsWorldMapCreated = true;
	}

	





	private void UpdateWorldMap(){
		int tileid = 0;
		for (int x = 0; x < CurrentGameMap.SizeX; x++) {
			for (int y = 0; y < CurrentGameMap.SizeY; y++) {
				TileData tiledata = WorldMapPanel.transform.GetChild (tileid).GetComponent<TileData> ();
				for(int i = 0; i < CurrentMapObjectList.Count; i ++){
					if (CurrentMapObjectList [i].PositionX == x && CurrentMapObjectList [i].PositionY == y) {
						tiledata.tileobject = CurrentMapObjectList [i];
						Debug.Log ("Found " + tiledata.tileobject.Type + " thing at " + x + " and " + y);
						break;
					} else {
						tiledata.tileobject = new MapObject ();
					}
				}
				tileid = tileid + 1;}
		}
	}






	public void ExitMapMenuManager(){
		gamestatusmanager.ChangeStatusToMainMenu ();
	}
}

