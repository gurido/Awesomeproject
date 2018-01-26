using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour {


	public static bool MatchList(List<int> list1, List<int> list2){

		if (list1.Count != list2.Count) {
			return false;
		}
		for(int i = 0; i < list1.Count; i++){
			if(list1[i] != list2[i]){
				return false;
			}
		}
		return true;
	}

	public static bool MatchArrayList(int[] Array, List<int> list){

		if (Array.Length != list.Count) {
			return false;
		}
		for(int i = 0; i < Array.Length; i++){
			if(Array[i] != list[i]){
				return false;
			}
		}
		return true;
	}



}
