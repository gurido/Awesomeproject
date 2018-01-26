using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ego{

}

public class Id{
}

public class Superego{
}

public class Psychoanalysis{
	public Ego Ego;
	public Id Id;
	public Superego Superego;
}

public class BiologicalPersonality{

}

public class CognitivePersonality{
}

public class HumanismPersonality{
}


public class Behaviorism{

}

public class FundamentalPersonalityCharacteristics{
	public int Conscientiousness;
	//tendency to display self-discipline, dutiful, strive for achievement against outside expectations
	//control, regulare and direct their impulses. high score indicates preference for planned rather than
	//spontaneous behavior. it rise among young adults and decline when getting older
	public int Agreeableness;
	//Individual's concern for social harmony. value getting along with others, considerate, kind, generous,
	//trusting, trustworthy, helpful and willing to compromise their interests with others. optimistic view of human nature
	//disagreeables put self-interest above getting along with others. they are unconcerned with other's well-being,
	//less likely to extend themselves for other people. Their skepticism about other's motives cause them to be
	//suspicious, unfriendly and uncooperative.
	//this trait correlates with the quality of relationships with one's team members. it also positively predicts transformational leadership skills
	public int Neuroticism;
	//tendency to experience negative emotions, such as anger, anxiety or depression. emotion stability/instability
	//it is linked with low tolerance for stress or aversive stimuli. more likely to interpret ordinary situations as
	//threatening, and minor frustrations as hopelessly difficult. Their negative emotional reactions tend 
	//to persist for unusually long periods of time, which means they are often in a bad mood.
	public int Openness;
	//general appreciation for art, emotion, adventure, unusual ideas, imagination, curiosity,
	//and variety of experience. intellectually curious, open to emotion, sensitive to beauty,
	//willing to try new things. more aware of their feelings and likely to hold unconventional beliefs
	//score low are less easily upset amd emotionally reactive. Calm, emotionally stable, free from persistent
	//nefative feelings. Freedom from negative felings does not mean that low scorers
	public int Extraversion;
	//breadth of activities(as opossed to depth) surgency from external activity/situation, and enerty
	//creation from external means. The trait is marked by pronounced engagement with the external world
	//extraverts enjoy interacting with people, often perceived as full of energy. enthusiastic, action-oriented individual
	//high group visibility, like to talk and assert themselves
	//introverts have lower social engagement and energy level. quiet, lowkey, deliberate, less involved in social world.
	//not due to shyness or depression, instead they are more independent of their social world than extraverts
	//they need less stimulation than extraverts and more time alone. 


	public FundamentalPersonalityCharacteristics (int conscientiousness, int agreeableness, int neuroticism, int openness, int extraversion ){
		Conscientiousness = conscientiousness;
		Agreeableness = agreeableness;
		Neuroticism = neuroticism;
		Openness = openness;
		Extraversion = extraversion;
	}


}

public class Personality{
	//configuration
	/*
	public BiologicalPersonality BiologicalPersonality;//57%openness, 54%extraversion, 49%neuroticism, 42%agreeableness
	public Psychoanalysis Psychoanalysis;
	public CognitivePersonality CognitivePersonality;
	public HumanismPersonality HumanismPersonality;
	public Behaviorism Behaviorism;*/

	// main manifestation
	public FundamentalPersonalityCharacteristics PersonalityCharacteristics; 


	public Personality(FundamentalPersonalityCharacteristics fivepersonality){
		PersonalityCharacteristics = fivepersonality;

	}

}






public class PersonalityClassMONO : MonoBehaviour {


}
