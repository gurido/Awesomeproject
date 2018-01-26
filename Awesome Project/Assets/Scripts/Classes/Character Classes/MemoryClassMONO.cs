using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Need{
	public TimePosition Time;
	public int Type;
	public Need (TimePosition time, int type){
		Time = time;
		Type = type;
	}

}

[SerializeField]
public class Motivation{
	//driving force that leads to behaviors
	public TimePosition Time;
	public int Type;
	public Motivation (TimePosition time, int type){
		Time = time;
		Type = type;
	}

}
[SerializeField]
public class Thought{
	public TimePosition Time;
	public int Type;
	public Thought (TimePosition time, int type){
		Time = time;
		Type = type;
	}
}

[SerializeField]
public class Event{
	public TimePosition Time;
	public int Type;
	public Event (TimePosition time, int type){
		Time = time;
		Type = type;
	}
}


[SerializeField]
public class PastDayEvent {//memories within 1 day

	public List<Thought> Thoughts = new List<Thought>();
	public List<Need> Needs = new List<Need>();
	public List<Motivation> Motivation = new List<Motivation>();
	public List<Event> Events = new List<Event> ();

	public PastDayEvent(List<Thought> thoughts, List<Need> needs, List<Motivation> motivation, List<Event> events){
		Thoughts = thoughts;
		Needs = needs;
		Motivation = motivation;
		Events = events;
	}
}

[SerializeField]
public class PastWeekEvent { //memories within 1 week
	public List<Thought> Thoughts = new List<Thought>();
	public List<Need> Needs = new List<Need>();
	public List<Motivation> Motivation = new List<Motivation>();
	public List<Event> Events = new List<Event> ();


	public PastWeekEvent(List<Thought> thoughts, List<Need> needs, List<Motivation> motivation, List<Event> events){
		Thoughts = thoughts;
		Needs = needs;
		Motivation = motivation;
		Events = events;
	}
}

[SerializeField]
public class PastMonthEvent { //memories within 1 month

	public List<Thought> Thoughts = new List<Thought>();
	public List<Need> Needs = new List<Need>();
	public List<Motivation> Motivation = new List<Motivation>();
	public List<Event> Events = new List<Event> ();

	public PastMonthEvent(List<Thought> thoughts, List<Need> needs, List<Motivation> motivation, List<Event> events){
		Thoughts = thoughts;
		Needs = needs;
		Motivation = motivation;
		Events = events;
	}
}

[SerializeField]
public class PastYearEvent {
	public List<Thought> Thoughts = new List<Thought>();
	public List<Need> Needs = new List<Need>();
	public List<Motivation> Motivation = new List<Motivation>();
	public List<Event> Events = new List<Event> ();


	public PastYearEvent(List<Thought> thoughts, List<Need> needs, List<Motivation> motivation, List<Event> events){
		Thoughts = thoughts;
		Needs = needs;
		Motivation = motivation;
		Events = events;
	}
}

[SerializeField]
public class PastLifetimeEvent {
	public List<Thought> Thoughts = new List<Thought>();
	public List<Need> Needs = new List<Need>();
	public List<Motivation> Motivation = new List<Motivation>();
	public List<Event> Events = new List<Event> ();


	public PastLifetimeEvent(List<Thought> thoughts, List<Need> needs, List<Motivation> motivation, List<Event> events){
		Thoughts = thoughts;
		Needs = needs;
		Motivation = motivation;
		Events = events;
	}
}

[SerializeField]
public class Memory{

	public PastDayEvent PastDayEvent;
	public PastWeekEvent PastWeekEvent;
	public PastMonthEvent PastMonthEvent;
	public PastYearEvent PastYearEvent;
	public PastLifetimeEvent PastLifetimeEvent;



	public Memory(PastDayEvent pastday, PastWeekEvent pastweek, PastMonthEvent pastmonth, PastYearEvent pastyear, PastLifetimeEvent pastlife){
		PastDayEvent = pastday;
		PastWeekEvent = pastweek;
		PastMonthEvent = pastmonth;
		PastYearEvent = pastyear;
		PastLifetimeEvent = pastlife;
	}

}
public class MemoryClassMONO : MonoBehaviour {


}
