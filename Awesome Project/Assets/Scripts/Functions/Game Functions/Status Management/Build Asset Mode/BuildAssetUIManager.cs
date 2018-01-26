using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildAssetUIManager : MonoBehaviour {

	public GameObject MainCanvas;
	public GameObject MainMenuPanel;

	public GameObject SelectBuildMapPanel;
	public GameObject BuildMapPanel;
	public GameObject SelectBuildMapTemplatePanel;
	public GameObject BuildMapTypePanel;
	public GameObject TestMapPanel;

	public GameObject SelectBuildCharacterPanel;
	public GameObject BuildCharacterPanel;
	public GameObject SelectBuildInventoryPanel;
	public GameObject BuildInventoryPanel;


	public void BuildAssetUIManagerStart(){

	}



	private void DeactiveAllPanel(){
		foreach(Transform child in MainCanvas.transform){

			child.gameObject.SetActive (false);
		}
	}



	public void SwitchToMainMenu(){
		DeactiveAllPanel ();
		MainMenuPanel.SetActive (true);

	}

	public void SwitchToSelectBuildMapPanel(){
		DeactiveAllPanel ();
		SelectBuildMapPanel.SetActive (true);

	}

	public void SwitchToBuildMapPanel(){
		DeactiveAllPanel ();
		BuildMapPanel.SetActive (true);

	}


	public void SwitchToSelectMapTemplatePanel(){
		DeactiveAllPanel ();
		SelectBuildMapTemplatePanel.SetActive (true);
	}

	public void SwitchToBuildMapTypePanel(){
		DeactiveAllPanel ();
		BuildMapTypePanel.SetActive (true);
	}

	public void SwitchToTestMapPanel(){

		DeactiveAllPanel ();
		TestMapPanel.SetActive (true);
	}



	public void SwitchToSelectBuildCharacterPanel(){
		DeactiveAllPanel ();
		SelectBuildCharacterPanel.SetActive (true);

	}

	public void SwitchToBuildCharacterPanel(){
		DeactiveAllPanel ();
		BuildCharacterPanel.SetActive (true);

	}

	public void SwitchToSelectBuildInventoryPanel(){
		DeactiveAllPanel ();
		SelectBuildInventoryPanel.SetActive (true);

	}

	public void SwitchToBuildInventoryPanel(){
		DeactiveAllPanel ();
		SelectBuildInventoryPanel.SetActive (true);

	}



}
