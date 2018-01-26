using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public abstract class RegularIncomeExpense{
	public int Type;
	public int Money;
	public int Frequency;
	public int TimeLeftTilNext;

}


[SerializeField]
public class RegularIncome : RegularIncomeExpense{
	public RegularIncome (int type, int money, int frequency, int timelefttilnext){
		Type = type;
		Money = money;
		Frequency = frequency;
		TimeLeftTilNext = timelefttilnext;
	}
}

[SerializeField]
public class RegularExpense : RegularIncomeExpense{
	public RegularExpense (int type, int money, int frequency, int timelefttilnext){
		Type = type;
		Money = money;
		Frequency = frequency;
		TimeLeftTilNext = timelefttilnext;
	}
}
	


[SerializeField]
public class Property{
	public int Wealth;//current usable money
	public List<RegularIncome> Incomes;
	public List<RegularExpense> Expenses;
	public CharacterInventory CharacterInventory;


	public Property(int wealth, List<RegularIncome> incomes, List<RegularExpense> expenses, CharacterInventory inventory){
		Wealth = wealth;
		Incomes = incomes;
		Expenses = expenses;
		CharacterInventory = inventory;
	}

}

[SerializeField]
public class PhysicalTemporal{
	public int CurrentPosition;
	public int CurrentTime; //0 = default time

	public PhysicalTemporal(int position, int time){
		CurrentPosition = position;
		CurrentTime = time;
	}

}

[SerializeField]
public class PhysicalCondition{
	public PhysicalTemporal PhysicalTemporal;
	public Property Property;
	public WeekRoutine WeekRoutine;

	public PhysicalCondition(PhysicalTemporal physicaltemporal, Property property, WeekRoutine weekroutine){
		PhysicalTemporal = physicaltemporal;
		Property = property;
		WeekRoutine = weekroutine;

	}
}


public class PhysicalConditionClassMONO : MonoBehaviour {


}
