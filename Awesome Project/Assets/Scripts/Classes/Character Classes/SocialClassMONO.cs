using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyKnowledgeOfTheirKnowledgeOfMe{
}

public class MyKnowledgeOfThem{
}


public class MyViewOfTheirViewOfMe{
}

public class MyViewOfThem{
}

[SerializeField]
public class InterpersonalFeeling : Emotion{
	public int GeneralFeeling;

	public InterpersonalFeeling(int rage, int loathing, int grief, int amazement, int terror, int admiration, int ecstasy, int vigilance, int general){
		Rage = rage;
		Loathing = loathing;
		Grief = grief;
		Amazement = amazement;
		Terror = terror;
		Admiration = admiration;
		Ecstasy = ecstasy;
		Vigilance = vigilance;
		GeneralFeeling = general;
	}
}

[SerializeField]
public class MemoryWithThem{
	public List<Event> PastEvents;
	public MemoryWithThem(List<Event> pastevents){
		PastEvents = pastevents;
	}
}

[SerializeField]
public class SocialGroup{
	public int Size;
	public int Type;
	public List<int> Member;
}

[SerializeField]
public class Relationship{
	public int Character;
	public int RelatedType;
	public int PersonalRelationship;
	public InterpersonalFeeling Feeling;
	public MemoryWithThem MemoryWithThem;
	//public MyViewOfThem MyViewOfThem;
	//public MyViewOfTheirViewOfMe MyViewOfTheirViewOfMe;
	//public MyKnowledgeOfThem MyKnowledgeOfThem;
	//public MyKnowledgeOfTheirKnowledgeOfMe MyKnowledgeOfTheirKnowledgeOfMe;

	public Relationship(int character, int relatedtype, int personalrelationship, InterpersonalFeeling feeling, MemoryWithThem memory ){
		Character = character;
		RelatedType = relatedtype;
		PersonalRelationship = personalrelationship;
		Feeling = feeling;
		MemoryWithThem = memory;
	}
}


[SerializeField]
public class Reputation{//like relationship but in a group
	public int SocialGroup;
	public int RoleInGroup;
	public int GroupVisibility;

	public Reputation (int socialgroup, int roleingroup, int visibility){
		SocialGroup = socialgroup;
		RoleInGroup = roleingroup;
		GroupVisibility = visibility;
	}
}


[SerializeField]
public class SocialCondition{
	public List<Relationship> RelationshipList = new List<Relationship>();
	public List<Reputation> ReputationList = new List<Reputation>();

	public SocialCondition (List<Relationship> relationships, List<Reputation> reputations){
		RelationshipList = relationships;
		ReputationList = reputations;
	}
}



public class SocialClassMONO : MonoBehaviour {


}
