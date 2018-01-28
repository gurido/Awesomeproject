using UnityEngine.Audio;
using UnityEngine;
using System;

public class JamAudioManager : MonoBehaviour {


	public JamSound[] sounds;

	void Awake(){
		foreach (JamSound s in sounds) {

			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;

		}

	}


	public void Play(string name){

		JamSound s =  Array.Find (sounds, JamSound => JamSound.name == name);
		s.source.Play ();

		//Debug.Log ("Played sound " + name);

	}




}
