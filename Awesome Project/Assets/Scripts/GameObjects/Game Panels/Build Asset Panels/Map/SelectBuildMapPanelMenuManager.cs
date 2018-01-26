using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBuildMapPanelMenuManager : MonoBehaviour{
	private MainDatabaseManager maindatabase;
	private BuildAssetStatusManager statusmanager;
	private MenuUIManager menuuimanager;
	private MapManager mapmanager;

	public GalleryUI gallery;
	public List<GalleryElement> galleryelementlist;
	public GalleryElement currentgalleryelement;
	public int currentelementid;
	public string currentelementname;
	public Sprite currentelementsprite;

	public void SelectBuildMapMenuStart(){

		statusmanager = GameObject.Find ("_GameManager").GetComponent<BuildAssetStatusManager> ();
		maindatabase =  GameObject.Find ("_GameManager").GetComponent<MainDatabaseManager> ();
		mapmanager = GameObject.Find ("_GameManager").GetComponent<MapManager> ();
		menuuimanager = GetComponent<MenuUIManager> ();
		maindatabase.LoadMapLogicContent ();
		maindatabase.LoadMainDatabaseMap ();

		LoadBuildAssetMainMenuData ();
		LoadGallery ();
	}

	public void SelectBuildMapMenuUpdate(){


	}


	public void LoadBuildAssetMainMenuData(){

		galleryelementlist = new List<GalleryElement> (){ };
		//galleryelementlist.Clear ();
		for(int i = 0; i < maindatabase.DatabaseMapList.Count; i++){
			currentelementid = i;
			maindatabase.DatabaseMapList [i].RealID = i;
			currentelementname = maindatabase.DatabaseMapList[i].RealID + " - " +  maindatabase.DatabaseMapList [i].Map[0].Name;
			currentelementsprite = Resources.Load<Sprite> ("");

			currentgalleryelement = new GalleryElement (currentelementid,currentelementname,currentelementsprite);
			galleryelementlist.Add (currentgalleryelement);
		}
			

		List<string> currentoptiontext = new List<string>(){"Edit Map","Delete Map","","",""};
		gallery = new GalleryUI(0,"Build Map Menu",true,"New Map",2,currentoptiontext,galleryelementlist);
		menuuimanager.UpdateMenu ();

	}

	public void NewMap(){
		mapmanager.AddMap ();
		LoadBuildAssetMainMenuData ();

	}


	private void LoadGallery(){
		menuuimanager.StartMenuUIManager (1,3);
	}

	public void ExitMenu(){
		statusmanager.SwitchToMainMenu();
	}
	public void EnterBuildMap(int mapid){

		BasicStaticVariables.CurrentElement = mapid;
		statusmanager.SwitchToBuildMapMenu();


	}

	public void DeleteMapAsset(int id){
		mapmanager.DeleteMap (id);
		LoadBuildAssetMainMenuData ();
	}




}


