using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class CharacterName{
	public string FirstName;
	public string LastName;
	public int NameType;
	public string Fullname;
	public string CommonNickname;

	public CharacterName(string firstname,string lastname,int nametype, string commonnickname){
		FirstName = firstname;
		LastName = lastname;
		NameType = nametype;
		CommonNickname = commonnickname;
		fullnamecalculator ();
	}

	public void fullnamecalculator(){
		switch (NameType) {
		case 1://western
			Fullname = FirstName + " " + LastName;
			break;
		case 2://chinese
			Fullname = LastName + FirstName;
			break;
		case 3://japanese
			Fullname = LastName + FirstName;
			break;
		default:
			break;

		}
	}


}


public class CharacterNameClassMONO : MonoBehaviour {


}
