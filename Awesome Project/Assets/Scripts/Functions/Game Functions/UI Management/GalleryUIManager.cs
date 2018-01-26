using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryUIManager : MonoBehaviour {
	public int GallerySize = 10;
	public bool IsGalleryCreated;

	public GameObject ParentPanel;
	public MenuUIManager menuuimanager;

	public Text GalleryTitleText;
	public GameObject NextPageButton;
	public GameObject PrevPageButton;
	public Text GalleryPageTxt;
	public GameObject NewElementButton;


	public GameObject ElementOptionButtonArray;
	public GameObject OptionButton1;
	public GameObject OptionButton2;
	public GameObject OptionButton3;
	public GameObject OptionButton4;
	public GameObject OptionButton5;
	public Text OptionButtonText1;
	public Text OptionButtonText2;
	public Text OptionButtonText3;
	public Text OptionButtonText4;
	public Text OptionButtonText5;

	public List<GameObject> OptionButtonList;
	public List<Text> OptionButtonTextList;
	public GameObject GalleryContentPanel;
	public GameObject GalleryElementPrefab;
	public List<GameObject> GalleryElementList = new List<GameObject>();

	public GalleryUI CurrentGalleryUI;
	public int CurrentPage;//what page am i on
	public int CurrentPageCount;//how many pages are there
	public int CurrentPageElementCount;//how many things are in this page
	public int LastPageCount;//how many things are in the last page

	public int CurrentElementCount;//how many elements in total




	public void StartGalleryManager(GalleryUI gallery){
		ParentPanel = this.transform.parent.gameObject;
		menuuimanager = ParentPanel.GetComponent<MenuUIManager> ();

		GallerySize = 10;
		CurrentGalleryUI = gallery;

		if (IsGalleryCreated == true) {
			UpdateGalleryManager ();

		} else {
			CurrentPage = 1;
			SetOptionButton ();
			LoadGalleryData ();
			DisableOptionButtonArray ();

		}
		/*if (CurrentGalleryUI.ID != -1) {
			
		} */


	}

	public void UpdateGalleryManager(){
		DestroyPrevElements ();
		LoadGalleryData ();
		DisableOptionButtonArray ();
		//Debug.Log ("updated gallery");
	}




	private void DestroyPrevElements(){
		foreach (Transform child in GalleryContentPanel.transform) {
			Destroy (child.gameObject);
		}  
		GalleryElementList.Clear ();
	}


	private void LoadGalleryData(){
		if (CurrentPage == 1) {
			PrevPageButton.SetActive (false);
		} else {
			PrevPageButton.SetActive (true);
		}
	
		int paginas = 1 + (CurrentGalleryUI.GalleryElementList.Count / GallerySize);
		int rest0 = CurrentGalleryUI.GalleryElementList.Count % GallerySize;
		LastPageCount = rest0;
		if (LastPageCount == 0) {
			CurrentPageCount = paginas - 1;

		} else {
			CurrentPageCount = paginas;

		}



		LastPageCount = CurrentGalleryUI.GalleryElementList.Count - GallerySize * (CurrentPageCount - 1);
		if (CurrentPage == CurrentPageCount) {
			NextPageButton.SetActive (false);
			CurrentPageElementCount = LastPageCount;
		} else {
			NextPageButton.SetActive (true);
			CurrentPageElementCount = GallerySize;
		}

		for (int i = 0; i < CurrentPageElementCount; i ++){
			AddAElement (i);
		}

		if (CurrentPageCount == 1) {
			GalleryPageTxt.text = "";
		} else {
			GalleryPageTxt.text = CurrentPage + "/" + CurrentPageCount;

		}

		GalleryTitleText.text = CurrentGalleryUI.Name;
	}


	private void AddAElement(int id){
		GalleryElementList.Add (Instantiate (GalleryElementPrefab));
		GalleryElementList [id].transform.SetParent (GalleryContentPanel.transform, false);
		GalleryElementData elementdata;
		elementdata = GalleryElementList [id].GetComponent<GalleryElementData> ();
		elementdata.ElementID = (CurrentPage - 1)*GallerySize + id;
		elementdata.ElementText.text = CurrentGalleryUI.GalleryElementList [(CurrentPage - 1)*GallerySize + id].ElementTitle;
		elementdata.ElementImage.sprite = CurrentGalleryUI.GalleryElementList [(CurrentPage - 1)*GallerySize + id].ElementSprite;
		elementdata.StartGalleryElement ();
	}



	public void ExitGallery(){
		DestroyPrevElements ();
		menuuimanager.PressMenuOption (7);
	}

	public void CreateNewElement(){
		menuuimanager.PressMenuOption (6);
		//CurrentGalleryUI.ElementCount++;
		DeselectElement ();
		UpdateGalleryManager ();
	}


	public void SelectElement(int id){
		menuuimanager.CurrentSelectedElement1 = id;
		ElementOptionButtonArray.SetActive (true);
		menuuimanager.PressMenuOption (8);
		//Debug.Log ("Current select elemtn is " + id);
	}


	private void DeselectElement(){
		menuuimanager.CurrentSelectedElement1 = -1;
		DisableOptionButtonArray ();

	}

	public void DisableOptionButtonArray(){
		ElementOptionButtonArray.SetActive (false);

	}

	public void PressOption1(){
		menuuimanager.PressMenuOption (1);
		UpdateGalleryManager ();

		

	}
	public void PressOption2(){
		menuuimanager.PressMenuOption (2);
		UpdateGalleryManager ();

	}	
	public void PressOption3(){
		menuuimanager.PressMenuOption (3);
		UpdateGalleryManager ();

	}	
	public void PressOption4(){
		menuuimanager.PressMenuOption (4);
		UpdateGalleryManager ();

	}	
	public void PressOption5(){
		menuuimanager.PressMenuOption (5);
		UpdateGalleryManager ();

	}

	public void PressNextPage(){
		CurrentPage++;
		UpdateGalleryManager ();
	}

	public void PressPrevPage(){
		CurrentPage--;
		UpdateGalleryManager ();
	}



	private void SetOptionButton(){
		if (CurrentGalleryUI.CanCreatNew == true) {
			NewElementButton.SetActive (true);

		} else {
			NewElementButton.SetActive (false);

		}
		OptionButtonList.Add (OptionButton1);
		OptionButtonList.Add (OptionButton2);
		OptionButtonList.Add (OptionButton3);
		OptionButtonList.Add (OptionButton4);
		OptionButtonList.Add (OptionButton5);
		OptionButtonTextList.Add (OptionButtonText1);
		OptionButtonTextList.Add (OptionButtonText2);
		OptionButtonTextList.Add (OptionButtonText3);
		OptionButtonTextList.Add (OptionButtonText4);
		OptionButtonTextList.Add (OptionButtonText5);

		OptionButton1.SetActive (false);
		OptionButton2.SetActive (false);
		OptionButton3.SetActive (false);
		OptionButton4.SetActive (false);
		OptionButton5.SetActive (false);

		for(int i = 0; i < CurrentGalleryUI.OptionsAvailable; i++){
			OptionButtonList [i].SetActive(true);
			OptionButtonTextList [i].text = CurrentGalleryUI.OptionTextList [i];
		}
	
	}
}
