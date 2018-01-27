using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamMessage{
	public int ID;
	public int User;
	public string Content;

	public JamMessage(int id, int user, string content){
		ID = id;
		User = user;
		Content = content;

	}


}



public class JamChat{
	
	public int ID;
	public int User;
	public List<JamMessage> Message;

	public JamChat(int id, int user){

		ID = id;
		User = user;
		Message = new List<JamMessage> ();

	}

}



