using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildTileData : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler{

	public int TileID;
	public int Xposition;
	public int Yposition;
	public MapObject tileobject;
	public MapTile tile;
	public Color tilenormalcolor;
	private Image tileimage;
	private GameObject buildmapmenu;
	private BuildMapMenuManager buildmapmenumanager;


	public void StartTileData(){
		buildmapmenu = this.transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject;
		buildmapmenumanager = buildmapmenu.GetComponent<BuildMapMenuManager> ();
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
		buildmapmenumanager.HoveOverTile (tileobject,tile);

	}

	public void OnPointerExit(PointerEventData eventData){

		tileimage.color = tilenormalcolor;
		buildmapmenumanager.ExitOverTile ();
	}

	public void OnPointerDown(PointerEventData eventData){

		buildmapmenumanager.PressOnTile (TileID ,tileobject.Type, tileobject.ID);


	}
}
