using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class CharacterManager : MonoBehaviour {

	public void CharacterManagerStart () {


	}



}



/*
	public List<Character> CharacterList = new List<Character>();
	public List<string> CharacterNameList = new List<string>();


	private JsonData CharacterData;

	public void CharacterManagerStart () {
		//ConstructCharacter ("DefaultCharacter", 0);
		ConstructCharacterList();

	}


	private void ConstructCharacterNameList(){
		string CharacterName1 = "DefaultCharacter";
			CharacterNameList.Add (CharacterName1);
	}


	private void ConstructCharacterList(){
		ConstructCharacterNameList ();


		for (int i = 0; i < CharacterNameList.Count ; i++){
			string name = CharacterNameList [i];
			CharacterData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/StreamingAssets/Character Configurations/" + name + ".json"));
			JsonToCharacter (0);
		}
	}

	private void ConstructCharacter(string name, int i){

		CharacterData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/StreamingAssets/Character Configurations/" + name + ".json"));
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

		int wealth = (int)CharacterData[i]["wealth"];
		Property property = new Property(wealth, regularincomes,regularexpenses,inventory);

		int currentposition = (int)CharacterData[i]["currenttime"];
		int currenttime = (int)CharacterData[i]["currentposition"];
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


		int currentvigilance = (int)CharacterData[i]["currentvigilance"];
		int currentecstasy = (int)CharacterData[i]["currentecstasy"];
		int currentadmiration = (int)CharacterData[i]["currentadmiration"];
		int currentterror = (int)CharacterData[i]["currentterror"];
		int currentamazement = (int)CharacterData[i]["currentamazement"];
		int currentgrief = (int)CharacterData[i]["currentgrief"];
		int currentloathing = (int)CharacterData[i]["currentloathing"];
		int currentrage = (int)CharacterData[i]["currentrage"];
		CurrentEmotion emotion = new CurrentEmotion(currentrage,currentloathing,currentgrief,currentamazement,currentterror,currentadmiration,currentecstasy,currentvigilance);


		Cognition cognition = new Cognition();

		int extraversion = (int)CharacterData[i]["extraversion"];
		int openness = (int)CharacterData[i]["openness"];
		int neuroticism = (int)CharacterData[i]["neuroticism"];
		int agreeableness = (int)CharacterData[i]["agreeableness"];
		int conscientiousness = (int)CharacterData[i]["conscientiousness"];
		FundamentalPersonalityCharacteristics characteristics = new FundamentalPersonalityCharacteristics(conscientiousness,agreeableness,neuroticism,openness,extraversion);
		Personality personality = new Personality(characteristics);

		int air = (int)CharacterData[i]["air"];
		int shelter = (int)CharacterData[i]["shelter"];
		int warmth = (int)CharacterData[i]["warmth"];
		int sleep = (int)CharacterData[i]["sleep"];
		int water = (int)CharacterData[i]["water"];
		int food = (int)CharacterData[i]["food"];
		BodyNeeds needs = new BodyNeeds(food,water,sleep,warmth,shelter,air);

		int currentenergy = (int)CharacterData[i]["currentenergy"];
		int maxenergy = (int)CharacterData[i]["maxenergy"];
		int consciousstate = (int)CharacterData[i]["consciousstate"];
		bool deadoralive = (bool)CharacterData[i]["deadoralive"];

		BodyCondition bodycondition = new BodyCondition(deadoralive,consciousstate,maxenergy,currentenergy,needs);

		bool rightarm = (bool)CharacterData[i]["rightarm"];
		bool leftarm = (bool)CharacterData[i]["leftarm"];
		bool rightleg = (bool)CharacterData[i]["rightleg"];
		bool leftleg = (bool)CharacterData[i]["leftleg"];
		bool smell = (bool)CharacterData[i]["smell"];
		bool hearing = (bool)CharacterData[i]["hearing"];
		bool sight = (bool)CharacterData[i]["sight"];
		BodyParts bodyparts = new BodyParts(sight,hearing,smell,leftleg,rightleg,leftarm,rightarm);

		int bodytype = (int)CharacterData[i]["bodytype"];
		int sex = (int)CharacterData[i]["sex"];
		int height = (int)CharacterData[i]["height"];
		int age = (int)CharacterData[i]["age"];
		int race = (int)CharacterData[i]["race"];
		BasicBodyStats bodystats = new BasicBodyStats(race,age,height,sex,bodytype);

		string firstname = (string)CharacterData[i]["firstname"].ToString();
		string lastname = (string)CharacterData[i]["lastname"].ToString();
		int nametype = (int)CharacterData[i]["nametype"];
		string commonnickname = (string)CharacterData[i]["commonnickname"].ToString();

		string slug = (string)CharacterData[i]["slug"].ToString();
		int id = (int)CharacterData[i]["id"];

		CharacterName charactername = new CharacterName (firstname,lastname,nametype,commonnickname);
		Body body = new Body (bodystats,bodyparts,bodycondition);
		Mind mind = new Mind (personality,cognition,emotion,memory,mentalhealth,skills);
		SocialCondition social = new SocialCondition (relationshiplist,reputationlist);
		PhysicalCondition physical = new PhysicalCondition (physicaltemporal,property,weekroutine);
		CharacterSprites sprites = new CharacterSprites (slug);

		Character CurrentCharacter = new Character(charactername,id,body,mind,social,physical,sprites);
		CharacterList.Add (CurrentCharacter);

	}*/