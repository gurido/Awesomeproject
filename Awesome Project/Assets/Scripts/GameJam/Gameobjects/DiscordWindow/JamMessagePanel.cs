using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JamMessagePanel : MonoBehaviour {

	public Text Content;
	public Text Username;
	public Image Profilepic;



	public void StartMessagePanel(Sprite profilesprite, string username, string content){
		Profilepic.sprite = profilesprite;
		Username.text = username;
		Content.text = content;



	}

}
