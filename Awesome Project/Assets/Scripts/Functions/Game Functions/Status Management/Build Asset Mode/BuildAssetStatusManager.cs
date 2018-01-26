using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildAssetStatusManager : MonoBehaviour {
	public int statusmanagerstate;
	public  GameObject maincanvasmenu;

	private BuildAssetUIManager uimanager;
	private WriteJsonManager writejsonmanager;

	private MapManager mapmanager;

	private BuildAssetMainMenuManager mainmenumanager;

	private SelectBuildMapPanelMenuManager selectmapmenumanager;
	private BuildMapMenuManager buildmapmanager;
	private SelectBuildMapTemplateMenuManager selectmaptemplatemenumanager;
	private BuildMapTypeMenuManager buildmaptypemenumanager;
	private TestMapPanelManager testmapmanager;

	private SelectBuildCharacterMenuManager selectcharactermenumanager;
	private BuildCharacterMenuManager buildcharactermanager;
	private SelectBuildInventoryMenuManager selectinventorymenumanager;
	private BuildInventoryMenuManager buildinventorymenumanager;

	public void StatusManagerStart(){
		FindScripts ();
		StartScripts ();
		//SwitchToMainMenu ();
		SwitchToBuildMapTypeMenu();

	}

	private void StartScripts(){
		uimanager.BuildAssetUIManagerStart ();
		writejsonmanager.StartWriteJsonManager ();
		mapmanager.MapManagerStart ();
	}


	private void FindScripts(){
		uimanager = GetComponent<BuildAssetUIManager> ();
		writejsonmanager = GetComponent<WriteJsonManager> ();

		mapmanager = GetComponent<MapManager> ();


		mainmenumanager =  maincanvasmenu.gameObject.GetComponentInChildren <BuildAssetMainMenuManager>();
		selectmapmenumanager  =  maincanvasmenu.gameObject.GetComponentInChildren <SelectBuildMapPanelMenuManager>();
		buildmapmanager  =  maincanvasmenu.gameObject.GetComponentInChildren <BuildMapMenuManager>();
		selectmaptemplatemenumanager = maincanvasmenu.gameObject.GetComponentInChildren<SelectBuildMapTemplateMenuManager> ();
		buildmaptypemenumanager = maincanvasmenu.gameObject.GetComponentInChildren<BuildMapTypeMenuManager> ();
		testmapmanager = maincanvasmenu.gameObject.GetComponentInChildren<TestMapPanelManager> ();

		selectcharactermenumanager  =  maincanvasmenu.gameObject.GetComponentInChildren <SelectBuildCharacterMenuManager>();
		buildcharactermanager =  maincanvasmenu.gameObject.GetComponentInChildren <BuildCharacterMenuManager>();
		selectinventorymenumanager  =  maincanvasmenu.gameObject.GetComponentInChildren <SelectBuildInventoryMenuManager>();
		buildinventorymenumanager  =  maincanvasmenu.gameObject.GetComponentInChildren <BuildInventoryMenuManager>();
	}


	public void SwitchToMainMenu(){
		statusmanagerstate = 1;
		uimanager.SwitchToMainMenu ();
		mainmenumanager.BuildAssetMainMenuStart ();

	}

	public void SwitchToSelectMapMenu(){

		statusmanagerstate = 2;
		uimanager.SwitchToSelectBuildMapPanel ();
		selectmapmenumanager.SelectBuildMapMenuStart ();

	}

	public void SwitchToBuildMapMenu(){
		statusmanagerstate = 3;
		uimanager.SwitchToBuildMapPanel ();
		buildmapmanager.BuildMapMenuStart ();

	}

	public void SwitchToSelectMapTemplateMenu(){
		statusmanagerstate = 4;
		uimanager.SwitchToSelectMapTemplatePanel ();
		selectmaptemplatemenumanager.SelectBuildMapTemplateMenuStart ();

	}

	public void SwitchToBuildMapTypeMenu(){
		statusmanagerstate = 5;
		uimanager.SwitchToBuildMapTypePanel ();
		buildmaptypemenumanager.BuildMapTypeMenuStart ();

	}

	public void SwitchToTestMapMenu(){
		statusmanagerstate = 6;
		uimanager.SwitchToTestMapPanel ();
		testmapmanager.TestMapPanelStart ();

	}


	public void SwitchToSelectCharacterMenu(){
		statusmanagerstate = 9;
		uimanager.SwitchToSelectBuildCharacterPanel ();
		selectcharactermenumanager.SelectBuildCharacterMenuStart ();
	}
		
	public void SwitchToBuildCharacterMenu(){
		statusmanagerstate = 10;
		uimanager.SwitchToBuildCharacterPanel ();
		buildcharactermanager.BuildCharacterMenuStart ();
	}

	public void SwitchToSelectInventoryMenu(){
		statusmanagerstate = 11;
		uimanager.SwitchToSelectBuildInventoryPanel ();
		selectinventorymenumanager.SelectBuildInventoryMenuStart ();
	}

	public void SwitchToBuildInventoryMenu(){
		statusmanagerstate = 12;
		uimanager.SwitchToBuildInventoryPanel();
		buildinventorymenumanager.BuildInventoryMenuStart ();

	}

	public void LoadIntroScene(){
		SceneManager.LoadScene ("Game Intro");
	}


	public void StatusManagerUpdate(){

		switch(statusmanagerstate){
		case 1://main menu
			break;
		case 2://select map
			break;
		case 3://build map
			buildmapmanager.BuildMapMenuUpdate();
			break;
		case 4://select map template
			break;
		case 5://build map type
			break;
		case 6://test map 
			break;
		case 7://map
			break;
		case 8://map 
			break;
		case 9://select character
			break;
		case 10://build character
			break;
		case 11://select inventory
			break;
		case 12://build inventory
			break;
		case 13:
			break;
		default:
			break;

		}
	}





}
