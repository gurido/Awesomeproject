using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class InventorySlotHandler : MonoBehaviour , IDropHandler{
	public int SlotID;
	private GameObject inventorymenupanel;
	private InventoryManager inv;
	private InventoryMenuManager invMenu;

	public void StartInventorySlotHandler(){
		inv = GameObject.Find ("_GameManager").GetComponent<InventoryManager> ();
		inventorymenupanel = GameObject.Find ("MainCanvas").transform.GetChild (1).gameObject.transform.GetChild (1).gameObject;
		invMenu = inventorymenupanel.GetComponent<InventoryMenuManager> ();
		//Debug.Log ("SlotHandler started" + SlotID);
	}



	public void OnDrop(PointerEventData eventData){
		SlotItemHandler droppedItem = eventData.pointerDrag.GetComponent<SlotItemHandler>();
		Transform item = this.transform.GetChild (0);

		item.GetComponent<SlotItemHandler> ().SlotNumber = droppedItem.SlotNumber;
		item.transform.SetParent (invMenu.InventorySlots [droppedItem.SlotNumber].transform);
		item.transform.position = invMenu.InventorySlots [droppedItem.SlotNumber].transform.position;

		inv.SwapItem (droppedItem.SlotNumber,SlotID);
		droppedItem.SlotNumber = SlotID;

	}

}
