using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class GamePanel{
	public int PanelID;
	public string PanelName;
	public GameObject Panel;

	public GamePanel(int id, string name){
		PanelID = id;
		PanelName = name;
		Panel = Resources.Load (GameobjectPathDictionary.GamePanelPath[PanelName]) as GameObject;
		//Panel = Resources.Load (GameobjectPathDictionary.GamePrefabPath["GamePanels"] + PanelName) as GameObject;
	}

	public GamePanel(){
		Panel = Resources.Load (GameobjectPathDictionary.GamePanelPath[PanelName]) as GameObject;

		//Panel = Resources.Load (GameobjectPathDictionary.GamePrefabPath ["GamePanels"] + "TransparentPanel") as GameObject;
	}


}
public class GamePanelClassMONO : MonoBehaviour {

}
