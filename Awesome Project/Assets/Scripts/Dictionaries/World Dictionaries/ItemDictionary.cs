using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDictionary : MonoBehaviour {


	public static readonly Dictionary<int, string> FurnitureTypeDictionary = new Dictionary<int, string> {

		{0, "none"},
		{1, "Bed"},//sleep, lay down, sit
		{2, "DoubleBed"},//sleep, lay down, sit
		{3, "Closet"},//storage
		{4, "Shelf"},//storage
		{5, "Bathtub"},//bath
		{6, "Shower"},//shower
		{7, "Toilet"},//pee, poop
		{8, "Sink"},//wash, get water
		{9, "Table"},//
		{10, "Chair"},//sit,
		{11, "Sofa"},//sleep, lay down, sit
		{12, "Fridge"},//storage
		{13, "Microwave"},//Electronical, Heat food
		{14, "Oven"},//Electronical, cook
		{15, "Stove"},//Electronical, cook
		{16, "TV"},//Electronical, watch
		{17, "Computer"},//Electronical, use, play, play music
		{18, "Game Console"},//Electronical, play
		{19, "Washing Machine"},//Electronical, wash clothe
		{20, "Dish Washer"},//Electronical, wash dishes
		{21, "Heater"},//Electronical, more temperature
		{22, "Air Conditioner"},//Electronical, less temperature
		{23, "Lamp"},//Electronical, turn on/off
		{24, "Music Player"},//Electronical, put music on
		{25, "Casher"},//Electronical, buy thing
		{26, "Bank Machine"},//Electronical, take money life
		{27, "Screen"},//Electronical, look
		{28, "Mirror"},//look
		{29, "Whiteboard"},//look
		{30, "Painting"},//look
		{31, "Door"},//open
		{32, "Door With Lock"},//open with key
		{33, "Automatic Door"},//Electronical
		{34, "Stair"},//go up/down
		{35, "Electrical stair"},//Electronical, go up/down
		{36, "Elevator"},//Electronical, go up/down
		{37, "Window"},
		{38, "Window With Curtain"},//close curtain
		{39, "Camera"},//Electronical, record image
		{40, "Audio recorder"},//Electronical, record audio
		{41, "Music Instrument"},//Play Music instrument
		{42, ""},

	};


	public static readonly Dictionary<int, string> ItemTypeDictionary = new Dictionary<int, string> {

		{0, "none"},
		{1, "Food"},//eat
		{2, "Drink"},//drink
		{3, "Resources"},
		{4, "Tools"},//has an function
		{5, ""}

	};


	public static readonly Dictionary<int, string> ObjectFunctionDictionary = new Dictionary<int, string> {

		{0, "none"},
		{1, "Sleep"},
		{2, "Sit"},
		{3, "Lay Down"},
		{4, "Storage"},
		{5, "Bath"},
		{6, "Shower"},
		{7, "Pee"},
		{8, "Poop"},
		{9, "Wash"},
		{10, "Get Water"},
		{11, "Heat Food"},
		{12, "Cook"},
		{13, "Watch"},
		{14, "Computer"},
		{15, "Put Music On"},
		{16, "Play Game"},
		{17, "Wash Dishes"},
		{18, "Wash Clothes"},
		{19, "Up Room Temperature"},
		{20, "Down Room Temperature"},
		{21, "Turn On/Off Light"},
		{22, "Pay Money"},
		{23, "Take Out Money"},
		{24, "Lock/Unlock"},
		{25, "Stair"},
		{26, "Elevator"},
		{27, "Close Curtain"},
		{28, "Record Video"},
		{29, "Record Audio"},
		{30, "Play Music Instrument"},
		{31, ""},
		{32, ""},
		{33, ""},
		{34, ""},
		{35, ""},
		{36, ""},
		{37, ""}


	};
}
