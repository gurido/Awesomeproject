using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMapOptionMenu : MonoBehaviour {

	private BuildMapMenuManager buildmapmanager;

	public GameObject MapInfoPanel;
	public GameObject BuildSettingsPanel;
	public GameObject TileOptionPanel;
	public GameObject TileObjectOptionPanel;

	//map info
	public Text MapNameText;
	public Text MapDescriptionText;
	public Text MapTagsText;
	public InputField MapNameInput;
	public InputField MapDescriptionInput;
	public InputField TagsInput;


	//map settings
	public Text TemplateDropdownText;
	public Text MapTypeDropdownText;
	public Text MapSubtypeDropdownText;
	public Dropdown TemplateDropdown;
	public Dropdown MapTypeDropdown;
	public Dropdown MapSubtypeDropdown;

	public Text SizeXText;
	public Text SizeYText;
	public InputField SizeXInput;
	public InputField SizeYInput;




	public void MapOptionMenuStart(){
		buildmapmanager = GetComponent<BuildMapMenuManager> ();
		SwitchToMapInfoPanel ();
		SetAllInformation ();


	}

	public void MapOptionMenuUpdate(){

	}




	private void  SetMapTypeDropdown(){
		List<string> optiontextlist = new List<string> (){"template 1","template 2","template 3"};
		int optioncount = 3;
		SetDropdownData (MapTypeDropdown,optioncount, optiontextlist);
	}

	public void  SetMapSubTypeDropdown(){

		switch(MapTypeDropdown.value){
		case -1:
			break;
		case 0:
			List<string> emptylist = new List<string> ();
			SetDropdownData (MapSubtypeDropdown, 0, emptylist);
			break;

		case 1:
			List<string> optiontextlist = new List<string> (){"template 1","template 2","template 3"};
			int optioncount = 3;
			SetDropdownData (MapSubtypeDropdown,optioncount, optiontextlist);
			break;

		default:
			break;
		}
		//Debug.Log ("Subtype is " + MapTypeDropdown.value);

	}

	private void  SetTemplateDropdown(){

		List<string> optiontextlist = new List<string> (){"template 1","template 2","template 3"};
		int optioncount = 3;
		SetDropdownData (TemplateDropdown,optioncount, optiontextlist);

	}


	private void SetDropdownData(Dropdown dropdown, int count, List<string> textlist){
		
		dropdown.options.Clear ();

		for(int i = 0; i < count; i++){
			dropdown.options.Add (new Dropdown.OptionData());
			dropdown.options [i].text = textlist [i];
		}
	}

	public void SwitchToMapInfoPanel(){
		MapInfoPanel.SetActive (true);
		BuildSettingsPanel.SetActive (false);
		TileOptionPanel.SetActive (false);
		TileObjectOptionPanel.SetActive (false);

	}

	public void SwitchToMapSettingPanel(){
		MapInfoPanel.SetActive (true);
		BuildSettingsPanel.SetActive (true);
		TileOptionPanel.SetActive (false);
		TileObjectOptionPanel.SetActive (false);

	}


	public void SwitchToTileInfoPanel(){
		MapInfoPanel.SetActive (false);
		BuildSettingsPanel.SetActive (false);
		TileOptionPanel.SetActive (true);
		TileObjectOptionPanel.SetActive (false);

	}

	public void SwitchToTileObjPanel(){
		MapInfoPanel.SetActive (false);
		BuildSettingsPanel.SetActive (false);
		TileOptionPanel.SetActive (false);
		TileObjectOptionPanel.SetActive (true);

	}


	private void SetAllInformation(){

		TemplateDropdownText.text = "Map Template";
		MapTypeDropdownText.text = "Map Type";
		MapSubtypeDropdownText.text = "Map Subtype";

		SetMapGeneralInfo ();
		SetMapSizeInfo ();


		SetTemplateDropdown ();
		SetMapTypeDropdown ();
		SetMapSubTypeDropdown ();

	}

	public void ImportTemplateButton(){

	}

	public void SaveMapInfoButton(){

		string name = buildmapmanager.CurrentGameMap.Name;
		string description = buildmapmanager.CurrentGameMap.Description;
		if(MapNameInput.text != ""){
			name = MapNameInput.text;
		}
		if(MapDescriptionInput.text != ""){
			description = MapDescriptionInput.text;
		}

		buildmapmanager.CurrentGameMap.Name = name;
		buildmapmanager.CurrentGameMap.Description = description;

		SetMapGeneralInfo ();

	}


	public void SaveMapSettingsButton(){
		int maptype = MapTypeDropdown.value;
		int submaptype = MapSubtypeDropdown.value;
		//buildmapmanager.CurrentGameMap.Type = maptype;

		SaveSizeSettings ();
		buildmapmanager.CheckMapSize ();


	}

 


	private void SaveSizeSettings(){

		int sizex = buildmapmanager.CurrentGameMap.SizeX;
		int sizey = buildmapmanager.CurrentGameMap.SizeY;

		if(SizeXInput.text != "" && SizeYInput.text != ""){
			sizex = int.Parse(SizeXInput.text);
			sizey = int.Parse (SizeYInput.text);
		}
		if(SizeXInput.text == "" && SizeYInput.text != ""){
			sizey = int.Parse (SizeYInput.text);
		}
		if (SizeXInput.text != "" && SizeYInput.text == "") {
			sizex = int.Parse (SizeXInput.text);

		} else {
		}
		buildmapmanager.CurrentGameMap.SizeX = sizex;
		buildmapmanager.CurrentGameMap.SizeY = sizey;
		//Debug.Log ("real size is " + buildmapmanager.CurrentGameMap.SizeX + buildmapmanager.CurrentGameMap.SizeY);

		SetMapSizeInfo ();
	}

	private void SetMapSizeInfo(){
		SizeXInput.text = "";
		SizeYInput.text = "";
		SizeXText.text = buildmapmanager.CurrentGameMap.SizeX.ToString();
		SizeYText.text = buildmapmanager.CurrentGameMap.SizeY.ToString();
	}

	private void SetMapGeneralInfo(){
		MapNameInput.text = "";
		MapDescriptionInput.text = "";
		TagsInput.text = "";
		MapNameText.text = buildmapmanager.CurrentGameMap.Name;
		MapDescriptionText.text = buildmapmanager.CurrentGameMap.Description;
	}

	public void OpenSettingsMenuButton(){
	
		SwitchToMapSettingPanel ();
	}

	public void CloseSettingsMenuButton(){

		SwitchToMapInfoPanel ();
	}






}
