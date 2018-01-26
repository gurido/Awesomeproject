using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryDictionary : MonoBehaviour {



	public static readonly Dictionary<int, string> DiaryPhraseTypeDictionary = new Dictionary<int, string> {

		{1, "Player Name"},
		{2, "Player Age"},
		{3, "Player Gender"},
		{4, "Character Name"},
		{5, "Character Age"},
		{6, "Character Gender"},
		{7, ""}

	};


	public static readonly Dictionary<string, string> DiaryPhraseDictionary = new Dictionary<string, string> {

		{"1", "FallenDown"},
		{"2", "FallenDown"},
		{"3", "MeetFlowey"},
		{"4", "MeetToriel"},
		{"5", "FallenDown"},
		{"6", "FallenDown"},
		{"7", "FallenDown"}

	};

	public static readonly Dictionary<string, string> DiaryInstructionDictionary = new Dictionary<string, string> {

		{"1", "What is your name?"},
		{"2", "How old are you?"},
		{"3", ""},
		{"4", "MeetToriel"},
		{"5", "FallenDown"},
		{"6", "FallenDown"},
		{"7", "FallenDown"}

	};



}
