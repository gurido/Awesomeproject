using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterConfigurationManager : MonoBehaviour {
	public int CurrentCharacterConfiguration; //1 = default

	public Character C_Character;//C_Character = ConfigureCharacter
	public int C_CharacterNumber;

	CharacterName C_CharacterName;
	string C_FirstName;
	string C_LastName;
	int C_Nametype;
	string C_Nickname;

	Body C_Body;
	BasicBodyStats C_BasicBodyStats;
	int C_Race;
	int C_Age;
	int C_Height;
	int C_Sex;
	int C_Bodytype;
	BodyParts C_Bodyparts;
	bool C_Sight;
	bool C_Hearing;
	bool C_Smelling;
	bool C_LeftLeg;
	bool C_RightLeg;
	bool C_LeftArm;
	bool C_RightArm;
	BodyCondition C_BodyCondition;
	bool C_DeathOrAlive;
	int C_ConsciousState;
	int C_MaxEnergy;
	int C_CurrentEnergy;
	BodyNeeds C_BodyNeeds;
	int C_FoodNeeds;
	int C_WaterNeeds;
	int C_SleepNeeds;
	int C_WarmthNeeds;
	int C_ShelterNeeds;
	int C_AirNeeds;

	Mind C_Mind;
	Personality C_Personality;
	FundamentalPersonalityCharacteristics C_FivePersonality;
	int C_Conscientious;
	int C_Agreeableness;
	int C_Neuroticism;
	int C_Openness;
	int C_Extraversion;

	Cognition C_Cognition;
	Concept C_Concept;
	Prototype C_Prototype;
	Knowledge C_Knowledge;
	Morality C_Morality;

	CurrentEmotion C_CurrentEmotion;
	int C_CurrentRage;
	int C_CurrentLoathing;
	int C_CurrentGrief;
	int C_CurrentAmazement;
	int C_CurrentTerror;
	int C_CurrentAdmiration;
	int C_CurrentEcstasy;
	int C_CurrentVigilance;

	Memory C_Memory;
	PastDayEvent C_PastDayEvent;
	List<Thought> C_DayThoughts;
	List<Need> C_DayNeeds;
	List<Motivation> C_DayMotivation;
	List<Event> C_DayEvent;
	PastWeekEvent C_PastWeekEvent;
	List<Thought> C_WeekThoughts;
	List<Need> C_WeekNeeds;
	List<Motivation> C_WeekMotivation;
	List<Event> C_WeekEvent;

	PastMonthEvent C_PastMonthEvent;
	List<Thought> C_MonthThoughts;
	List<Need> C_MonthNeeds;
	List<Motivation> C_MonthMotivation;
	List<Event> C_MonthEvent;

	PastYearEvent C_PastYearEvent;
	List<Thought> C_YearThoughts;
	List<Need> C_YearNeeds;
	List<Motivation> C_YearMotivation;
	List<Event> C_YearEvent;

	PastLifetimeEvent C_PastLifeEvent;
	List<Thought> C_LifeThoughts;
	List<Need> C_LifeNeeds;
	List<Motivation> C_LifeMotivation;
	List<Event> C_LifeEvent;

	int C_TimePositionYear;
	int C_TimePositionMonth;
	int C_TimePositionDay;
	int C_TimePositionHour;
	int C_TimePositionMinute;
	Thought C_Thought;
	TimePosition C_ThoughtTime;
	int C_ThoughtType;
	Motivation C_Motivation;
	TimePosition C_MotivationTime;
	int C_MotivationType;
	Need C_Need;
	TimePosition C_NeedTime;
	int C_NeedType;
	Event C_Event;
	TimePosition C_EventTime;
	int C_EventType;

	List<MentalDisorder> C_MentalHealth = new List<MentalDisorder> ();
	MentalDisorder C_MentalDisorder;
	int C_MentalDisorderType;
	int C_MentalDisorderIntensity;
	int C_MentalDisorderTarget;
	Skills C_Skills;


	SocialCondition C_SocialCondition;
	List<Relationship> C_RelationshipList;
	Relationship C_Relationship;
	int C_RelationshipCharacter;
	int C_RelationshipRelatedType;
	int C_RelationshipPersonal;
	InterpersonalFeeling C_RelationshipFeeling;
	int C_RelationshipRage;
	int C_RelationshipLoathing;
	int C_RelationshipGrief;
	int C_RelationshipAmazement;
	int C_RelationshipTerror;
	int C_RelationshipAdmiration;
	int C_RelationshipEcstasy;
	int C_RelationshipVigilance;
	int C_GeneralFeeling;

	MemoryWithThem C_RelationshipMemory;
	List<Event> C_RelationshipEventList;


	List<Reputation> C_ReputationList;
	Reputation C_Reputation;
	int C_ReputationGroupNumber;
	int C_ReputationGroupRole;
	int C_ReputationGroupVisibility;


	PhysicalCondition C_PhysicalCondition;
	PhysicalTemporal C_PhysicalTemporal;
	int C_CurrentPosition;
	int C_CurrentTime;

	Property C_Property;
	int C_Wealth;


	CharacterInventory C_CharacterInventory;


	List<RegularIncome> C_Incomes;
	RegularIncome C_Income;
	int C_IncomeType;
	int C_IncomeMoney;
	int C_IncomeFrequency;
	int C_IncomeTimeLeft;
	List<RegularExpense> C_Expenses;
	RegularExpense C_Expense;
	int C_ExpenseType;
	int C_ExpenseMoney;
	int C_ExpenseFrequency;
	int C_ExpenseTimeLeft;

	WeekRoutine C_WeekRoutine;
	List<DayRoutine> C_MondayRoutine;
	List<DayRoutine> C_TuesdayRoutine;
	List<DayRoutine> C_WednesdayRoutine;
	List<DayRoutine> C_ThursdayRoutine;
	List<DayRoutine> C_FridayRoutine;
	List<DayRoutine> C_SaturdayRoutine;
	List<DayRoutine> C_SundayRoutine;
	DayRoutine C_DayRoutine;
	int C_DayRoutineTime;
	int C_DayRoutinePlace;
	int C_DayRoutineTimesPerformed;
	int C_DayRoutineHowUsedTo;
	int C_DayRoutineTimeDuration;
	int C_DayRoutineState;
	CharacterAction C_DayRoutineAction;
	int C_ActionType;
	int C_ActionTarget;

	CharacterSprites C_CharacterSprites;
	string C_Slug;

	public void CharacterConfiguration(){
		switch(CurrentCharacterConfiguration){
		case 1: //Default
			DefaultConfiguration ();
			DefaultMemoryConfiguration ();
			DefaultSocialConditionConfiguration ();
			DefaultPhysicalConditionConfiguration ();
			DefaultCharacterInventoryConfiguration ();
			break;
		default:
			break;
		}
		AssembleCharacter ();
	}


	private void DefaultConfiguration(){
		C_CharacterNumber = GetComponent<DatabaseManager>().CharacterList.Count + 1;

		C_FirstName = "Character " + C_CharacterNumber;
		C_LastName = "";
		C_Nametype = 1;
		C_Nickname = "";
//Sprites
		C_Slug = "Default";
//Body Stats
		C_Race = 1;
		C_Age = 20;
		C_Height = 170;
		C_Sex = 1;
		C_Bodytype = 1;
//Body Parts
		C_Sight = true;
		C_Hearing = true;
		C_Smelling = true;
		C_LeftLeg = true;
		C_RightLeg = true;
		C_LeftArm = true;
		C_RightArm = true;

//BodyConditions
		C_DeathOrAlive = true;
		C_ConsciousState = 1;
		C_MaxEnergy = 100;
		C_CurrentEnergy = 100;

//Body Needs
		C_FoodNeeds = 100;
		C_WaterNeeds = 100;
		C_SleepNeeds = 100;
		C_WarmthNeeds = 100;
		C_ShelterNeeds = 100;
		C_AirNeeds = 100;
//Five Personality
		C_Conscientious = 50;
		C_Agreeableness = 50;
		C_Neuroticism = 50;
		C_Openness = 50;
		C_Extraversion = 50;
//current emotion
		C_CurrentRage = 0;
		C_CurrentLoathing = 0;
		C_CurrentGrief = 0;
		C_CurrentAmazement = 0;
		C_CurrentTerror = 0;
		C_CurrentAdmiration = 0;
		C_CurrentEcstasy = 0;
		C_CurrentVigilance = 0;
//Mental Disorder
		C_MentalDisorderType = 1;
		C_MentalDisorderIntensity = 1;
		C_MentalDisorderTarget = 1;
		C_MentalDisorder = new MentalDisorder (C_MentalDisorderType,C_MentalDisorderIntensity,C_MentalDisorderTarget);
		C_MentalHealth = new List<MentalDisorder> ();
		C_MentalHealth.Add (C_MentalDisorder);

	}




	private void DefaultMemoryConfiguration(){

		C_TimePositionYear = 1;
		C_TimePositionMonth = 1;
		C_TimePositionDay = 1;
		C_TimePositionHour = 1;
		C_TimePositionMinute = 1;

		C_ThoughtTime = new TimePosition(C_TimePositionYear,C_TimePositionMonth,C_TimePositionDay,C_TimePositionHour,C_TimePositionMinute);
		C_ThoughtType = 1;
		C_NeedTime = new TimePosition(C_TimePositionYear,C_TimePositionMonth,C_TimePositionDay,C_TimePositionHour,C_TimePositionMinute);
		C_NeedType = 1;
		C_MotivationTime = new TimePosition(C_TimePositionYear,C_TimePositionMonth,C_TimePositionDay,C_TimePositionHour,C_TimePositionMinute);
		C_MotivationType = 1;
		C_EventTime = new TimePosition(C_TimePositionYear,C_TimePositionMonth,C_TimePositionDay,C_TimePositionHour,C_TimePositionMinute);
		C_EventType = 1;

		C_Need = new Need (C_NeedTime,C_NeedType);
		C_Motivation = new Motivation (C_MotivationTime,C_MotivationType);
		C_Thought = new Thought (C_ThoughtTime,C_ThoughtType);
		C_Event = new Event (C_EventTime, C_EventType);

		C_DayThoughts = new List<Thought>();
		C_DayNeeds = new List<Need> ();
		C_DayMotivation = new List<Motivation> ();
		C_DayEvent = new List<Event> ();

		C_WeekThoughts = new List<Thought>();
		C_WeekNeeds = new List<Need> ();
		C_WeekMotivation = new List<Motivation> ();
		C_WeekEvent = new List<Event> ();

		C_MonthThoughts = new List<Thought>();
		C_MonthNeeds = new List<Need> ();
		C_MonthMotivation = new List<Motivation> ();
		C_MonthEvent = new List<Event> ();

		C_YearThoughts = new List<Thought>();
		C_YearNeeds = new List<Need> ();
		C_YearMotivation = new List<Motivation> ();
		C_YearEvent = new List<Event> ();

		C_LifeThoughts = new List<Thought>();
		C_LifeNeeds = new List<Need> ();
		C_LifeMotivation = new List<Motivation> ();
		C_LifeEvent = new List<Event> ();


		C_DayThoughts.Add (C_Thought);
		C_DayMotivation.Add (C_Motivation);
		C_DayNeeds.Add (C_Need);
		C_DayEvent.Add (C_Event);

	}



	private void DefaultSocialConditionConfiguration(){


		C_RelationshipRage = 0;
		C_RelationshipLoathing = 0;
		C_RelationshipGrief = 0;
		C_RelationshipAmazement = 0;
		C_RelationshipTerror = 0;
		C_RelationshipAdmiration = 0;
		C_RelationshipEcstasy = 0;
		C_RelationshipVigilance = 0;
		C_GeneralFeeling = 0;

		C_RelationshipFeeling = new InterpersonalFeeling (C_RelationshipRage, C_RelationshipLoathing,C_RelationshipGrief,C_RelationshipAmazement,C_RelationshipTerror,C_RelationshipAdmiration,C_RelationshipEcstasy,C_RelationshipVigilance,C_GeneralFeeling);

		C_TimePositionYear = 1;
		C_TimePositionMonth = 1;
		C_TimePositionDay = 1;
		C_TimePositionHour = 1;
		C_TimePositionMinute = 1;
		C_EventTime = new TimePosition(C_TimePositionYear,C_TimePositionMonth,C_TimePositionDay,C_TimePositionHour,C_TimePositionMinute);
		C_EventType = 1;
		C_Event = new Event (C_EventTime, C_EventType);
		C_RelationshipEventList = new List<Event> ();
		C_RelationshipEventList.Add (C_Event);
		C_RelationshipMemory = new MemoryWithThem (C_RelationshipEventList);

		C_RelationshipCharacter = 1;
		C_RelationshipRelatedType = 1;
		C_RelationshipPersonal = 1;
		C_Relationship = new Relationship (C_RelationshipCharacter,C_RelationshipRelatedType,C_RelationshipPersonal,C_RelationshipFeeling,C_RelationshipMemory);
		C_RelationshipList = new List<Relationship> ();
		C_RelationshipList.Add (C_Relationship);

		C_ReputationGroupNumber = 1;
		C_ReputationGroupRole = 1;
		C_ReputationGroupVisibility = 1;
		C_Reputation = new Reputation (C_ReputationGroupNumber,C_ReputationGroupRole,C_ReputationGroupVisibility);
		C_ReputationList = new List<Reputation> ();
		C_ReputationList.Add (C_Reputation);


	}

	private void DefaultPhysicalConditionConfiguration(){
		C_CurrentPosition = 0;
		C_CurrentTime = 0;
		C_Wealth = 0;

		C_IncomeType = 1;
		C_IncomeMoney = 1;
		C_IncomeFrequency = 1;
		C_IncomeTimeLeft = 1;
		C_ExpenseType = 1;
		C_ExpenseMoney = 1;
		C_ExpenseFrequency = 1;
		C_ExpenseTimeLeft = 1;
		C_Income = new RegularIncome (C_IncomeType,C_IncomeMoney,C_IncomeFrequency,C_IncomeTimeLeft);
		C_Expense = new RegularExpense (C_ExpenseType,C_ExpenseMoney,C_ExpenseFrequency, C_ExpenseTimeLeft);
		C_Incomes = new List<RegularIncome> ();
		C_Expenses = new List<RegularExpense> ();
		C_Incomes.Add(C_Income);
		C_Expenses.Add(C_Expense);

		C_DayRoutineTime = 1;
		C_DayRoutinePlace = 1;
		C_DayRoutineTimesPerformed = 0;
		C_DayRoutineHowUsedTo = 0;
		C_DayRoutineTimeDuration = 1;
		C_DayRoutineState = 1;
		C_ActionType = 1;
		C_ActionTarget = 1;
		C_DayRoutineAction = new CharacterAction(C_ActionType,C_ActionTarget);
		C_DayRoutine = new DayRoutine (C_DayRoutineTime,C_DayRoutinePlace,C_DayRoutineTimesPerformed,C_DayRoutineHowUsedTo,C_DayRoutineTimeDuration,C_DayRoutineState,C_DayRoutineAction);
		C_MondayRoutine = new List<DayRoutine> ();
		C_TuesdayRoutine = new List<DayRoutine> ();
		C_WednesdayRoutine = new List<DayRoutine> ();
		C_ThursdayRoutine = new List<DayRoutine> ();
		C_FridayRoutine = new List<DayRoutine> ();
		C_SaturdayRoutine = new List<DayRoutine> ();
		C_SundayRoutine = new List<DayRoutine> ();
		C_MondayRoutine.Add (C_DayRoutine);
	}



	private void DefaultCharacterInventoryConfiguration(){
		C_CharacterInventory = new CharacterInventory ();
		/*
		C_ItemType = 1;
		C_ItemQuantity = 1;
		C_InventoryItem = new InventoryItem (C_ItemType, C_ItemQuantity);
		C_ItemInventory = new List<InventoryItem> ();
		C_ItemInventory.Add (C_InventoryItem);*/

	}

	private void AssembleCharacter(){
		C_CharacterSprites = new CharacterSprites (C_Slug);

		C_WeekRoutine = new WeekRoutine (C_MondayRoutine,C_TuesdayRoutine,C_WednesdayRoutine,C_ThursdayRoutine,C_FridayRoutine,C_SaturdayRoutine,C_SundayRoutine);

		C_Property = new Property(C_Wealth,C_Incomes, C_Expenses, C_CharacterInventory);
		C_PhysicalTemporal = new PhysicalTemporal (C_CurrentPosition,C_CurrentTime);
		C_PhysicalCondition = new PhysicalCondition (C_PhysicalTemporal,C_Property,C_WeekRoutine);

		C_SocialCondition = new SocialCondition(C_RelationshipList, C_ReputationList);

		C_Skills = new Skills ();

		C_PastLifeEvent = new PastLifetimeEvent (C_LifeThoughts,C_LifeNeeds,C_LifeMotivation, C_LifeEvent);
		C_PastYearEvent = new PastYearEvent (C_YearThoughts,C_YearNeeds,C_YearMotivation, C_YearEvent);
		C_PastMonthEvent = new PastMonthEvent (C_MonthThoughts,C_MonthNeeds,C_MonthMotivation, C_MonthEvent);
		C_PastWeekEvent = new PastWeekEvent (C_WeekThoughts,C_WeekNeeds,C_WeekMotivation, C_WeekEvent);
		C_PastDayEvent = new PastDayEvent (C_DayThoughts,C_DayNeeds,C_DayMotivation,C_DayEvent);
		C_Memory = new Memory (C_PastDayEvent,C_PastWeekEvent,C_PastMonthEvent,C_PastYearEvent,C_PastLifeEvent);

		C_CurrentEmotion = new CurrentEmotion (C_CurrentRage,C_CurrentLoathing,C_CurrentGrief,C_CurrentAmazement,C_CurrentTerror,C_CurrentAdmiration,C_CurrentEcstasy,C_CurrentVigilance);

		C_Concept = new Concept ();
		C_Prototype = new Prototype ();
		C_Knowledge = new Knowledge ();
		C_Morality = new Morality ();
		C_Cognition = new Cognition (C_Concept,C_Prototype,C_Knowledge,C_Morality);

		C_FivePersonality = new FundamentalPersonalityCharacteristics (C_Conscientious,C_Agreeableness,C_Neuroticism,C_Openness,C_Extraversion);
		C_Personality = new Personality(C_FivePersonality);
		C_Mind = new Mind(C_Personality,C_Cognition,C_CurrentEmotion,C_Memory,C_MentalHealth,C_Skills);

		C_BodyNeeds = new BodyNeeds (C_FoodNeeds,C_WaterNeeds,C_SleepNeeds,C_WarmthNeeds,C_ShelterNeeds,C_AirNeeds);
		C_BodyCondition = new BodyCondition (C_DeathOrAlive,C_ConsciousState,C_MaxEnergy,C_CurrentEnergy,C_BodyNeeds);
		C_Bodyparts = new BodyParts (C_Sight,C_Hearing,C_Smelling,C_LeftLeg,C_RightLeg,C_LeftArm,C_RightArm);
		C_BasicBodyStats = new BasicBodyStats (C_Race,C_Age,C_Height,C_Sex,C_Bodytype);
		C_Body = new Body(C_BasicBodyStats,C_Bodyparts,C_BodyCondition);

		C_CharacterName = new CharacterName(C_FirstName,C_LastName,C_Nametype,C_Nickname);
		C_Character = new Character (C_CharacterName, C_CharacterNumber,  C_Body, C_Mind, C_SocialCondition, C_PhysicalCondition, C_CharacterSprites);
	}

}
