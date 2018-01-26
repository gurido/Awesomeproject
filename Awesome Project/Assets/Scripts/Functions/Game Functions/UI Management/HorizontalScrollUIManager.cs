using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollPanel{
	public List<int> Position;
	public string Name;
	public List<List<int>> ChildList;

	public ScrollPanel(List<int> position, string name, List<List<int>> childlist){
		Position = position;
		Name = name;
		ChildList = childlist;
	}
}


public class HorizontalScrollUI{
	
	public string Title;
	public int Depth;
	public List<ScrollPanel> PanelList;

	public HorizontalScrollUI(string title, int depth, List<ScrollPanel> panellist){
		Title = title;
		Depth = depth;
		PanelList = panellist;
	}
}

public class HorizontalScrollUIManager : MonoBehaviour {
	private GameObject ParentPanel;
	private MenuUIManager menuuimanager;
	public GameObject ScrollContent;
	public GameObject ExitButton;
	public Text MenuTitle;

	public List<GameObject> ScrollContentList = new List<GameObject>();
	public GameObject ScrollPanelPrefab;


	public bool IsMenuCreated;
	public List<int> CurrentSelectionList;
	public HorizontalScrollUI Currentscroll;
	//public List< List<ScrollPanel>> CurrentLevelList = new List< List<ScrollPanel>> ();


	public void HorizontalScrollUIStart(HorizontalScrollUI horizontalscroll){
		ParentPanel = this.transform.parent.gameObject;
		menuuimanager = ParentPanel.GetComponent<MenuUIManager> ();
		CurrentSelectionList = new List<int> ();
		Currentscroll = horizontalscroll;


		if (IsMenuCreated == true) {
			UpdateHorizontalScrollMenu ();
		} else {
			LoadMenuElement ();
		}
	}

	public void UpdateHorizontalScrollMenu(){
		DestroyPrevElement ();
		LoadMenuElement ();
	}



	private void LoadMenuElement(){


		CurrentSelectionList.Add (1);

		//LoadElement (0);

		if (CurrentSelectionList.Count > 0) {
			bool foundselection = false;
			for (int x = 0; x < Currentscroll.PanelList.Count; x++) {
				//Debug.Log ("panel "  + x + "  has " + Currentscroll.PanelList[x].Position.Count + " level");
				if (Utilities.MatchList (CurrentSelectionList, Currentscroll.PanelList [x].Position) == true) {
					foundselection = true;
					break;
				}
			}

			if (foundselection == true) {
				LoadContent ();

			} else {
				Debug.Log ("We didn't find a thing");
				CurrentSelectionList = new List<int> ();
			}

		} 
		if(CurrentSelectionList.Count == 0){

		}


	}

	private void LoadContent(){
		
		Debug.Log ("We found a thing");
		for(int i = 0; i < CurrentSelectionList.Count; i++){
			List<int> PositionList = CurrentSelectionList.GetRange (0,i+1);
			ScrollPanel NewScrollPanel = FindPanel (PositionList);
			if (NewScrollPanel != null) {
				LoadElement (i, NewScrollPanel);
			} else {
				Debug.Log ("No Panel at Position " + PositionList.Count);
				break;
			}

		}

	}


	private ScrollPanel FindPanel(List<int> position){
		for(int i = 0; i < Currentscroll.PanelList.Count; i++){
			if (Utilities.MatchList (position, Currentscroll.PanelList [i].Position) == true) {
				return Currentscroll.PanelList[i];
			}
		}
		return null;
	}



	private void LoadElement(int id, ScrollPanel scrollpanel){
		Debug.Log ("Loading element " + id);
		ScrollContentList.Add (Instantiate (ScrollPanelPrefab));
		ScrollContentList [id].transform.SetParent (ScrollContent.transform, false);
		//CurrentLevelList.Add (new List<ScrollPanel>());
		ScrollPanelManager manager =  ScrollContentList[id].GetComponent<ScrollPanelManager>();
		manager.ID = id;
		manager.Panel = scrollpanel;
		manager.StartScrollPanelManager ();
		ScrollContentList [id].transform.gameObject.SetActive (true);


	}



	public void DeselectElement(){
		CurrentSelectionList.Clear ();

	}


	private void DestroyPrevElement(){
		foreach (Transform child in ScrollContent.transform) {
			Destroy (child.gameObject);
		}
		ScrollContentList.Clear ();
	}



	public void ExitMenu(){
		DestroyPrevElement ();
		menuuimanager.PressMenuOption (1);

	}

}
