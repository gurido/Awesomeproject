using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMenuDescriptionManager : MonoBehaviour {

	//NPC Text
	private string NPCDescription;
	private string NPCDescriptionCurrentCharactersCountString;


	public int CurrentInspectingCharacter;
	private string InspectCharacterText;
	private string InspectCharacterTextDetail;


}




/*
	void InspectCharacterDetails(){
		InspectCharacterTextDetail = "This character is called " + GetComponent<CharacterManager> ().CharacterList [CurrentInspectingCharacter - 1].CharacterName;

	}

	public void InspectCharacterDetailsManager(){


		switch(CurrentInspectingCharacter){

		case 0:
			break;

		case 1:
			if (GetComponent<CharacterManager> ().CharacterList.Count < 1) {
				InspectCharacterTextDetail = "This character does not exist";
			}
			else{
				InspectCharacterDetails ();
			}

			break;

		case 2:
			if (GetComponent<CharacterManager> ().CharacterList.Count < 2) {
				InspectCharacterTextDetail = "This character does not exist";
			}
			else{
				InspectCharacterDetails ();

			}
			break;
		case 3:
			if (GetComponent<CharacterManager> ().CharacterList.Count < 3) {
				InspectCharacterTextDetail = "This character does not exist";
			}
			else{
				InspectCharacterDetails ();

			}
			break;

		case 4:
			if (GetComponent<CharacterManager> ().CharacterList.Count < 4) {
				InspectCharacterTextDetail = "This character does not exist";
			}
			else{
				InspectCharacterDetails ();

			}
			break;

		case 5:
			if (GetComponent<CharacterManager> ().CharacterList.Count < 5) {
				InspectCharacterTextDetail = "This character does not exist";
			}
			else{
				InspectCharacterDetails ();

			}
			break;


		default:
			break;
		}
		if (CurrentInspectingCharacter == 0) {
			InspectCharacterText = "";
		} else {
			InspectCharacterText = "Inspecting Character " + CurrentInspectingCharacter + "\n" + InspectCharacterTextDetail;

		}

	}

	public void NPCDescriptionTextUpdate(){


		NPCDescriptionCurrentCharactersCountString = "I now have " + GetComponent<CharacterManager>().CharacterList.Count + " character";

		GetComponent<NPCMenuManager>().NPCDescriptionText.text = NPCDescriptionCurrentCharactersCountString +  "\n" + InspectCharacterText;

	}*/