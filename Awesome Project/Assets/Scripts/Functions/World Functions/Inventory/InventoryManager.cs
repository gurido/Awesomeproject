using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
	public int SlotAmmount;
	public List<InventorySlot> inventorySlots = new List<InventorySlot>();

	DatabaseManager database;


	public void InventoryManagerStart(){
		database = GetComponent<DatabaseManager> ();
		SlotAmmount = 12;
		BuildEmptyInventory ();
	}

	private void BuildEmptyInventory(){
		for (int i = 0; i < SlotAmmount; i++) {
			inventorySlots.Add (new InventorySlot(i,new Item(),0,false));
		}
	}


	public void SwapItem(int item1, int item2){
		InventorySlot prevSlot = inventorySlots [item1];
		inventorySlots [item1] = inventorySlots [item2];
		inventorySlots [item2] = prevSlot;


	}


	public void AddItem( int id, int amount){

		Item itemToAdd = database.FetchItemByID (id);
		ItemType itemType = database.FetchItemTypeByID (itemToAdd.ItemType);
		for (int i = 0; i < inventorySlots.Count; i++) {
			if (itemType.Stackable == true && inventorySlots [i].SlotItem.ItemID == id && inventorySlots [i].IsFull == false) {
				inventorySlots [i].Amount = inventorySlots [i].Amount + amount;
				if (inventorySlots [i].Amount == 9) {
					inventorySlots [i].IsFull = true;
				}
				if (inventorySlots [i].Amount > 9) {
					inventorySlots [i].IsFull = true;
					AddItem (id,inventorySlots[i].Amount - 9);
					inventorySlots [i].Amount = 9;
				}
				break;
			}
			else{
				if (inventorySlots [i].SlotItem.ItemID == -1) {
					inventorySlots [i].SlotItem = itemToAdd;
					inventorySlots [i].Amount = inventorySlots [i].Amount + amount;
					break;
					}
				}
			}
		}
	


	public void DeleteItem(int id){

		if (inventorySlots [id].SlotItem.ItemID == -1) {
			//Debug.Log ("No items to delete");
		} else {
			inventorySlots [id].Amount--;
			inventorySlots [id].IsFull = false;
			if (inventorySlots [id].Amount == 0) {
				inventorySlots [id].SlotItem = new Item ();
			}

		}

	}






	bool CheckIfItemIsInInventory(Item item){
		for(int i = 0; i < inventorySlots.Count ; i++){
			if(inventorySlots[i].SlotItem.ItemID == item.ItemID){
				return true;
			}
		}
		return false;
	}
}
