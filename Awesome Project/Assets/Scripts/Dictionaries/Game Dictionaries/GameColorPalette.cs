using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameColorPalette : MonoBehaviour {

	public static Color Black = new Color32(0,0,0,255);
	public static Color White = new Color32 (255,255,255,255);
	public static Color Cyan = Color.cyan;
	public static Color Red = Color.red;
	public static Color Yellow = Color.yellow;
	public static Color Blue = Color.blue;
	public static Color Grey = Color.grey;

	public static Color GreyBlue = new Color32(179,216,216,255);
	public static Color LimonYellow = new Color32(244,249,180,255);




	public static readonly Dictionary<string, Color> GamePaletteDictionary = new Dictionary<string, Color> {

		{"TileNullColor", GreyBlue},
		{"TileHoverOverColor", White},

		{"TileAccessPointColor" , Blue},
		{"TileWallColor", Grey},
		{"TileFurnitureColor", Yellow},
		{"TileWaterColor", Cyan}


	};
}
