using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionManager : MonoBehaviour {
	public int EmotionTarget;
	public int IncreasingEmotionType;
	public int IncreasingEmotionIntensity;

	private DatabaseManager database;

	public void StartEmotionManager(){
		database = GetComponent<DatabaseManager>();
	}


	public void IncreseEmotion(){
		switch(IncreasingEmotionType){
		case 1://rage
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Rage = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Rage + IncreasingEmotionIntensity;
			break;
		case 2://loathing
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Loathing = database .CharacterList [EmotionTarget].CharacterMind.Emotion.Loathing + IncreasingEmotionIntensity;
			break;
		case 3://grief
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Grief = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Grief + IncreasingEmotionIntensity;
			break;
		case 4://amazemeng
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Amazement = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Amazement + IncreasingEmotionIntensity;
			break;
		case 5://terror
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Terror = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Terror + IncreasingEmotionIntensity;
			break;
		case 6://admiration
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Admiration = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Admiration + IncreasingEmotionIntensity;
			break;
		case 7://ecstasy
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Ecstasy = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Ecstasy + IncreasingEmotionIntensity;
			break;
		case 8://vigilance
			database.CharacterList [EmotionTarget].CharacterMind.Emotion.Vigilance = database.CharacterList [EmotionTarget].CharacterMind.Emotion.Vigilance + IncreasingEmotionIntensity;
			break;
		default:
			break;
		}
	}


	public void CoolDownEmotion(){

	}

	public void ResetEmotion(){
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Rage = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Loathing = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Grief = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Amazement = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Terror = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Admiration = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Ecstasy = 0;
		database.CharacterList [EmotionTarget].CharacterMind.Emotion.Vigilance = 0;

	}

}
