using System.Collections;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class SlotItemHandler : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public int SlotNumber;
	public Item item;

	private GameObject inventorymenupanel;
	private InventoryMenuManager invMenu;
	private Vector2 offset;

	public void StartSlotItemHandler()
	{
		inventorymenupanel = GameObject.Find ("MainCanvas").transform.GetChild (1).gameObject.transform.GetChild (1).gameObject;
		invMenu = inventorymenupanel.GetComponent<InventoryMenuManager> ();
		//Debug.Log ("ItemHandler started" + SlotNumber);
	}
		
	public void OnPointerDown(PointerEventData eventData){
		if (item != null) {
			invMenu.SelectSlot (this.transform.GetComponentInParent<InventorySlotHandler>().SlotID);
		}
	}

	public void OnBeginDrag(PointerEventData eventData){
		
		if (item != null) {
			offset = eventData.position - new Vector2 (this.transform.position.x, this.transform.position.y);

			this.transform.SetParent (this.transform.parent.parent);
			this.transform.position = eventData.position - offset;
			GetComponent<CanvasGroup> ().blocksRaycasts = false;
		}
	}

	public void OnDrag(PointerEventData eventData){

		if (item != null){
			this.transform.position = eventData.position - offset;
		}
	}

	public void OnEndDrag(PointerEventData eventData){

		this.transform.SetParent (invMenu.InventorySlots[SlotNumber].transform);
		this.transform.position = invMenu.InventorySlots[SlotNumber].transform.position;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;

	}
}
