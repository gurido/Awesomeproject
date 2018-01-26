using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;



public class DatabaseManager : MonoBehaviour {

	//load main database




	//old bunch
	public List<GamePanel> uipanelList = new List<GamePanel>();
	public List<string> CharacterNameList = new List<string>();
	public List<Character> CharacterList = new List<Character>();
	public List<ItemType> itemTypeDatabase = new List<ItemType> ();
	public List<Item> itemDatabase = new List<Item>();
	public List<GameMap> GameMapDatabase = new List<GameMap> ();

	private JsonData CurrentJsonData;


	public void StartDatabaseManager(){


	}


	public void ConstructGame(){

		ConstructGameDatabase (0);//Player
		ConstructGameDatabase (1);//itemtype
		ConstructGameDatabase (3);//item
		ConstructGameDatabase (4);//character name list
		ConstructGameDatabase (5);//character list
		ConstructGameDatabase (7);//game panels
		ConstructGameDatabase (8);//game map data
		//ConstructDatabase (10);//furniture data

	}




	private void ConstructGameDatabase(int databaseID){

		switch(databaseID){
		case 0://PlayerData
			ConstructPlayerData(0);
			break;
		case 1: //ItemData
			ConstructItemDatabase(1);
			break;
		case 2: //ItemFunctionData
			break;
		case 3: //ItemTypeData
			ConstructItemTypeDatabase(3);
			break;
		case 4: //character name list
			ConstructCharacterNameList ();
			break;
		case 5: //character database
			ConstructCharacterList();
			break;
		case 6://A single character
			ConstructCharacter("DefaultCharacter", 0);
			break;
		case 7://Panel Data
			ConstructGamePanelDatabase();
			break;
		case 8://GameMap data
			ConstructGameMapDatabase(8);
			break;
		case 9://
			break;
		case 10://Furniture Data
			ConstructFurnitureDatabase(10);
			
			break;
		case 11://Furniture Type Data
			break;
		default:
			break;
		}
	
	}



	public Item FetchItemByID(int id){
		for (int i = 0; i < itemDatabase.Count; i++) {
			if (itemDatabase[i].ItemID == id){
				return itemDatabase [i];
			}
		}
		return null;
	}

	public ItemType FetchItemTypeByID(int id){
		for (int i = 0; i < itemTypeDatabase.Count; i++) {
			if (itemTypeDatabase[i].TypeID == id){
				return itemTypeDatabase [i];
			}
		}
		return null;

	}




	private void ConstructPlayerData(int database){
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + GameobjectPathDictionary.JsonFilePath[GameobjectPathDictionary.DatabaseDictionary[database]]));

	}



	private void ConstructGamePanelDatabase(){
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText(Application.dataPath + GameobjectPathDictionary.JsonFilePath["GamePanelData"]));
		for (int i = 0; i < CurrentJsonData.Count ; i++){
			uipanelList.Add(new GamePanel((int)CurrentJsonData[i]["PanelID"],(string)CurrentJsonData[i]["PanelName"].ToString()));
		}
	}



	private void ConstructItemDatabase(int database){
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + GameobjectPathDictionary.JsonFilePath[GameobjectPathDictionary.DatabaseDictionary[database]]));

		for (int i = 0; i < CurrentJsonData.Count ; i++){
			itemDatabase.Add(new Item((int)CurrentJsonData[i]["ItemID"], CurrentJsonData[i]["ItemName"].ToString(), (int)CurrentJsonData[i]["ItemType"], CurrentJsonData[i]["ItemDescription"].ToString(), (int)CurrentJsonData[i]["GlobalPrice"]));
		}
	}
 


	private void ConstructItemTypeDatabase(int database){
		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + GameobjectPathDictionary.JsonFilePath[GameobjectPathDictionary.DatabaseDictionary[database]]));

		for (int i = 0; i < CurrentJsonData.Count ; i++){
			List<ItemSubType> itemSubTypeDatabase = new List<ItemSubType>();

			for (int x = 0; x < CurrentJsonData[i]["SubTypes"].Count ; x++){

				itemSubTypeDatabase.Add(new ItemSubType((int)CurrentJsonData[i]["SubTypes"][x]["SubTypeID"], CurrentJsonData[i]["SubTypes"][x]["SubTypeName"].ToString(), (int)CurrentJsonData[i]["SubTypes"][x]["SubTypeFunction"]));
			}
			itemTypeDatabase.Add(new ItemType((int)CurrentJsonData[i]["TypeID"], CurrentJsonData[i]["TypeName"].ToString(), (bool)CurrentJsonData[i]["Stackable"],itemSubTypeDatabase));
		}
	}

	private void ConstructGameMapDatabase(int database){
		CurrentJsonData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + GameobjectPathDictionary.JsonFilePath[GameobjectPathDictionary.DatabaseDictionary[database]]));
		for (int i = 0; i < CurrentJsonData.Count; i++) {

			List<MapObject> CurrentMapObjectList = new List<MapObject> ();

			for(int x = 0; x < CurrentJsonData[i]["MapObjectList"].Count; x ++){
				CurrentMapObjectList.Add (new MapObject( (int)CurrentJsonData[i]["MapObjectList"][x]["Type"],(int)CurrentJsonData[i]["MapObjectList"][x]["ID"],(int)CurrentJsonData[i]["MapObjectList"][x]["PositionX"],(int)CurrentJsonData[i]["MapObjectList"][x]["PositionY"] ));
			}

			List<MapTile> CurrentMapTileList = new List<MapTile> ();
			for (int y = 0; y < CurrentJsonData [i] ["MapTileList"].Count; y++) {
				CurrentMapTileList.Add (new MapTile((int)CurrentJsonData[i]["MapTileList"][y]["ID"],(int)CurrentJsonData[i]["MapTileList"][y]["TileType"],(int)CurrentJsonData[i]["MapTileList"][y]["PositionX"],(int)CurrentJsonData[i]["MapTileList"][y]["PositionY"]));

			}


			GameMapDatabase.Add (new GameMap( (int)CurrentJsonData[i]["ID"], CurrentJsonData[i]["Name"].ToString(), CurrentJsonData[i]["Description"].ToString(),(int)CurrentJsonData[i]["Type"],(int)CurrentJsonData[i]["SizeX"],(int)CurrentJsonData[i]["SizeY"],CurrentMapTileList , CurrentMapObjectList ));
		}

	}

	private void ConstructFurnitureDatabase(int database){
		CurrentJsonData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + GameobjectPathDictionary.JsonFilePath[GameobjectPathDictionary.DatabaseDictionary[database]]));
		for (int i = 0; i < CurrentJsonData.Count; i++) {


		}
	}


	private void ConstructCharacterNameList(){
		string CharacterName1 = "DefaultCharacter";
		CharacterNameList.Add (CharacterName1);
	}


	private void ConstructCharacterList(){

		for (int i = 0; i < CharacterNameList.Count ; i++){
			string name = CharacterNameList [i];
			CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/StreamingAssets/Character Configurations/" + name + ".json"));
			JsonToCharacter (0);
		}
	}

	private void ConstructCharacter(string name, int i){

		CurrentJsonData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/StreamingAssets/Character Configurations/" + name + ".json"));
		JsonToCharacter (i);

	}

	private void JsonToCharacter(int i){


		List<DayRoutine> sundayroutines = new List<DayRoutine> ();
		List<DayRoutine> saturdayroutines = new List<DayRoutine> ();
		List<DayRoutine> fridayroutines = new List<DayRoutine> ();
		List<DayRoutine> thursdayroutines = new List<DayRoutine> ();
		List<DayRoutine> wednesdayroutines = new List<DayRoutine> ();
		List<DayRoutine> tuesdayroutines = new List<DayRoutine> ();
		List<DayRoutine> mondayroutines = new List<DayRoutine> ();

		WeekRoutine weekroutine = new WeekRoutine(mondayroutines,tuesdayroutines,wednesdayroutines,thursdayroutines,fridayroutines,saturdayroutines,sundayroutines);

		CharacterInventory inventory = new CharacterInventory();
		List<RegularExpense> regularexpenses = new List<RegularExpense> ();
		List<RegularIncome> regularincomes = new List<RegularIncome> ();

		int wealth = (int)CurrentJsonData[i]["wealth"];
		Property property = new Property(wealth, regularincomes,regularexpenses,inventory);

		int currentposition = (int)CurrentJsonData[i]["currenttime"];
		int currenttime = (int)CurrentJsonData[i]["currentposition"];
		PhysicalTemporal physicaltemporal = new PhysicalTemporal(currentposition,currenttime);


		List<Relationship> relationshiplist = new List<Relationship> ();
		List<Reputation> reputationlist = new List<Reputation> ();


		List<MentalDisorder> mentalhealth = new List<MentalDisorder> ();
		Skills skills = new Skills();

		List<Event> pastlifeevents = new List<Event> ();
		List<Motivation> pastlifemotivations = new List<Motivation> ();
		List<Need> pastlifeneeds = new List<Need> ();
		List<Thought> pastlifethoughts = new List<Thought> ();

		List<Event> pastyearevents = new List<Event> ();
		List<Motivation> pastyearmotivations = new List<Motivation> ();
		List<Need> pastyearneeds = new List<Need> ();
		List<Thought> pastyearthoughts = new List<Thought> ();

		List<Event> pastmonthevents = new List<Event> ();
		List<Motivation> pastmonthmotivations = new List<Motivation> ();
		List<Need> pastmonthneeds = new List<Need> ();
		List<Thought> pastmonththoughts = new List<Thought> ();

		List<Event> pastweekevents = new List<Event> ();
		List<Motivation> pastweekmotivations = new List<Motivation> ();
		List<Need> pastweekneeds = new List<Need> ();
		List<Thought> pastweekthoughts = new List<Thought> ();

		List<Event> pastdayevents = new List<Event> ();
		List<Motivation> pastdaymotivations = new List<Motivation> ();
		List<Need> pastdayneeds = new List<Need> ();
		List<Thought> pastdaythoughts = new List<Thought> ();

		PastLifetimeEvent pastlife = new PastLifetimeEvent(pastlifethoughts,pastlifeneeds,pastlifemotivations,pastlifeevents);
		PastYearEvent pastyear = new PastYearEvent(pastyearthoughts,pastyearneeds,pastyearmotivations,pastyearevents);
		PastMonthEvent pastmonth = new PastMonthEvent(pastmonththoughts,pastmonthneeds,pastmonthmotivations,pastmonthevents);
		PastWeekEvent pastweek = new PastWeekEvent(pastweekthoughts,pastweekneeds,pastweekmotivations,pastweekevents);
		PastDayEvent pastday = new PastDayEvent(pastdaythoughts,pastdayneeds,pastdaymotivations,pastdayevents);
		Memory memory = new Memory(pastday,pastweek,pastmonth,pastyear,pastlife);


		int currentvigilance = (int)CurrentJsonData[i]["currentvigilance"];
		int currentecstasy = (int)CurrentJsonData[i]["currentecstasy"];
		int currentadmiration = (int)CurrentJsonData[i]["currentadmiration"];
		int currentterror = (int)CurrentJsonData[i]["currentterror"];
		int currentamazement = (int)CurrentJsonData[i]["currentamazement"];
		int currentgrief = (int)CurrentJsonData[i]["currentgrief"];
		int currentloathing = (int)CurrentJsonData[i]["currentloathing"];
		int currentrage = (int)CurrentJsonData[i]["currentrage"];
		CurrentEmotion emotion = new CurrentEmotion(currentrage,currentloathing,currentgrief,currentamazement,currentterror,currentadmiration,currentecstasy,currentvigilance);


		Cognition cognition = new Cognition();

		int extraversion = (int)CurrentJsonData[i]["extraversion"];
		int openness = (int)CurrentJsonData[i]["openness"];
		int neuroticism = (int)CurrentJsonData[i]["neuroticism"];
		int agreeableness = (int)CurrentJsonData[i]["agreeableness"];
		int conscientiousness = (int)CurrentJsonData[i]["conscientiousness"];
		FundamentalPersonalityCharacteristics characteristics = new FundamentalPersonalityCharacteristics(conscientiousness,agreeableness,neuroticism,openness,extraversion);
		Personality personality = new Personality(characteristics);

		int air = (int)CurrentJsonData[i]["air"];
		int shelter = (int)CurrentJsonData[i]["shelter"];
		int warmth = (int)CurrentJsonData[i]["warmth"];
		int sleep = (int)CurrentJsonData[i]["sleep"];
		int water = (int)CurrentJsonData[i]["water"];
		int food = (int)CurrentJsonData[i]["food"];
		BodyNeeds needs = new BodyNeeds(food,water,sleep,warmth,shelter,air);

		int currentenergy = (int)CurrentJsonData[i]["currentenergy"];
		int maxenergy = (int)CurrentJsonData[i]["maxenergy"];
		int consciousstate = (int)CurrentJsonData[i]["consciousstate"];
		bool deadoralive = (bool)CurrentJsonData[i]["deadoralive"];

		BodyCondition bodycondition = new BodyCondition(deadoralive,consciousstate,maxenergy,currentenergy,needs);

		bool rightarm = (bool)CurrentJsonData[i]["rightarm"];
		bool leftarm = (bool)CurrentJsonData[i]["leftarm"];
		bool rightleg = (bool)CurrentJsonData[i]["rightleg"];
		bool leftleg = (bool)CurrentJsonData[i]["leftleg"];
		bool smell = (bool)CurrentJsonData[i]["smell"];
		bool hearing = (bool)CurrentJsonData[i]["hearing"];
		bool sight = (bool)CurrentJsonData[i]["sight"];
		BodyParts bodyparts = new BodyParts(sight,hearing,smell,leftleg,rightleg,leftarm,rightarm);

		int bodytype = (int)CurrentJsonData[i]["bodytype"];
		int sex = (int)CurrentJsonData[i]["sex"];
		int height = (int)CurrentJsonData[i]["height"];
		int age = (int)CurrentJsonData[i]["age"];
		int race = (int)CurrentJsonData[i]["race"];
		BasicBodyStats bodystats = new BasicBodyStats(race,age,height,sex,bodytype);

		string firstname = (string)CurrentJsonData[i]["firstname"].ToString();
		string lastname = (string)CurrentJsonData[i]["lastname"].ToString();
		int nametype = (int)CurrentJsonData[i]["nametype"];
		string commonnickname = (string)CurrentJsonData[i]["commonnickname"].ToString();

		string slug = (string)CurrentJsonData[i]["slug"].ToString();
		int id = (int)CurrentJsonData[i]["id"];

		CharacterName charactername = new CharacterName (firstname,lastname,nametype,commonnickname);
		Body body = new Body (bodystats,bodyparts,bodycondition);
		Mind mind = new Mind (personality,cognition,emotion,memory,mentalhealth,skills);
		SocialCondition social = new SocialCondition (relationshiplist,reputationlist);
		PhysicalCondition physical = new PhysicalCondition (physicaltemporal,property,weekroutine);
		CharacterSprites sprites = new CharacterSprites (slug);

		Character CurrentCharacter = new Character(charactername,id,body,mind,social,physical,sprites);
		CharacterList.Add (CurrentCharacter);

	}
}
