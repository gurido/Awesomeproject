using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMapMenuManager : MonoBehaviour {
	private MainDatabaseManager maindatabase;
	private BuildAssetStatusManager statusmanager;
	private MapManager mapmanager;
	private BuildMapOptionMenu optionmenu;

	public GameObject MapPanel;
	public Text MapTitle;
	public Transform tilePrefab;
	private Vector3 TileScale = new Vector3(20,20,1);
	public int TileXScaleValue;
	public int TileyScaleValue;

	public GameMap CurrentGameMap;
	public List<GameObject> TileSlotList = new List<GameObject>();
	public int CurrentSelectedTile;
	public Text TileInfoText;


	public bool ObjectEdit;
	public Toggle ObjectEditToggle;

	public void BuildMapMenuStart(){

		FindScripts ();
		ObjectEdit = false;//not testing
		CurrentSelectedTile = -1;//no selection
		LoadMapData ();//get data
		ExitOverTile();
		CheckMapSize ();
		//UpdateMap ();
		optionmenu.MapOptionMenuStart ();//begin option*/
	
	}
		

	public void BuildMapMenuUpdate(){

		if(Input.GetMouseButtonDown(1)){
			DeselectTile ();

		}


	}

	public void CheckMapSize(){

		if(CurrentGameMap.MapTileList.Count != 0){
			if ((CurrentGameMap.SizeX - 1) != (CurrentGameMap.MapTileList [CurrentGameMap.MapTileList.Count - 1].PositionX) ||( CurrentGameMap.SizeY -1) != (CurrentGameMap.MapTileList [CurrentGameMap.MapTileList.Count - 1].PositionY)) {
				//Debug.Log ("Map size and tile list is wrong");
				ClearAllGameobjects ();

			} else {
				//Debug.Log ("Map size and tilelist are alright");
			}
		}
		else{
			//Debug.Log ("No tilelist");
			ClearAllGameobjects ();

		}
		UpdateMap ();
	}



	private void LoadMapData(){
		//maindatabase.ReadDatabaseMap();

		CurrentGameMap = maindatabase.DatabaseMapList [BasicStaticVariables.CurrentElement].Map [0];

	}


	public void UpdateMap(){
		DestroyPreviousMap ();
		CreateGameMap ();
	}



	private void FindScripts(){
		statusmanager = GameObject.Find ("_GameManager").GetComponent<BuildAssetStatusManager> ();
		maindatabase =  GameObject.Find ("_GameManager").GetComponent<MainDatabaseManager> ();
		mapmanager = GameObject.Find ("_GameManager").GetComponent<MapManager> ();
		optionmenu = GetComponent<BuildMapOptionMenu> ();

	}




	private void CreateGameMap(){
		TileSlotList.Clear ();
		int tilenumber = 0;
		for (int x = 0; x < CurrentGameMap.SizeX; x++) {
			for (int y = 0; y < CurrentGameMap.SizeY; y++) {

				Vector3 tilePosition = new Vector3 ((-CurrentGameMap.SizeX / 2 + 0.5f + x)*TileScale.x ,( -CurrentGameMap.SizeY / 2 + 0.5f + y)*TileScale.y  , 0);
				Transform newTile = Instantiate (tilePrefab, tilePosition, Quaternion.Euler (Vector3.right * 0)) as Transform;
				newTile.gameObject.transform.localScale = TileScale;
				newTile.transform.SetParent (MapPanel.transform, false);
				TileSlotList.Add (newTile.gameObject);

				BuildTileData tiledata = newTile.GetComponent<BuildTileData> ();
				tiledata.TileID = tilenumber;
				tilenumber = tilenumber + 1;
				tiledata.Xposition = x;
				tiledata.Yposition = y;
				tiledata.tileobject = new MapObject ();
				for(int i = 0; i < CurrentGameMap.MapObjectList.Count; i ++){
					if (CurrentGameMap.MapObjectList [i].PositionX == x && CurrentGameMap.MapObjectList [i].PositionY == y) {
						tiledata.tileobject = CurrentGameMap.MapObjectList [i];
						//Debug.Log ("Found " + tiledata.tileobject.Type + " thing at " + x + " and " + y);
						break;

					} else {
						
					}
				}


				MapTile newmaptile = new MapTile ();
				for (int i = 0; i < CurrentGameMap.MapTileList.Count; i++) {
					if (CurrentGameMap.MapTileList [i].PositionX == x && CurrentGameMap.MapTileList [i].PositionY == y) {
						newmaptile = CurrentGameMap.MapTileList [i];
					}
				}
				tiledata.tile = newmaptile;
				tiledata.StartTileData ();
			}
		}



	}


	public void PressOnTile(int tileid, int type, int id){
		//Debug.Log ( WorldDictionary.MapObjectTypeDictionary[type] );
		CurrentSelectedTile = tileid;

		switch(type){
		case -1://does not exist
			break;
		case 0://ground
			break;
		case 1://wall
			break;
		case 2://access point
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

		if (ObjectEdit == false) {

			optionmenu.SwitchToTileInfoPanel ();


		} else {
			optionmenu.SwitchToTileObjPanel ();
		}

	}





	public void EditTileData(int type){
		BuildTileData tiledata = TileSlotList [CurrentSelectedTile].GetComponent<BuildTileData> ();
		CurrentGameMap.MapTileList [CurrentSelectedTile].TileType = type;
		tiledata.tile = CurrentGameMap.MapTileList [CurrentSelectedTile];
		tiledata.StartTileData();
			
	}



	public  void DeleteTileGameobject(){
		BuildTileData tiledata = TileSlotList [CurrentSelectedTile].GetComponent<BuildTileData> ();
		for (int i = 0; i < CurrentGameMap.MapObjectList.Count; i++) {
			if (CurrentGameMap.MapObjectList [i].PositionX == tiledata.Xposition && CurrentGameMap.MapObjectList [i].PositionY == tiledata.Yposition) {
				CurrentGameMap.MapObjectList.RemoveAt (i);
			} 

		}
		tiledata.tileobject = new MapObject ();
	}

	public void EditTileGameobject(int type, int id){
		DeleteTileGameobject ();
		BuildTileData tiledata = TileSlotList [CurrentSelectedTile].GetComponent<BuildTileData> ();
		int objtype = type;
		int objid = id;
		int positionx = tiledata.Xposition;
		int positiony = tiledata.Yposition;
		MapObject newmapobject = new MapObject (objtype,objid,positionx,positiony);
		CurrentGameMap.MapObjectList.Add (newmapobject);
		tiledata.tileobject = newmapobject;
		tiledata.StartTileData ();
	}




	public void DeselectTile(){
		CurrentSelectedTile = -1;
		optionmenu.SwitchToMapInfoPanel ();
	}

	public void ResetMap(){
		LoadMapData ();
		UpdateMap ();
	}

	private void DestroyPreviousMap(){
		foreach (Transform child in MapPanel.transform)
			Destroy (child.gameObject);
	}



	public void SaveMap(){
		mapmanager.SaveGameMap (CurrentGameMap);

	}


	public void ExitMenu(){
		statusmanager.SwitchToSelectMapMenu ();
	}

	public void HoveOverTile(MapObject mapobj, MapTile maptile){
		//Debug.Log (  );

		string tileinfo = "Tile is " + maptile.ID;
		string positioninfo = "Position: " + maptile.PositionX  + " - " + maptile.PositionY;
		string objectinfo ="  Gameobject is " + WorldDictionary.MapObjectTypeDictionary[mapobj.Type] ;
		TileInfoText.text = tileinfo + " " + positioninfo + " " +objectinfo ;
	}

	public void ExitOverTile(){
		string mapinfo = "Map size is " + CurrentGameMap.SizeX + " - " + CurrentGameMap.SizeY;
		TileInfoText.text = mapinfo;

	}

	private void ClearAllGameobjects(){
		CurrentGameMap.MapObjectList.Clear ();
		BuildTileList ();

		//UpdateMap ();
	}
	private void BuildTileList(){
		CurrentGameMap.MapTileList.Clear ();
		int tilenumber = 0;

		for (int x = 0; x < CurrentGameMap.SizeX; x++) {
			for (int y = 0; y < CurrentGameMap.SizeY; y++) {
				int id = tilenumber;
				int type = -1;
				int positionx = x;
				int positiony = y;
				MapTile newmaptile = new MapTile (id,type,positionx,positiony);
				CurrentGameMap.MapTileList.Add (newmaptile);
				tilenumber++;
			}
		}
	}


	public void ToggleValueChange(){

		ObjectEdit = ObjectEditToggle.isOn;
		if (ObjectEdit == false) {
			Debug.Log ("Edit Object is false" );


		} else {
			Debug.Log ("Edit Object is true" );

		}
		DeselectTile ();


	}

}
