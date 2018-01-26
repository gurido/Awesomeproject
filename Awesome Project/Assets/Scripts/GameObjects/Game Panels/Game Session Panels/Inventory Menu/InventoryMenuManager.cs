using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuManager : MonoBehaviour {
	public int InventoryState; //1 normal/2 storage/3 buy/4 sell/5 gift/6 craft
	public Text InventoryTitle;

	private GameObject inventoryPanel;
	private GameObject slotPanel;
	public GameObject InventorySlot;
	public GameObject InventoryItem;
	private GameObject ItemObj;
	public List<GameObject> InventorySlots = new List<GameObject>();

	private int CurrentSelectedSlot;
	public Text ItemDescriptionText;
	private string ItemDescriptionString;
	public GameObject ItemDropButton;
	public Text Button1Text;
	private GameStatusManager gamestatusmanager;
	private GameObject gamemanager;
	private InventoryManager inventoryManager;
	public bool IsInventoryCreated = false;



	public void InventoryMenuManagerStart(){
		InventoryState = 1;
		gamestatusmanager = GameObject.Find ("_GameManager").GetComponent<GameStatusManager> ();
		CreateInventoryUI ();
		UpdateInventoryTitle ();
		UpdateInventoryUI ();
	}

	public void InventoryMenuManagerUpdate(){
		GetKey ();
	}

	private void GetKey(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			inventoryManager.AddItem(1,1);
			UpdateInventoryUI ();

		}
		if (Input.GetKeyDown (KeyCode.Backspace)) {
			
		}
	}



	public void PressMainButton1(){
		switch(InventoryState){
		case 1:// normal
			DropItem ();
			break;
		case 2:// Storage Item
			break;
		case 3:// Take Out Item
			break;
		case 4:// Buy
			break;
		case 5:// Sell
			break;
		case 6:// Gift
			break;
		case 7:// Craft
			break;
		default:
			break;
		}
		UpdateItemInspection ();

	}

	private void UpdateInventoryTitle(){
		switch(InventoryState){
		case 1:// normal
			InventoryTitle.text = "Inventory";
			break;
		case 2:// Storage Item
			InventoryTitle.text = "Store Items";
			break;
		case 3:// Take Out Item
			InventoryTitle.text = "Take out Items";
			break;
		case 4:// Buy
			InventoryTitle.text = "Buy";
			break;
		case 5:// Sell
			InventoryTitle.text = "Sell";

			break;
		case 6:// Gift
			InventoryTitle.text = "Gift";

			break;
		case 7:// Craft
			InventoryTitle.text = "Crafting";

			break;
		default:
			break;
		}
	}

	private void UpdateItemInspection(){
		if (inventoryManager.inventorySlots [CurrentSelectedSlot].SlotItem.ItemID == -1) {
			ItemDescriptionText.text = "";
			ItemDropButton.SetActive (false);
		} else {
			ItemDescriptionString = inventoryManager.inventorySlots [CurrentSelectedSlot].SlotItem.ItemDescription;
			ItemDescriptionText.text = inventoryManager.inventorySlots [CurrentSelectedSlot].SlotItem.ItemName + "\n" + ItemDescriptionString;
			ItemDropButton.SetActive (true);
			switch(InventoryState){
			case 1:// normal
				Button1Text.text = "DROP";
				break;
			case 2:// Storage Item
				Button1Text.text = "STORAGE";
				break;
			case 3:// Take Out Item
				Button1Text.text = "TAKE OUT";
				break;
			case 4:// Buy
				Button1Text.text = "BUY";
				break;
			case 5:// Sell
				Button1Text.text = "SELL";
				break;
			case 6:// Gift
				Button1Text.text = "GIFT";
				break;
			case 7:// Craft
				break;
			default:
				break;
			}
		}


	}


	public void SelectSlot(int slot){
		CurrentSelectedSlot = slot;
		UpdateItemInspection ();

	}
	public void DropItem(){
		inventoryManager.DeleteItem(CurrentSelectedSlot);
		UpdateInventoryUI ();
	}

	private void CreateInventoryUI(){
		if (IsInventoryCreated == false) {
			IsInventoryCreated = true;
			gamemanager = GameObject.Find("_GameManager").gameObject;
			inventoryManager = gamemanager.GetComponent<InventoryManager>();
			inventoryPanel = GameObject.Find ("MainCanvas").gameObject.transform.GetChild (1).gameObject.transform.GetChild (1).gameObject;
			slotPanel = inventoryPanel.transform.GetChild (1).gameObject;
			for (int i = 0; i < inventoryManager.SlotAmmount; i++) {
				InventorySlots.Add (Instantiate (InventorySlot));
				InventorySlots [i].transform.SetParent (slotPanel.transform, false);
				InventorySlots [i].GetComponent<InventorySlotHandler> ().SlotID = i;
				InventorySlots [i].GetComponent<InventorySlotHandler> ().StartInventorySlotHandler ();
				ItemObj = Instantiate (InventoryItem);
				ItemObj.transform.SetParent (InventorySlots [i].transform, false);
				ItemObj.GetComponent<SlotItemHandler> ().SlotNumber = i;
				ItemObj.GetComponent<SlotItemHandler> ().StartSlotItemHandler ();
			}
		} else {
			//inventory exists
		}

	}





	private void UpdateInventoryUI(){

		for (int i = 0; i < inventoryManager.inventorySlots.Count; i++) {
			GameObject currentItem;
			currentItem = slotPanel.transform.GetChild (i).gameObject.transform.GetChild(0).gameObject;
			slotPanel.transform.GetChild (i).GetComponent<InventorySlotHandler> ().SlotID = i ;
			ItemObj.transform.GetComponent<SlotItemHandler> ().SlotNumber = i;

			currentItem.GetComponent<SlotItemHandler> ().item = inventoryManager.inventorySlots[i].SlotItem;
			if(inventoryManager.inventorySlots[i].SlotItem.ItemID == -1){
				currentItem.GetComponent<Image>().sprite = inventoryManager.inventorySlots[i].SlotItem.ItemSprite;
				currentItem.transform.GetChild (0).GetComponent<Text> ().text = "";

			}
			else{
				currentItem.GetComponent<Image> ().sprite = inventoryManager.inventorySlots[i].SlotItem.ItemSprite;
				currentItem.transform.GetChild (0).GetComponent<Text> ().text = inventoryManager.inventorySlots [i].Amount.ToString ();
			}

			UpdateItemInspection ();

		}
	}

	public void ExitInventoryMenu(){
		gamestatusmanager.ChangeStatusToMainMenu ();
		//GetComponent<GameStatusManager> ().ChangeStatusToMainMenu ();
	}
}


