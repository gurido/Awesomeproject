using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldDictionary : MonoBehaviour {


	public static readonly Dictionary<int, string> MapObjectTypeDictionary = new Dictionary<int, string> {

		{-1, "Nothing"},
		{0, "Ground"},
		{1, "Wall"},
		{2, "Access Point"},
		{3, "Furniture"},
		{4, "Water"},
		{5, "Tree"},
		{6, ""}

	};



	public static readonly Dictionary<int, string> MapTypeDictionary = new Dictionary<int, string> {

		{0, "None"},
		{1, "Room"},
		{2, "Building"},
		{3, "Street"},
		{4, "City"},
		{5, "Country"},
		{6, "World"}

	};

	public static readonly Dictionary<int, string> RoomTypeDictionary = new Dictionary<int, string> {

		{0, "None"},
		{1, "Bedroom"},
		{2, "Dormitory"},		
		{3, "Hotel Room"},
		{4, "Living Room"},
		{5, "Kitchen"},
		{6, "Toilet"},
		{7, "Shower"},
		{8, "Restaurant"},
		{9, "Bank"},
		{10, "Classroom"},
		{11, "Hospital room"},
		{12, "Bar"},
		{13, "Arcane Room"},
		{14, "Garage"},
		{15, "Storage Room"},
		{16, "Shop"},
		{17, "Jail Room"},
		{18, "Interrogation Room"},
		{19, "Transport Station"},
		{20, ""},
		{21, "Office Room"},
		{22, ""},
		{23, "Courtroom"},
		{24, "Waiting room"},
		{25, ""},
		{26, ""},
		{27, ""}

	};

	public static readonly Dictionary<int, string> BuildingTypeDictionary = new Dictionary<int, string> {

		{0, "None"},
		//Commercial
		{1, "Kiosk"},//buy magazine, newspaper, drink, snacks, smoke etc
		{2, "Bathhouse"},//public bathing
		{3, "Public Toiler"},//pee/poop
		{4, "Arcade"},//play arcane games
		{5, "Pharmacy"},// buy medicine
		{6, "Gasoline station"},//gasoline
		{7, "Market Stall"},//street market
		{8, "Shopping mall"},//big building with shops, restaurant, cinema and parking
		{9, "Convienent Store"},//buy all sorts of daily products
		{10, "Supermarket"},//big place to buy all sorts of stuff
		{11, "Department Store"},//buy a lot of stuff in a huge warehosue place
		{12, "Pet shop"},//buy pets
		{13, "Book Shop"},//buy book
		{14, "Toy Shop"},//buy toys
		{15, "Clothe Shop"},//buy clothes
		{16, "Electronics Shop"},//buy electronics
		{17, "Pawn Shop"},//sell stuff and buy various old cheap thing, always changing
		{18, "Furniture Shop"},//buy furniture
		{19, "Weapon Shop"},//buy weapon
		{20, "Florist"},//buy plants and flowers
		{21, "Gym"},//train muscles
		{22, "Hairdressers"},//do hairstyle
		{23, "Office building"},//working happenes
		{24, "Restaurant"},//serve food and drinks
		{25, "Cafe"},//serve cafe tea and little snacks
		{26, "Bar"},//serve alcohol and some food
		{27, "Internet Cafe"},//buy drink and use computer with internet
		{28, "Hotel"},//stay for a night
		{29, "Curiosity Shop"},//buy curious stuffs
		{30, ""},
		//Residential buildings
		{31, "Apartment block"},//Block with apartments
		{32, "Dormitory"},//building with lots of dormitories
		{33, "Tent"},//fragile single lil room
		{34, "Sleeping bag"},//just for sleeping
		{35, "Cottage"},//smol house
		{36, "House"},//a single house
		{37, "Townhouse"},//a big house
		{38, "Mansion"},//a huge house
		{39, "Villa"},//a very huge house
		{40, "Castle"},//a gigantic house
		//Medical buildings
		{41, "Psychiatric Hospital"},//get mental illness checked and cured
		{42, "Hospital"},//get illness checked and cured
		{43, "Nursing Home"},//keep disabled and old ppl
		{44, "Quarantine"},//keep very infectious ppl 
		{45, "Asylum"},//keep crazy people 
		//Educational Buildings
		{46, "Nursery"},//school for baby
		{47, "College"},//college for young adults
		{48, "School"},//school for kids and teens
		{49, "Boarding schools"},//school with dormitory
		{50, "Museum"},//place to preserve things and let ppl see
		{51, "Art Gallery"},//place to hold art stuff
		{52, "Theater"},//place to watch theater
		{53, "Convention center"},//where events are hold
		{54, "Concert Hall"},//where concerts happen
		{55, "Cinema"},//place to watch movie
		{56, "Opera house"},//place to watch opera
		{57, "Library"},//place to read book
		//Government building
		{58, "City hall"},//residence documents
		{59, "Embassy"},//othe country matters
		{60, "Courthouse"},//goes to court
		{61, "Parliament house"},//where politicians gather and discuss
		{62, "Fire station"},//firefighers operate here
		{63, "Prison"},//keep climinals
		{64, "Police station"},//polices are here
		{65, "Post office"},//send mails
		{66, "Orphanage"},//keep orphans
		{67, "Graveyard"},//keep dead people
		{68, "Data centre"},//internet server storage
		//industrial buildings
		{69, "Barn"},//place that keeps animals
		{70, "Water Tower"},//city water source 
		{71, "Factory"},//fabricates things by importing and exporting thing
		{72, "Power plant"},//city electricity source
		{73, "Workshop"},//where ppl make stuff
		{74, "Film studio"},//where ppl film movies
		{75, "Mill"},//wind mill or water mill
		{76, "Brewery"},//make beer
		//Military buildings
		{77, "Arsenal"},
		{78, "Barracks"},
		{79, "Bunker"},
		{80, "Blockhouse"},
		{81, "Citadel"},
		{82, "Missile launch facility"},
		//Parking structures and storage
		{83, "Boathouse"},//park boat
		{84, "Garage"},//part 1 or 2 cars/moto/bike
		{85, "Aircraft"},//Part Airplanes
		{86, "Stable"},//park horses
		{87, "Parking Lot"},//park lots of cars/moto/bike
		{88, "Storage Silo"},//big storage area
		{89, "Warehouse"},//single storage building
		//Religious buildings
		{90, "Church"},//go for christian misa
		{91, "Cathedral"},//big church with place for bishop
		{92, "Pagoda"},//place of worship for taoism
		{93, "Mosque"},//place of worship for islamism
		{94, "Monastery"},//place place for monk and nurse
		{95, "Temple"},//place where religious rituals and sacrifaces
		{96, "Shrine"},//religious place dedicated to specific saint/hero/deity/martyr/ancestor/daemon
		//Transport Buldings
		{97, "Airport"},//ride airplace
		{98, "Bus Station"},//ride bus
		{99, "Subway station"},//ride subway
		{100, "Taxi Station"},//ride taxi
		{101, "Train Station"},//ride train
		{102, "Lighthouse"},//ride boat
		{103, "Space Station"},//ride spaceship
		//Non buildings
		{104, "Playground"},//playground for kids
		{105, "Tunnel"}, //entrance/exit to a tunnel
		{106, "Gate"},//openair door on fences or walls
		{107, "Fence"},//cannot pass throughb
		{108, "Bridge"},//midair road
		{109, "Arena"},//ppl fight for entertainment
		{110, "Amusement parks"},//have fun
		{111, "Zoo"},//animals
		{112, "Aquarium"},//fishes
		{113, "Sport Stadium"},//Sport event
		{114, "Swimming Pool"},//can swim
		{115, "Dungeon"},//underground structure
		{116, "Dumpster"},//puts lots of garbage in here
		{117, "Transmission Tower"},//pass on electricity
		{118, "Street light"},//light up street
		{119, "Statue"},//art
		{120, "Street Sign"},//traffice stuff
		{121, "Bench"},//place to sit
		{122,"Park"},//public park for relaxation
		{123,"Cave"},//building inside rocky place
		{124,""},
		{125,""}

	};

	public static readonly Dictionary<int, string> StreetTypeDictionary = new Dictionary<int, string> {

		{0, ""},
		{1, ""},
		{2, ""},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""},
		{8, ""},
		{9, ""},
		{10, ""},
		{11, ""},
		{12, ""},
		{13, ""},
		{14, ""},
		{15, ""},
		{16, ""},
		{17, ""},
		{18, ""},
		{19, ""},
		{20, ""},
		{21, ""},
		{22, ""},
		{23, ""},
		{24, ""},
		{25, ""},
		{26, ""},
		{27, ""}
	};

	public static readonly Dictionary<int, string> CityTypeDictionary = new Dictionary<int, string> {

		{0, ""},
		{1, ""},
		{2, ""},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""},
		{8, ""},
		{9, ""},
		{10, ""},
		{11, ""},
		{12, ""},
		{13, ""},
		{14, ""},
		{15, ""},
		{16, ""},
		{17, ""},
		{18, ""},
		{19, ""},
		{20, ""},
		{21, ""},
		{22, ""},
		{23, ""},
		{24, ""},
		{25, ""},
		{26, ""},
		{27, ""}
	};

	public static readonly Dictionary<int, string> CountryTypeDictionary = new Dictionary<int, string> {

		{0, ""},
		{1, ""},
		{2, ""},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""},
		{8, ""},
		{9, ""},
		{10, ""},
		{11, ""},
		{12, ""},
		{13, ""},
		{14, ""},
		{15, ""},
		{16, ""},
		{17, ""},
		{18, ""},
		{19, ""},
		{20, ""},
		{21, ""},
		{22, ""},
		{23, ""},
		{24, ""},
		{25, ""},
		{26, ""},
		{27, ""}
	};
}
