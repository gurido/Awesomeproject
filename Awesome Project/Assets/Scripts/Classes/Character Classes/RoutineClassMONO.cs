using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public class DayRoutine {

	public int Time;//1 pm or monday
	public int Place;//home, school
	public int TimesPerformed;
	public int HowUsedTo;//0 never done it/1 not used to/2 used to/3 natural
	public int TimeDuration; // 1 hour,half ahour...
	public int State;//1 finished, 2 on going
	public CharacterAction Action;//work, school, sleep, eat...

	public DayRoutine(int time, int place, int timesperformed, int howusedto, int duration, int state , CharacterAction action){
		Time = time;
		Place = place;
		TimesPerformed = timesperformed;
		HowUsedTo = howusedto;
		TimeDuration = duration;
		State = state;
		Action = action;

	}
}

[SerializeField]
public class WeekRoutine {
	public List<DayRoutine> MondayRoutines;
	public List<DayRoutine> TuesdayRoutines;
	public List<DayRoutine> WednesdayRoutines;
	public List<DayRoutine> ThursdayRoutines;
	public List<DayRoutine> FridayRoutines;
	public List<DayRoutine> SaturdayRoutines;
	public List<DayRoutine> SundayRoutines;

	public WeekRoutine(List<DayRoutine> monday,List<DayRoutine> tuesday,List<DayRoutine> wednesday,List<DayRoutine> thursday,List<DayRoutine> friday,List<DayRoutine> saturday,List<DayRoutine> sunday){
		MondayRoutines = monday;
		TuesdayRoutines = tuesday;
		WednesdayRoutines = wednesday;
		ThursdayRoutines = thursday;
		FridayRoutines = friday;
		SaturdayRoutines = saturday;
		SundayRoutines = sunday;
	}

}
public class RoutineClassMONO : MonoBehaviour {




}
