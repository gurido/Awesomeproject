using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildAssetMainMenuManager : MonoBehaviour{
	private MainDatabaseManager maindatabase;
	private BuildAssetStatusManager statusmanager;
	private MenuUIManager menuuimanager;


	public GalleryUI buildassetselectgallery;
	public List<GalleryElement> galleryelementlist;
	public GalleryElement currentgalleryelement;

	public void BuildAssetMainMenuStart(){
		statusmanager = GameObject.Find ("_GameManager").GetComponent<BuildAssetStatusManager> ();

		LoadBuildAssetMainMenuData ();
		LoadGallery ();
	}

	public void BuildAssetMainMenuUpdate(){

	}



	public void LoadBuildAssetMainMenuData(){
		galleryelementlist = new List<GalleryElement> (){ };
		List<string> currentoptiontext = new List<string>(){"Build Map","Build Template","Map Type","",""};

		Sprite gallerythumbnail1 = Resources.Load<Sprite> ("");

		currentgalleryelement = new GalleryElement (0,"Map",gallerythumbnail1);
		galleryelementlist.Add (currentgalleryelement);
		//currentgalleryelement = new GalleryElement (1,"game 2",gallerythumbnail2);
		//galleryelementlist.Add (currentgalleryelement);


		buildassetselectgallery = new GalleryUI(0,"Build Asset Menu",false,"New Asset",3,currentoptiontext,galleryelementlist);

	}


	private void LoadGallery(){
		menuuimanager = GetComponent<MenuUIManager> ();
		menuuimanager.StartMenuUIManager (1,2);
	}

	public void ExitMenu(){
		statusmanager.LoadIntroScene ();
	}

	public void EnterBuildMapMenu(int menuid){

		switch(menuid){
		case 0:
			statusmanager.SwitchToSelectMapMenu ();
			//statusmanager.SwitchToBuildCharacterMenu();
			break;
		default:
			break;

		}

	}





}
