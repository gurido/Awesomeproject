using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TileData : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler  {

	public int TileID;
	public int Xposition;
	public int Yposition;
	public MapObject tileobject;
	public Color tilenormalcolor;
	private Image tileimage;
	private GameObject mapmenu;
	private MapMenuManager mapmenumanager;


	public void StartTileData(){
		mapmenu = GameObject.Find ("MainCanvas").transform.GetChild (1).gameObject.transform.GetChild (8).gameObject;
		mapmenumanager = mapmenu.GetComponent<MapMenuManager> ();
		//Debug.Log ("current map is " + mapmenumanager.CurrentGameMapID);
		tileimage = this.GetComponent<Image> ();


		SwitchTileGraphic ();
		tileimage.color = tilenormalcolor;

	}


	private void SwitchTileGraphic(){
		switch(tileobject.Type){
		case -1://does not exist
			tilenormalcolor = GameColorPalette.GamePaletteDictionary["TileNullColor"];
			break;
		case 1://wall
			tilenormalcolor = GameColorPalette.GamePaletteDictionary["TileWallColor"];
			break;
		case 2://access point
			tilenormalcolor = GameColorPalette.GamePaletteDictionary["TileAccessPointColor"];
			break;
		case 3://furniture
			tilenormalcolor = GameColorPalette.GamePaletteDictionary["TileFurnitureColor"];
			break;
		case 4://water
			tilenormalcolor = GameColorPalette.GamePaletteDictionary["TileWaterColor"];
			break;
		case 5://
			break;

		default:
			break;

		}
	}


	public void OnPointerEnter(PointerEventData eventData){


		tileimage.color = GameColorPalette.GamePaletteDictionary["TileHoverOverColor"];


	}

	public void OnPointerExit(PointerEventData eventData){

		tileimage.color = tilenormalcolor;

	}

	public void OnPointerDown(PointerEventData eventData){

		mapmenumanager.PressOnTile (tileobject.Type, tileobject.ID);


	}


}
