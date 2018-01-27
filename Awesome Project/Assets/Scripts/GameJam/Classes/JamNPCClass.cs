using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class JamNPC{
	public int ID;
	public string Name;
	public int Gender;

	public JamNPC(int id, string name, int gender){
		ID = id;
		Name = name;
		Gender = gender;

	}

	public JamNPC(){
		ID = -1;
	}

}


