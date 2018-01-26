using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGameMenuManager : MonoBehaviour {
	private IntroStatusManager introstatusmanager;


	private MenuUIManager menuuimanager;

	public GalleryUI gameselectmenugallery;
	//public int GalleryElementNumber;
	public List<GalleryElement> galleryelementlist;
	public GalleryElement currentgalleryelement;



	public void SelectGameMenuManagerStart(){
		introstatusmanager = GameObject.Find ("_GameManager").GetComponent<IntroStatusManager> ();
		LoadSelectGameMenuData ();
		LoadGallery ();

	}

	public void SelectGameMenuManagerUpdate(){

	}


	private void LoadSelectGameMenuData(){
		galleryelementlist = new List<GalleryElement> (){ };
		List<string> currentoptiontext = new List<string>(){"Play Game","Game Detail","Build Game","Duplicate Game","Delete Game"};

		Sprite gallerythumbnail1 = Resources.Load<Sprite> ("Sprites/Game/Thumbnail/placeholder1");
		Sprite gallerythumbnail2 = Resources.Load<Sprite> ("Sprites/Game/Thumbnail/placeholder2");

		currentgalleryelement = new GalleryElement (0,"game 1",gallerythumbnail1);
		galleryelementlist.Add (currentgalleryelement);
		currentgalleryelement = new GalleryElement (1,"game 2",gallerythumbnail2);
		galleryelementlist.Add (currentgalleryelement);


		gameselectmenugallery = new GalleryUI(0,"Game Gallery",true,"New Game",5,currentoptiontext,galleryelementlist);

	}

	private void LoadGallery(){

		menuuimanager = GetComponent<MenuUIManager> ();
		menuuimanager.StartMenuUIManager (1,1);
	}


	public void ExitMenu(){
		introstatusmanager.SwitchToIntroMenu ();

	}

	public void AddGame(){
		int galleryid = galleryelementlist.Count;
		Sprite newgamesprite = Resources.Load<Sprite> ("");
		currentgalleryelement = new GalleryElement (galleryid,"New Game", newgamesprite);
		galleryelementlist.Add (currentgalleryelement);

	}

	public void DeleteGame(int id){
		Debug.Log ("Delete Game" + id);
		galleryelementlist.RemoveAt(id);


	}

	public void PlayGame(int id){
		introstatusmanager.SwitchToPlaySession ();
	}

	public void GameDetail(int id){
		Debug.Log ("Looking at game " + id);
	}


	public void EditGame(int id){
		Debug.Log ("Edit game " + id);

	}

	public void DuplicateGame(int id){
		Debug.Log ("Duplicate game" + id);

	}


}
