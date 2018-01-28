using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public class JamCalendarClass{
	public int Day;
	public int Weekday;
	public int Event;

	public JamCalendarClass(int day, int weekday, int dayevent){
		Day = day;
		Weekday = weekday;
		Event = dayevent;

	}

}
	
