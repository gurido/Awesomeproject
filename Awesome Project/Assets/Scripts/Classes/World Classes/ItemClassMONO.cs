using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventorySlot{
	public int SlotID;
	public Item SlotItem;
	public int Amount;
	public bool IsFull;
	public InventorySlot(){

	}

	public InventorySlot(int slot, Item item, int amount, bool isfull){
		SlotID = slot;
		SlotItem = item;
		Amount = amount;
		IsFull = isfull;
	}

}



[SerializeField]
public class ItemFunction{
	public int FunctionID;
	public string FunctionName;

	public ItemFunction(int id, string name){
		FunctionID = id;
		FunctionName = name;
	}

}



[SerializeField]
public class ItemSubType{
	public int SubTypeID;
	public string SubTypeName;//drink, fruit, vegetable,
	public int SubTypeFunction;
	public ItemSubType (int id, string name, int function){
		SubTypeID = id;
		SubTypeName = name;
		SubTypeFunction = function;
	}
}



[SerializeField]
public class ItemType{
	public int TypeID;
	public string TypeName;//furniture, food, tool, weapon, resources, 
	public bool Stackable;
	public List<ItemSubType> SubTypes;
	public ItemType(int id, string name, bool stackable, List<ItemSubType> subtype){
		TypeID = id;
		TypeName = name;
		Stackable = stackable;
		SubTypes = subtype;

	}
}



[SerializeField]
public class Item{
	public int ItemID{ get; set;}
	public string ItemName{ get; set;}
	public int ItemType{ get; set;}
	public string ItemDescription{ get; set;}
	public int GlobalPrice{ get; set;}
	public Sprite ItemSprite { get; set;}

	public Item(int id, string name, int type, string description,  int price){
		ItemID = id;
		ItemName = name;
		ItemType = type;
		ItemDescription = description;
		GlobalPrice = price;
		ItemSprite = Resources.Load<Sprite> ("Sprites/Items/" + ItemName);
	}
	public Item(){
		this.ItemID = -1;
		ItemSprite = Resources.Load<Sprite> ("Sprites/UIs/Color/transparent");

	}
}

public class CharacterInventory{
}


public class ItemClassMONO : MonoBehaviour {



}
