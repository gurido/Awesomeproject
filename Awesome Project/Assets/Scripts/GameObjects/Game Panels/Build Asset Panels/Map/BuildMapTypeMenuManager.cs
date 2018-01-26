using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMapTypeMenuManager : MonoBehaviour {
	private MainDatabaseManager maindatabase;
	private BuildAssetStatusManager statusmanager;
	private MenuUIManager menuuimanager;
	private MapManager mapmanager;

	public HorizontalScrollUI horizontalscroll;
	private ScrollPanel currentscrollpanel;

	public void BuildMapTypeMenuStart(){
		statusmanager = GameObject.Find ("_GameManager").GetComponent<BuildAssetStatusManager> ();
		maindatabase =  GameObject.Find ("_GameManager").GetComponent<MainDatabaseManager> ();
		mapmanager = GameObject.Find ("_GameManager").GetComponent<MapManager> ();
		menuuimanager = GetComponent<MenuUIManager> ();
		maindatabase.LoadMapLogicContent ();

		LoadBuildMapTypeMenuData ();
		menuuimanager.StartMenuUIManager (2,1);
	}

	public void LoadBuildMapTypeMenuData(){

		string menutitle = "Map Logic";
		int currentdepth = 3;
		List<ScrollPanel>  scrollpanellist = new List<ScrollPanel> ();
		List<int> currentposition = new List<int> ();

		for (int i = 0; i < maindatabase.DatabaseMapLogic.Count; i++){
			List<List<int>> currentchildlist1 = new List<List<int>> ();

			for(int x = 0; x < maindatabase.DatabaseMapLogic[i].Content.Count; x++){
				List<List<int>> currentchildlist2 = new List<List<int>> ();

				for(int y = 0; y < maindatabase.DatabaseMapLogic[i].Content[x].SubtypeList.Count; y++){
					currentposition = new List<int> (){i,x,y};
					List<List<int>> currentchildlist3 = new List<List<int>> ();
					BuildCurrentPanel (currentposition, currentchildlist3);
					scrollpanellist.Add (currentscrollpanel);
					currentchildlist2.Add (currentposition);
				}
				currentposition = new List<int> (){i,x};
				BuildCurrentPanel (currentposition, currentchildlist2);
				scrollpanellist.Add (currentscrollpanel);
				currentchildlist1.Add (currentposition);
			}
			currentposition = new List<int> (){i};
			BuildCurrentPanel (currentposition, currentchildlist1);
			scrollpanellist.Add (currentscrollpanel);
		}

		horizontalscroll = new HorizontalScrollUI (menutitle,currentdepth, scrollpanellist);
		menuuimanager.UpdateMenu ();


	}

	private void BuildCurrentPanel(List<int> position, List<List<int>>childlist){

		List<int> currentposition = position;
		string currentname = "";
		switch(position.Count){
		case 0:
			break;
		case 1:
			currentname = maindatabase.DatabaseMapLogic [position [0]].Name;
			break;
		case 2:
			currentname = maindatabase.DatabaseMapLogic[position[0]].Content[position [1]].Name;
			break;
		case 3:
			currentname = maindatabase.DatabaseMapLogic [position [0]].Content [position [1]].SubtypeList [position [2]].Name;
			break;

		}
		List<List<int>> currentchildlist = childlist;
		currentscrollpanel = new ScrollPanel (currentposition,currentname,currentchildlist);

	}




	public void AddTypeLogic(List<int> selection){
		mapmanager.AddLogic (selection);
	}

	public void DeteleTypeLogic(List<int> selection){
		mapmanager.DeleteLogic (selection);
	}

	public void SaveTypeLogic(List<int> selection, LogicTypeContent typelogic){
		mapmanager.SaveTypeLogic (selection,typelogic);
	}

	public void SaveSubtypeLogic(List<int> selection, LogicSubTypeContent subtypelogic){
		mapmanager.SaveSubtypeLogic (selection, subtypelogic);
	}


	public void ExitMenu(){
		statusmanager.SwitchToMainMenu ();

	}


}
