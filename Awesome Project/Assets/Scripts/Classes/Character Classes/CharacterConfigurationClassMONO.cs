using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public class CharacterConfigurationClass{
	//Character Name
	public string FirstName;
	public string LastName;
	int NameType;
	string NickName;
	//Basic Body Stats
	int Race;
	int Age;
	int Height;
	int Sex;
	int Bodytype;
	//Body Parts
	bool Sight;
	bool Hearing;
	bool Smelling;
	bool LeftLeg;
	bool RightLeg;
	bool LeftArm;
	bool RightArm;
	//Body Condition
	bool DearthOrAlive;
	int ConsciousState;
	int Energy;
	//Biological needs
	int FoodNeeds;
	int WaterNeeds;
	int SleepNeeds;
	int WarmthNeeds;
	int ShelterNeeds;
	int AirNeeds;
	//MIND
	//Cognition: Concept/Prototype/Knowledge/Morality
	//Personality
	//Personality fundamental characteristics
	int Conscientious;
	int Agreeableness;
	int Neuroticism;
	int Openness;
	int Extraversion;
	//Emotion
	//Memory 
	Thought[] DayThoughts;
	Need[] DayNeeds;
	Motivation[] DayMotivation;
	Thought[] WeekThoughts;
	Need[] WeekNeeds;
	Motivation[] WeekMotivation;
	Thought[] MonthThoughts;
	Need[] MonthNeeds;
	Motivation[] MonthMotivation;
	Thought[] YearThoughts;
	Need[] YearNeeds;
	Motivation[] YearMotivation;
	Thought[] LifeThoughts;
	Need[] LifeNeeds;
	Motivation[] LifeMotivation;

	//Mental Health
	//Skills
	//Social Condition
	//Relationships
	//Reputation



	//Physical World Condition






}




public class CharacterConfigurationClassMONO : MonoBehaviour {


}
