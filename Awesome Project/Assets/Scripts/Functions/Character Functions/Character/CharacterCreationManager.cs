using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreationManager : MonoBehaviour {
	//C_character = ConfigureCharacter
	private CharacterConfigurationManager configuration;
	private DatabaseManager database;

	public void CharacterCreationManagerStart(){
		configuration = GetComponent<CharacterConfigurationManager> ();
		database = GetComponent<DatabaseManager> ();
	}




	public void AddACharacter(){
		configuration.CurrentCharacterConfiguration = 1;
		configuration.CharacterConfiguration ();
		database.CharacterList.Add (configuration.C_Character);

	}

	public void DeleteLastCharacter(){

		if (database.CharacterList.Count <= 0) {
		} else {
			configuration.C_CharacterNumber = database.CharacterList.Count;
			database.CharacterList.RemoveAt (database.CharacterList.Count - 1);
		}
	}
		

	public void ModifyACharacter(){

	}

	public void ClearCharacterList(){
		database.CharacterList.Clear ();
	}
}
