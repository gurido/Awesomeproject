using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MainDatabaseSlot{
	public int RealID;
	public int EditorID;
	public int Timesused;

}

[SerializeField]
[System.Serializable]
public class MainDatabaseMap : MainDatabaseSlot{
	public List<GameMap> Map;
	//public GameMap Map;

	public MainDatabaseMap(int realid, int editorid, int timesused, List<GameMap> map){
		RealID = realid;
		EditorID = editorid;
		Timesused = timesused;
		Map = map;
	}

}

[SerializeField]
[System.Serializable]
public class MainDatabaseCharacter : MainDatabaseSlot{
	public List<Character> CharacterData;
	//public Character Character;

	public MainDatabaseCharacter(int realid, int editorid, int timesused, List<Character> character){
		RealID = realid;
		EditorID = editorid;
		Timesused = timesused;
		CharacterData = character;
	}
}


[SerializeField]
[System.Serializable]
public class MainDatabase{
	public List<MainDatabaseMap> MapSlotList;
	//public List<MainDatabaseCharacter> CharacterSlotList;

	public MainDatabase (List<MainDatabaseMap> mapslotlist){
		MapSlotList = mapslotlist;
		//CharacterSlotList = characterslotlist;
	}

}


public abstract class EditDatabaseSlot{
	public int RealID;
	public int EditorID;
}


[SerializeField]
[System.Serializable]
public class EditDatabaseMap : EditDatabaseSlot{
	public List<GameMap> Map;
	//public GameMap Map;

	public EditDatabaseMap(int realid, int editorid, List<GameMap> map){
		RealID = realid;
		EditorID = editorid;
		Map = map;

	}
}
[SerializeField]
[System.Serializable]
public class EditDatabaseCharacter : EditDatabaseSlot{
	public List<Character> Character;
	//public Character Character;

	public EditDatabaseCharacter(int realid, int editorid, List<Character> character){
		RealID = realid;
		EditorID = editorid;
		Character = character;

	}
}

[SerializeField]
[System.Serializable]
public class EditDatabase{
	public List<EditDatabaseMap> EditMapList;
	public List<EditDatabaseCharacter> EditCharacterList;
}


[SerializeField]
[System.Serializable]
public class Save{
	public int CurrentCharacter;
	public TimePosition CurrentTime;

}




[SerializeField]
[System.Serializable]
public class Game{	
	public int GameID;
	public string GameName;
	public int PlayerGameMode;//1 normal.
	public List<Save> GameSaves;


}


[System.Serializable]
public class GameFileDatabase{


	public List<Character> CharacterList;
	public List<GameMap> MapList;

	public GameFileDatabase(){

	}

}


public class DatabaseClassMONO : MonoBehaviour {


}
