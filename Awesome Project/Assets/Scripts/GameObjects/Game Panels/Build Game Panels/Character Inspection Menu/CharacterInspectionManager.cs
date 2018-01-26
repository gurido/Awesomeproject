using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInspectionManager : MonoBehaviour {
	public int CurrentInspectinCharacter;
	public Text CurrentInspectingCharacterText;
	string BasicDataString;
	string BasicBodyConditions;
	string BasicMindConditions;
	string BasicSocialConditions;
	string BasicPhysicalConditions;
	string spc;

	string Name;
	string Age;
	string Birthday;
	string Gender;
	string Race;
	string Bodytype;
	string Height;

	string Sight;
	string Hearing;
	string Smelling;
	string LeftLeg;
	string RightLeg;
	string LeftArm;
	string RightArm;

	string DeathorAlive;
	string StateOfConsciousness;
	string Energy;
	string Hunger;
	string Water;
	string Sleep;
	string Warmth;
	string Shelter;
	string Air;


	string Personality;
	string Conscientious;
	string Agreeableness;
	string Neuroticism;
	string Openness;
	string Extraversion;

	string PsychologicalNeeds;
	string Safety;
	string LoveBelonging;
	string Esteem;
	string SelfActualization;

	string Psychoanalysis;
	string ID;
	string EGO;
	string SUPEREGO;

	string Cognition;
	string Concept;
	string Prototype;
	string Knowledge;
	string Morality;

	string MentalHealth;

	string Skills;
	string Language;

	string Memories;

	string Emotions;
	string Rage;
	string Loathing;
	string Grief;
	string Amazement;
	string Terror;
	string Admiration;
	string Ecstasy;
	string Vigilance;

	string Relationships;

	string CurrentPosition;
	string CurrentTime;
	string Wealth;
	string ItemInventory;
	string RegularIncome;
	string RegularExpense;
	string WeekRoutine;

	private DatabaseManager database;
	private GameStatusManager gamestatusmanager;

	public void CharacterInspectoinMenuStart(){
		database = GameObject.Find("_GameManager").GetComponent<DatabaseManager> ();
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
		CurrentInspectinCharacter = 0;
		UpdateCharacterInspectionText ();
	}

	public void CharacterInspectionMenuUpdate(){
	}

	public void ExitCharacterInspectionMenu(){
		gamestatusmanager.ChangeStatusToNPCMenu ();
		//GetComponent<GameStatusManager> ().ChangeStatusToNPCMenu ();
	}

	private void UpdateCharacterInspectionText(){
		if(database.CharacterList.Count == 0){
			CurrentInspectingCharacterText.text = "Character does not exist";
		}
		else{
			spc = "   ";
			BasicDataText ();
			BodyDataText ();
			MindBodyText();
			SocialDataText();
			PhysicalDataText ();
			AllTextAssemble ();



		}
	}


	private void BasicDataText(){
		Name =database.CharacterList [CurrentInspectinCharacter].CharacterName.FirstName;
		Age = database.CharacterList [CurrentInspectinCharacter].CharacterBody.BasicBodyStats.Age +" years old";
		Birthday = "Birthday: ";
		Gender = "Gender: " + CharacterLogicDictionary.GenderDictionary[ database.CharacterList[CurrentInspectinCharacter].CharacterBody.BasicBodyStats.Sex];
		Race = "Race: " + CharacterLogicDictionary.RaceDictionary[database.CharacterList [CurrentInspectinCharacter].CharacterBody.BasicBodyStats.RaceType];
		Bodytype = "Bodytype: " + CharacterLogicDictionary.BodytypeDictionary[database.CharacterList [CurrentInspectinCharacter].CharacterBody.BasicBodyStats.Bodytype];
		Height = "Height: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BasicBodyStats.Height + "CM";


	}

	private void BodyDataText(){

		DeathorAlive = "Death/Alive: " +  database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.DeathOrAlive;
		StateOfConsciousness = "Consciousness: " + CharacterLogicDictionary.StateOfConsciousnessDictionary[ database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.ConsciousState];
		Energy = "Energy: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.MaxEnergy + "/" + "0";
		Hunger = "Hunger: " +database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Food;
		Water = "Water: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Water;
		Sleep = "Sleep: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Sleep;
		Shelter = "Shelter: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Shelter;
		Warmth = "Warmth " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Warmth ;
		Air = "Air: " + database.CharacterList [CurrentInspectinCharacter].CharacterBody.BodyCondition.Needs.Air;

	}

	private void MindBodyText(){
		Conscientious = "Conscientious: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Personality.PersonalityCharacteristics.Conscientiousness;
		Agreeableness = "Agreeableness: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Personality.PersonalityCharacteristics.Agreeableness;
		Neuroticism = "Neuroticism: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Personality.PersonalityCharacteristics.Neuroticism;
		Openness = "Openness: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Personality.PersonalityCharacteristics.Openness;
		Extraversion = "Extraversion " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Personality.PersonalityCharacteristics.Extraversion;


		Safety = "Safety: ";
		LoveBelonging = "Love/Belonging ";
		Esteem = "Esteem: ";
		SelfActualization = "SelfActualization ";

		ID = "ID: ";
		EGO = "EGO: ";
		SUPEREGO = "SUPEREGO: ";

		Concept = "Concept: " ;
		Prototype = "Prototype: ";
		Knowledge = "Knowledge: ";
		Morality = "Morality ";

		MentalHealth = "Mental Health: ";

		Language = "Language: ";

		Rage = "Rage: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Rage;
		Loathing = "Loathing: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Loathing;
		Grief = "Grief: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Grief;
		Amazement = "Amazement: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Amazement;
		Terror = "Terror: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Terror;
		Admiration = "Admiration: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Admiration;
		Ecstasy = "Ecstasy: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Ecstasy;
		Vigilance = "Vigilance: " + database.CharacterList [CurrentInspectinCharacter].CharacterMind.Emotion.Vigilance;

	}

	private void SocialDataText(){


	}

	private void PhysicalDataText(){
		CurrentPosition = "Location: ";
		Wealth = "   Money: " + + database.CharacterList [CurrentInspectinCharacter].PhysicalCondition.Property.Wealth;



	}



	private void AllTextAssemble(){

		Personality = "Personality: " + spc + Conscientious + spc + Agreeableness + spc + Neuroticism + spc + Openness + spc + Extraversion;
		PsychologicalNeeds = "Needs: " + spc + Safety + spc + LoveBelonging + spc + Esteem + spc + SelfActualization;
		Psychoanalysis = "Psychoanalysis: " + spc + ID + spc + EGO + spc + SUPEREGO;
		Cognition = "Cognition: " + spc + Concept + spc + Prototype + spc + Knowledge + spc + Morality;
		Skills = "Skills: " + spc + Language;
		Emotions = "Emotions:" + spc + Rage + spc + Loathing + spc + Grief + spc + Amazement + spc + Terror + spc + Admiration + spc + Ecstasy + spc + Vigilance;

		Relationships = "Relationships: ";

		BasicDataString = Name + "\n" + Age + spc + Birthday + spc + Gender + spc + Race + spc + Bodytype + spc +Height;
		BasicBodyConditions = DeathorAlive + spc + StateOfConsciousness + spc + Energy + "\n" + Hunger + spc + Water + spc + Sleep + spc + Shelter + spc + Warmth + spc + Air;
		BasicMindConditions = Personality  + "\n" + PsychologicalNeeds + "\n" + Psychoanalysis + "\n" + Cognition+ "\n" + MentalHealth + "\n" +Skills + "\n" + Emotions;
		BasicSocialConditions = Relationships;
		BasicPhysicalConditions = CurrentPosition + spc + Wealth;
		CurrentInspectingCharacterText.text = BasicDataString + "\n" + BasicBodyConditions + "\n" + BasicMindConditions + "\n" + BasicSocialConditions + "\n" + BasicPhysicalConditions;

	}




}
