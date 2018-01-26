using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPathDictionary : MonoBehaviour {



	private static string CharacterFunctionsFolder =  "/Scripts/Functions/Character Functions/";

	private static string CharacterFolder =  "Charater/";
	private static string ActionFolder ="Action/";
	private static string EmotionFolder = "Emotion/";
	private static string ThoughtFolder = "Thought/";

	private static string GameFunctionsFolder = "/Scripts/Functions/Game Functions/";
	private static string DataManagementFolder =  "Data Management/";
	private static string StatusManagementFolder =  "StatusManagement/";

	private static string WorldFunctionsFolder = "/Scripts/Functions/World Functions/";
	private static string DiaryFolder = "Diary/";
	private static string ItemFolder ="Items/";
	private static string JobFolder =  "Job/";
	private static string LocationFolder =  "Location/";
	private static string TimeFolder =  "Time/";
	private static string InventoryFolder = "Inventory/";

	private static string GamePanelsFolder =  "/Scripts/GameObjects/Game Panels/";

	private static string CharacterCreationMenuFolder =   "Character Creation Menu/";
	private static string CharacterInspectionMenuFolder =   "Character Inspection Menu/";
	private static string DiaryMenuFolder =  "Diary Menu/";
	private static string InventoryMenuFolder =   "Inventory Menu/";
	private static string MainMenuManagerMenuFolder =  "Main Menu Manager/";
	private static string NPCManagerMenuFolder =   "NPC Management Menu/";
	private static string PauseMenuFolder =  "Pause Menu/";





	public static readonly Dictionary<string, string> FunctionScriptPath = new Dictionary<string, string> {

		{"CharacterActionManager", CharacterFunctionsFolder + ActionFolder + "CharacterActionManager"},
		{"CharacterManager", CharacterFunctionsFolder + CharacterFolder  + "CharacterManager"},		
		{"CharacterCreationManager",CharacterFunctionsFolder + CharacterFolder + "CharacterCreationManager"},
		{"CharacterConfigurationManager",CharacterFunctionsFolder + CharacterFolder + "CharacterConfigurationManager"},
		{"EmotionManager",CharacterFunctionsFolder + EmotionFolder + "EmotionManager"},
		{"ThoughtManager",CharacterFunctionsFolder + ThoughtFolder + "ThoughtManager"},

		{"DatabaseManager",GameFunctionsFolder + DataManagementFolder +  "DatabaseManager"},
		{"PlayerManager", GameFunctionsFolder + DataManagementFolder + "PlayerManager"},
		{"PlayerSaveLoad",GameFunctionsFolder + DataManagementFolder +  "PlayerSaveLoad"},
		{"SaveLoadManager",GameFunctionsFolder + DataManagementFolder + "SaveLoadManager"},

		{"GameStatusManager",GameFunctionsFolder + StatusManagementFolder +  "GameStatusManager"},
		{"UIManager",GameFunctionsFolder + StatusManagementFolder +  "UIManager"},

		{"DiaryInputManager", WorldFunctionsFolder + DiaryFolder + "DiaryInputManager"},
		{"DiaryInputReader", WorldFunctionsFolder + DiaryFolder +"DiaryInputReader"},
		{"InventoryManager", WorldFunctionsFolder + InventoryFolder +"InventoryManager"},
		{"ItemManager", WorldFunctionsFolder + ItemFolder +"ItemManager"},
		{"JobManager", WorldFunctionsFolder + JobFolder + "JobManager"},
		{"LocationManager", WorldFunctionsFolder + LocationFolder +"LocationManager"},
		{"TimeManager", WorldFunctionsFolder + TimeFolder +"TimeManager"},




	};

	public static readonly Dictionary<string, string> GameObjectScriptPath = new Dictionary<string, string> {

		{"CharacterCreationMenuManager",GamePanelsFolder + CharacterCreationMenuFolder +  "CharacterCreationMenuManager"},
		{"CharacterInspectionManager",GamePanelsFolder + CharacterInspectionMenuFolder + "CharacterInspectionManager"},

		{"DiaryEntryMenuManager",GamePanelsFolder + DiaryMenuFolder +  "DiaryEntryMenuManager"},
		{"InventoryMenuManager",GamePanelsFolder + InventoryMenuFolder  +  "InventoryMenuManager"},
		{"InventorySlotHandler",GamePanelsFolder + InventoryMenuFolder +  "InventorySlotHandler"},
		{"SlotItemHandler",GamePanelsFolder + InventoryMenuFolder  +  "SlotItemHandler"},
		{"MainMenuManager",GamePanelsFolder + MainMenuManagerMenuFolder +  "MainMenuManager"},
		{"NPCMenuManager",GamePanelsFolder + NPCManagerMenuFolder  +  "NPCMenuManager"},
		{"NPCMenuDescriptionManager",GamePanelsFolder + NPCManagerMenuFolder +  "NPCMenuDescriptionManager"},
		{"PauseMenuManager",GamePanelsFolder + PauseMenuFolder  +  "PauseMenuManager"}

	};


}
