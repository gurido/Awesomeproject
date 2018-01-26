using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DiaryInputManager : MonoBehaviour {

	public List<Phrase> CurrentDiaryPhrases = new List<Phrase>();
	public Phrase CurrentPhrase = new Phrase();
	public InputField DiaryInputField;
	public Text DiaryAnalysisText;
	public Text DiaryInstrutionText;

	public string MyNameIs = "My name is";
	public int SpaceLenght = 1;
	public string WhatIsYourName = "What is your name?";

	private GameStatusManager gamestatusmanager;

	public void DiaryManagerStart(){
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
		GetComponent<DiaryInputReader> ().DiaryReaderStart ();

	}



	public void DiaryManagerUpdate(){
		DiaryPressAnyKey ();


	}



	public void DiaryPressAnyKey(){

		if (Input.anyKeyDown) {

			if (Input.GetKeyDown (KeyCode.Backspace)) {
				ClearInputField ();

			} else {
				GetComponent<DiaryInputReader>().DetectInputText ();
				}

			UpdateDiaryAnalysis ();
		} 
	}


	public void CreatePhrase(){

		CurrentPhrase.IsPhraseValid = true;
		CurrentPhrase.PhraseContent = GetComponent<DiaryInputReader>().CurrentFullPhrase;
		CurrentPhrase.PhraseLenght = GetComponent<DiaryInputReader>().CurrentFullPhrase.Length;
		CurrentPhrase.PhrasePunctuationType = GetComponent<DiaryInputReader>().CurrentPunctuationType;

		CurrentDiaryPhrases.Add (CurrentPhrase);

	}


	public void UpdateDiaryAnalysis(){

		string HowManyPhrasesDoIHave = "I have " + CurrentDiaryPhrases.Count + " phrases.";
		string HowManyValidPhrasesDoIHave = "I have " + "0 valid phrases.";
		DiaryAnalysisText.text =  HowManyPhrasesDoIHave + "\n" + HowManyValidPhrasesDoIHave;

	}


	public void ClearInputField(){
		DiaryInputField.Select ();
		DiaryInputField.text = "";
		CurrentDiaryPhrases.Clear();
		GetComponent<DiaryInputReader> ().ResetInputReaderValues ();
		//Debug.Log ("You cleared the diary");

	}

	public void ExitToMainMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();
	}

	public void ViewDiaryEntryMenu(){
		gamestatusmanager.ChangeStatusToDiaryMenu ();
	}

	public void SaveDiary(){

	}
}
	
