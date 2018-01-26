using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public abstract class Emotion{
	public int Rage;
	public int Loathing;
	public int Grief;
	public int Amazement;
	public int Terror;
	public int Admiration;
	public int Ecstasy;
	public int Vigilance;

}

[SerializeField]
public class CurrentEmotion : Emotion {
	public CurrentEmotion(int rage, int loathing, int grief, int amazement, int terror, int admiration, int ecstasy, int vigilance){
		Rage = rage;
		Loathing = loathing;
		Grief = grief;
		Amazement = amazement;
		Terror = terror;
		Admiration = admiration;
		Ecstasy = ecstasy;
		Vigilance = vigilance;
	}
}



[SerializeField]
public class MentalDisorder{
	public int DisorderType;
	public int DisorderIntensity;
	public int DisorderTarget;
	public MentalDisorder (int type, int intensity, int target){
		DisorderType = type;
		DisorderIntensity = intensity;
		DisorderTarget = target;
	}
}
	

[SerializeField]
public class Skills{
	public List<int> LanguageList = new List<int>();
}


[SerializeField]
public class Mind{
	public Personality Personality;
	public Cognition Cognition;
	public Emotion Emotion;
	public Memory Memory;
	public Skills Skills;
	public List<MentalDisorder> MentalHealth = new List<MentalDisorder> ();

	public Mind(Personality personality, Cognition cognition, Emotion emotion,Memory memory,List<MentalDisorder> mentalheath,Skills skills){
		Personality = personality;
		Cognition = cognition;
		Emotion = emotion;
		Memory = memory;
		MentalHealth = mentalheath;
		Skills = skills;
	}

}


public class MindClassMONO : MonoBehaviour {



}
