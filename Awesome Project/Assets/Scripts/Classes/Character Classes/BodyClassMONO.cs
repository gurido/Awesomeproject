using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class Health{
}

[SerializeField]
public class Metabolism{
	public int RegenerationSpeed;

}

[SerializeField]
public class BodyParts{
	public bool IsSightWorking;
	public bool IsHearingWorking;
	public bool IsSmellingWorking;
	public bool IsLeftLegWorking;
	public bool IsRightLegWorking;
	public bool IsRightArmWorking;
	public bool IsLeftArmWorking;


	public BodyParts(bool sight, bool hearing, bool smelling, bool leftlegworking, bool rightlegworking, bool leftarmworking, bool rightarmworking){
		IsSightWorking = sight;
		IsHearingWorking = hearing;
		IsSmellingWorking = smelling;
		IsLeftLegWorking = leftlegworking;
		IsRightLegWorking = rightlegworking;
		IsLeftArmWorking = leftarmworking;
		IsRightArmWorking = rightarmworking;

	}

}

[SerializeField]
public class BasicBodyStats{

	public int RaceType; //default human.  1 human
	public int Age;
	public int Height; //default 170 cm
	public int Sex; //1 male 2 female 3 other
	public int Bodytype; //default normal. 1 normal/2 muscular/3 thicc/4 slim

	public BasicBodyStats(int race,int age, int height, int sex, int bodytype){
		RaceType = race;
		Age = age;
		Height = height;
		Sex = sex;
		Bodytype = bodytype;
	}
}

[SerializeField]
public class BodyNeeds{
	public int Food;
	public int Water;
	public int Sleep;
	public int Warmth;
	public int Shelter;
	public int Air;

	public BodyNeeds(int food, int water, int sleep, int warmth, int shelter, int air){
		Food = food;
		Water = water;
		Sleep = sleep;
		Warmth = warmth;
		Shelter = shelter;
		Air = air;

	}

}

[SerializeField]
public class BodyCondition{
	public bool DeathOrAlive;
	public int ConsciousState;//default is awake, 1 asleep/ 2 drunk
	public int MaxEnergy;
	public int CurrentEnergy;
	public BodyNeeds Needs;

	public BodyCondition(bool deathoralive, int consciousstate, int maxenergy, int currentenergy, BodyNeeds needs){
		DeathOrAlive = deathoralive;
		ConsciousState = consciousstate;
		MaxEnergy = maxenergy;
		CurrentEnergy = currentenergy;
		Needs = needs;
	}
}

[SerializeField]
public class Body{
	public BasicBodyStats BasicBodyStats;
	public BodyParts Bodylimbs;
	public BodyCondition BodyCondition;

	public Body (BasicBodyStats basicbodystats, BodyParts bodylimbs, BodyCondition bodycondition ) {
		BasicBodyStats = basicbodystats;
		Bodylimbs = bodylimbs;
		BodyCondition = bodycondition;
	}

}

public class BodyClassMONO : MonoBehaviour {



}
