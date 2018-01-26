using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiaryInputReader : MonoBehaviour {
	

	public Text DiaryInputFieldText;


	public string CurrentFullPhrase;
	public string PreviousText;
	public int CurrentPhraseEndPoint;
	public int PreviousPhraseEndPoint;
	public int CurrentPunctuationType;


	//punctuation


	public string p_period = ".";
	public string p_questionmark = "?";
	public string p_exclamationmark = "!";
	public string p_comma = ",";
	public string p_ellipsis = "...";
	public string p_semicolon = ";";


	public void DiaryReaderStart(){
		PreviousPhraseEndPoint = 0;
		CurrentPhraseEndPoint = 0;
	}

	public void DetectInputText (){

		if (DiaryInputFieldText.text.Length > 0){
			DetectPhrase();
			}
		else{//Debug.Log ("No diary input text");
		}
	}
		
	public void ResetInputReaderValues(){
		CurrentFullPhrase = "";
		PreviousText = "";
		CurrentPhraseEndPoint = 0;
		PreviousPhraseEndPoint = 0;

	}


	void DetectPhrase(){

		int FoundAPeriod = DiaryInputFieldText.text.Substring(PreviousPhraseEndPoint).IndexOf(p_period);
		int FoundAComma = DiaryInputFieldText.text.Substring(PreviousPhraseEndPoint).IndexOf(p_comma);
		int FoundAExclamation = DiaryInputFieldText.text.Substring(PreviousPhraseEndPoint).IndexOf(p_exclamationmark);
		int FoundAQuestion = DiaryInputFieldText.text.Substring(PreviousPhraseEndPoint).IndexOf(p_questionmark);


		if (FoundAPeriod >= 0 || FoundAComma >= 0|| FoundAExclamation >= 0|| FoundAQuestion >= 0) {

			if(FoundAPeriod >= 0){
				CurrentPunctuationType = 1;
			}
			if(FoundAComma >= 0){
				CurrentPunctuationType = 2;
			}
			if(FoundAExclamation >= 0){
				CurrentPunctuationType = 3;
			}
			if(FoundAQuestion >= 0){
				CurrentPunctuationType = 4;
			}
			FoundAPeriod = -1;
			FoundAComma = -1;
			FoundAExclamation = -1;
			FoundAQuestion = -1;
			ProcessPhrase ();
		} else {
			CurrentPhraseEndPoint = 0;}

		//Debug.Log ("Previous Text is <" +PreviousText + "> Current Phrase Is " + "<" + CurrentFullPhrase + "> / Current End P is " + CurrentPhraseEndPoint + " Prev End P is " + PreviousPhraseEndPoint);

	}


	void ProcessPhrase(){

		PreviousText = DiaryInputFieldText.text.Substring (0, PreviousPhraseEndPoint);
		switch (CurrentPunctuationType) {
		case 1:
			CurrentPhraseEndPoint = DiaryInputFieldText.text.Substring (PreviousPhraseEndPoint).IndexOf (p_period) + 1;
			break;

		case 2:
			CurrentPhraseEndPoint = DiaryInputFieldText.text.Substring (PreviousPhraseEndPoint).IndexOf (p_comma) + 1;
			break;

		case 3:
			CurrentPhraseEndPoint = DiaryInputFieldText.text.Substring (PreviousPhraseEndPoint).IndexOf (p_exclamationmark) + 1;
			break;

		case 4:
			CurrentPhraseEndPoint = DiaryInputFieldText.text.Substring (PreviousPhraseEndPoint).IndexOf (p_questionmark) + 1;
			break;

		default:
			break;

		}
		CurrentFullPhrase = DiaryInputFieldText.text.Substring (PreviousText.Length);

		GetComponent<DiaryInputManager>().CreatePhrase ();

		//Pass New phrase to old text
		PreviousText = PreviousText + CurrentFullPhrase;
		PreviousPhraseEndPoint = PreviousPhraseEndPoint + CurrentPhraseEndPoint;

		CurrentPhraseEndPoint = 0;

		//Debug.Log ("You created a phrase! Prev P is now " + PreviousPhraseEndPoint + " Current P is now " + CurrentPhraseEndPoint);

	}











}
