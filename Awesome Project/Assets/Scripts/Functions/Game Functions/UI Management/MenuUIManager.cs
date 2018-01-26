using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour {

	#region Variables
	public int CurrentSelectedElement1;
	public int CurrentSelectedElement2;
	private List<GameObject> MenuChildList = new List<GameObject>();

	public int MenuType;//1 = gallery, 2 = menu scroll
	public int MenuContent;//1 = select game menu

	//gallery
	public GameObject GalleryPrefab;
	private GalleryUIManager galleryuimanager;
	private GalleryUI currentgallery;

	private SelectGameMenuManager selectgamemenumanager;//1
	private BuildAssetMainMenuManager selectbuildassetmenumanager;//2
	private SelectBuildMapPanelMenuManager selectbuildmapmenumanager;//3

	//horizontal scroll
	public GameObject HorizontalScrollPrefab;
	private HorizontalScrollUIManager horizontalscrolluimanager;
	private HorizontalScrollUI currenthorizontalscroll;

	private BuildMapTypeMenuManager buildmaptypemanager;//1




	#endregion

	#region General Functions
	public void StartMenuUIManager(int menuuitype, int menucontenttype){
		MenuType = menuuitype;
		MenuContent = menucontenttype;
		if (MenuChildList.Count == 0) {
			switch(MenuType){
			case 1://Gallery
				CreateGallery();
				break;
			case 2://horizontal scroll
				CreateHorizontalScroll();
				break;

			default:
				break;
			}
		} 
		switch(MenuType){
		case 1://Gallery
			StartGallery();
			break;
		case 2://horizontal scroll
			StartHorizontalScroll();
			break;
		default:
			break;
		}
	}

	public void PressMenuOption(int optionid){

		switch(MenuType){
		case 1://gallery
			GalleryMenu(optionid);
			break;
		case 2://horizontal scroll
			HorizontalScrollMenu(optionid);
			break;

		default:
			break;
		}
	}


	public void UpdateMenu(){
		switch(MenuType){
		case 1://gallery

			switch(MenuContent){
			case 3:
				galleryuimanager.CurrentGalleryUI = selectbuildmapmenumanager.gallery;
				break;
			}
			galleryuimanager.UpdateGalleryManager ();
			break;
		case 2://horizontal scroll
			switch(MenuContent){
			case 1:
				horizontalscrolluimanager.Currentscroll = buildmaptypemanager.horizontalscroll;
				break;
			}
			horizontalscrolluimanager.UpdateHorizontalScrollMenu ();

			break;

		default:
			break;
		}
	}

	#endregion


	#region HorizontalScroll Menu


	private void HorizontalScrollMenu(int optionid){
		switch(MenuContent){
		case 1://Buildmaptypepanel
			BuildMapLogicMenu(optionid);
			break;
		}
	}

	private void CreateHorizontalScroll(){
		MenuChildList.Add (Instantiate (HorizontalScrollPrefab));
		MenuChildList [0].transform.SetParent (this.transform, false);
		switch(MenuContent){
		case 1://Build map type
			buildmaptypemanager = GetComponent<BuildMapTypeMenuManager> ();
			break;

		}
		horizontalscrolluimanager = this.transform.GetChild (0).GetComponent<HorizontalScrollUIManager> ();
		horizontalscrolluimanager.IsMenuCreated = false;

	}



	private void StartHorizontalScroll(){

		switch(MenuContent){
		case 1://Build map type
			currenthorizontalscroll = buildmaptypemanager.horizontalscroll;
			break;
		}
		horizontalscrolluimanager.HorizontalScrollUIStart (currenthorizontalscroll);
		horizontalscrolluimanager.IsMenuCreated = true;
	}

	private void BuildMapLogicMenu(int optionid){
		switch (optionid) {
		case 1://Exit menu
			buildmaptypemanager.ExitMenu();
			break;
		case 2://
			break;		
		case 3://
			break;
		}

	}



	/*
	private void HorizontalScrollContentExample(int optionid){
		switch (optionid) {
		case 1://Exit Menu
			break;
		case 2://
			break;		
		case 3://
			break;
		case 4://
			break;
		case 5://
			break;
		case 6://
			break;		
		case 7://
			break;
		case 8://
			break;
		}

	}*/





	#endregion



	#region Gallery

	private void GalleryMenu(int optionid){
		switch(MenuContent){
		case 1://select game menu
			SelectGameMenu(optionid);
			break;
		case 2:
			SelectBuildAssetMenu (optionid);
			break;
		case 3:
			SelectBuildMapMenu (optionid);
			break;
		default:
			break;

		}
	}

	private void CreateGallery(){
		MenuChildList.Add (Instantiate (GalleryPrefab));
		MenuChildList [0].transform.SetParent (this.transform, false);
		switch(MenuContent){
		case 1://select game menu
			selectgamemenumanager = GetComponent<SelectGameMenuManager> ();
			break;
		case 2://select build asset menu
			selectbuildassetmenumanager = GetComponent<BuildAssetMainMenuManager> ();
			break;
		case 3://select build map menu
			selectbuildmapmenumanager = GetComponent<SelectBuildMapPanelMenuManager> ();
			break;
		default:
			break;
		}
		galleryuimanager = this.transform.GetChild (0).GetComponent<GalleryUIManager> ();
	
		galleryuimanager.IsGalleryCreated = false;
	}



	private void StartGallery(){

		switch(MenuContent){
		case 1://select game menu
			currentgallery = selectgamemenumanager.gameselectmenugallery;
			break;

		case 2://select build asset menu
			currentgallery = selectbuildassetmenumanager.buildassetselectgallery;
			break;

		case 3://select build map menu
			currentgallery = selectbuildmapmenumanager.gallery;
			break;
		default:
			break;
		}
		galleryuimanager.StartGalleryManager (currentgallery);
		galleryuimanager.IsGalleryCreated = true;

	}

	/*
	private void GalleryContentExample(int optionid){
		switch (optionid) {
		case 1://gallery option1
			break;
		case 2://gallery option2
			break;		
		case 3://gallery option3
			break;
		case 4://gallery option4
			break;
		case 5://gallery option5
			break;
		case 6://create new element
			break;		
		case 7://exit gallery
			break;
		case 8://select element
			break;

		}

	}*/

	private void SelectGameMenu(int optionid){

		switch (optionid) {
		case 1://gallery option1
			selectgamemenumanager.PlayGame(CurrentSelectedElement1);
			break;
		case 2://gallery option2
			selectgamemenumanager.GameDetail(CurrentSelectedElement1);
			break;		
		case 3://gallery option3
			selectgamemenumanager.EditGame(CurrentSelectedElement1);
			break;
		case 4://gallery option4
			selectgamemenumanager.DuplicateGame(CurrentSelectedElement1);
			break;
		case 5://gallery option5
			selectgamemenumanager.DeleteGame(CurrentSelectedElement1);
			break;
		case 6://create new game
			selectgamemenumanager.AddGame();
			break;		
		case 7://exit gallery
			selectgamemenumanager.ExitMenu();
			break;
		case 8://select element
			break;
		default:
			break;
		}

	}


	private void SelectBuildAssetMenu(int optionid){
		switch (optionid) {
		case 1://gallery option1
			selectbuildassetmenumanager.EnterBuildMapMenu(CurrentSelectedElement1);

			break;
		case 2://gallery option2
			break;		
		case 3://gallery option3
			break;
		case 4://gallery option4
			break;
		case 5://gallery option5
			break;
		case 6://create new element
			break;		
		case 7://exit gallery
			selectbuildassetmenumanager.ExitMenu();
			break;
		case 8://select element

			break;
		default:
			break;
		}

	}

	private void SelectBuildMapMenu(int optionid){
		switch (optionid) {
		case 1://gallery option1
			selectbuildmapmenumanager.EnterBuildMap(CurrentSelectedElement1);
			break;
		case 2://gallery option2
			selectbuildmapmenumanager.DeleteMapAsset(CurrentSelectedElement1);
			break;		
		case 3://gallery option3
			break;
		case 4://gallery option4
			break;
		case 5://gallery option5
			break;
		case 6://create new element
			selectbuildmapmenumanager.NewMap();
			break;		
		case 7://exit gallery
			selectbuildmapmenumanager.ExitMenu();
			break;
		case 8://select element
			break;
		default:
			break;
		}

	}




	#endregion




}
