using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public class GameSettings{
	int MusicVolume;
	int SFXVolime;
	int Resolution;

}

[SerializeField]
public class Player {
	public int PlayerID;
	public string PlayerName;
	public string PlayerPassword;
	public int PlayerType; //1 = normie, 2 = player, 3 = admin
	GameSettings FaveSettings;
	public List<Game> PlayerGames;
	public MainDatabase PlayerDatabase;



	public Player(){
	}

}


public class PlayerClassMONO : MonoBehaviour {


}
