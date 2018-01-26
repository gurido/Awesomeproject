using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Phrase {

	public bool IsPhraseValid;
	public string PhraseContent;
	public int PhraseLenght;
	public int PhrasePunctuationType; //1 period; 2 comma; 3 exclamation; 4 question
}

public class DiaryEntry{

	public int DiaryPage;
	public List<Phrase> DiaryPhrases = new List<Phrase> ();
}

public class DiaryClassMONO : MonoBehaviour {


}
