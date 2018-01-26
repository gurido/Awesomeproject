using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Knowledge{
	//Objective Knowledge of the world and the past


}

[SerializeField]
public class Concept{
	//mental grouping of similar objects, people, ideas or events.
	//it speed up our thinking, but can also box our thinking in and lead to prejudices
	//Character's personal philosophy
}

[SerializeField]
public class Prototype{
	//mental image or pinnacle example of a certain thing
	//character's set propierties for a object in the world
}



[SerializeField]
public class Morality{

}

[SerializeField]
public class Cognition{
	//thoughts, perspectives and expectations
	public Concept Concept;
	public Prototype Prototype;
	public Knowledge Knowledge;
	public Morality Morality;

	public Cognition(){

	}

	public Cognition (Concept concept, Prototype prototype, Knowledge knowledge, Morality morality){
		Concept = concept;
		Prototype = prototype;
		Knowledge = knowledge;
		Morality = morality;
	}

}


public class CognitionClassMONO : MonoBehaviour {


}
