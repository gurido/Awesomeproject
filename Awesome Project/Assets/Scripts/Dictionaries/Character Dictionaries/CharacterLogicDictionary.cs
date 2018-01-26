using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLogicDictionary : MonoBehaviour {





	public static readonly Dictionary<int, string> RaceDictionary = new Dictionary<int, string> {

		{1, "Human"},
		{2, "Ghost"},
		{3, "Werewold"},
		{4, "Vampire"},
		{5, "Angel"},
		{6, "Demon"},
		{7, "Mermaids"},
		{8, "Pokemon"},
		{9, "Monster"},
		{10, "Orc"},
		{11, "Troll"},
		{12, "Succubus"},
		{13, "Fairy"}

	};


	public static readonly Dictionary<int, string> BodytypeDictionary = new Dictionary<int, string> {

		{1, "Normal"},
		{2, "Thin"},
		{3, "Buff"},
		{4, "Fat"}
	};

	public static readonly Dictionary<int, string> DiseaseDictionary = new Dictionary<int, string> {

		{1, ""},
		{2, ""},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""}

	};

	public static readonly Dictionary<int, string> SicknessDictionary = new Dictionary<int, string> {

		{1, "Cold"},
		{2, "Fever"},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""}

	};



	public static readonly Dictionary<int, string> SensoryDictionary = new Dictionary<int, string> {

		{1, "Sight"},
		{2, ""},
		{3, ""},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""}

	};




	public static readonly Dictionary<int, string> LanguageDictionary = new Dictionary<int, string> {

		{1, "English"},
		{2, "Spanish"},
		{3, "Chinese"},
		{4, "Japanese"},
		{5, "French"},
		{6, "Italian"},
		{7, "German"}

	};

	public static readonly Dictionary<int, string> EmotionDictionary = new Dictionary<int, string> {

		{1, "Serenity"},
		{2, "Joy"},
		{3, "Ecstasy"},
		{4, "Interest"},
		{5, "Anticipation"},
		{6, "Vigilance"},
		{7, "Annoyance"},
		{8, "Anger"},
		{9, "Rage"},
		{10, "Boredom"},
		{11, "Disgust"},
		{12, "Loathing"},
		{13, "Pensiveness"},
		{14, "Sadness"},
		{15, "Grief"},
		{16, "Distraction"},
		{17, "Surprise"},
		{18, "Amazement"},
		{19, "Apprehension"},
		{20, "Fear"},
		{21, "Terror"},
		{22, "Acceptance"},
		{23, "Trust"},
		{24, "Admiration"},	

		{25, "Love"},
		{26, "Optimism"},
		{27, "Aggresiveness"},
		{28, "Contempt"},
		{29, "Remorse"},
		{30, "Diapproval"},
		{31, "Awe"},
		{32, "Submission"}


	};



	public static readonly Dictionary<int, string> SkillDictionary = new Dictionary<int, string> {

		{1, "Driving Car"},
		{2, "Swimming"},
		{3, "Biking"},
		{4, ""},
		{5, ""},
		{6, ""},
		{7, ""}

	};

	public static readonly Dictionary<int, string> BiologicalSexDictionary = new Dictionary<int, string> {

		{1, "Female"},
		{2, "Male"},
		{3, "Other"}

	};

	public static readonly Dictionary<int, string> SexualityDictionary = new Dictionary<int, string> {

		{1, "Heterosexual"},
		{2, "Homosexual"},
		{3, "Asexual"},
		{4, "Bisexual"},
		{5, "Pansexual"},
		{6, "Demisexual"},
		{7, "Biromantic"},
		{8, "Demiromantic"},
		{9, "Autosexual"},
		{10, "Aromantic"},
		{11, "Gyneromantic"},
		{12, "Gynecophilia"},
		{13, "Omnisexual"},
		{14, "Skoliksexual"}


	};

	public static readonly Dictionary<int, string> GenderDictionary = new Dictionary<int, string> {

		{1, "Female"},
		{2, "Male"},
		{3, "Nonbinary"},
		{4, "Other"}
	};

	public static readonly Dictionary<int, string> FundamentalPersonalityCharacteristicsDictionary = new Dictionary<int, string> {

		{1, "Conscientiousness"}, //disorganized, careless, impulsive vs organized, careful, disciplicned
		{2, "Agreeableness"},//ruthless, suspicious, uncooperative vs soft-hearted, trusting, helpful
		{3, "Neuroticism"},//calm, secure, self-satisfied vs anxious, insecure, self-pitying
		{4, "Openness"}, //practical, prefers routine, conforming vs imaginative, prefers variety, independent
		{5, "Extraversion"} //retiring, sober, reserved vs sociable, fun-loving, affectionate

	};



	public static readonly Dictionary<int, string> StateOfConsciousnessDictionary = new Dictionary<int, string> {

		{1, "Awake"},
		{2, "Asleep"},
		{3, "Unconscious"},
		{4, ""}
	};

}


/*
	 body - race, disease, sensory, movement, 
	mind - consciousness, mental health, personality, intelligence, skills, 
	knowledge, concepts, morality, language, emotion, thought, motivation
	social - relationship


	problem solving: trial and error, algorithm, heuristic,  
	problematic: confirmation bias, belief preserverance, mental set, availability heuristic, framing
	
	 */
