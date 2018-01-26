using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSprites{
	public Sprite Default;

	public CharacterSprites(string slug){
		
		Default = Resources.Load<Sprite> ("Sprites/Characters/" + slug + "/Default" );


	}



}


[SerializeField]
public class Character{

	public int CharacterNumber;
	public CharacterName CharacterName;

	public Body CharacterBody;//internal biological conditions
	public Mind CharacterMind;//internal psychological conditions
	public SocialCondition CharacterSocialCondition;//external social conditions
	public PhysicalCondition PhysicalCondition;//external physical world conditions
	public CharacterSprites CharacterSprites;


	public Character (CharacterName name, int number, Body body, Mind mind, SocialCondition socialcondition, PhysicalCondition physicalcondition, CharacterSprites sprites) {
		CharacterName = name;
		CharacterNumber = number;
		CharacterBody = body;
		CharacterMind = mind;
		CharacterSocialCondition = socialcondition;
		PhysicalCondition = physicalcondition;
		CharacterSprites = sprites;
		}
}



public class CharacterClassMONO : MonoBehaviour {


}
