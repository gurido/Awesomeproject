using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameobjectPathDictionary {


	private static string CharacterConfigurationFolder = "/StreamingAssets/Character Configurations/";
	private static string GameDatasFolder = "/StreamingAssets/Game Datas/";
	private static string ItemDatasFolder = "/StreamingAssets/World Datas/Item Datas/";
	private static string MapDatasFolder = "/StreamingAssets/World Datas/Map Datas/";

	private static string PrefabPanelBuildMode = "Prefab/GamePanels/Build/";
	private static string PrefabPanelPlayMode = "Prefab/GamePanels/Play/";
	private static string PrefabPanelGeneralMode = "Prefab/GamePanels/General/";

	private static string MainDatabaseFolder = "/Resources/Database/Main Database/";
	private static string GamesDatabaseFolder = "/Resources/Database/Games/";
	private static string GeneralDatabaseFolder = "/Resources/Database/General/";

	//do this next
	public static readonly Dictionary<string, string> MainDatabasePath = new Dictionary<string, string> {
		{"PlayerData",GeneralDatabaseFolder + "PlayerData.json"},
		{"MapDatabase",MainDatabaseFolder + "MapDatabase.json"},
		{"CharacterDatabase", MainDatabaseFolder + "CharacterDatabase.json"},

		{"Game1Save1", GamesDatabaseFolder + "Game1" + "/" + "Save1" + ".json"},


		{"end", "end"}

	};



	public static readonly Dictionary<int, string> DatabaseDictionary = new Dictionary<int, string> {
		{0,"PlayerData"},
		{1,"ItemData"},
		{2, "ItemFunctionData"},
		{3, "ItemTypeData"},

		{4, "DefaultCharacter"},

		{5, ""},
		{6, ""},
		{7, "GamePanelData"},
		{8, "GameMapData"},
		{9, ""},
		{10, "FurnitureData"},
		{11, "FurnitureTypeData"}

	};


	public static readonly Dictionary<string, string> JsonFilePath = new Dictionary<string, string> {
		{"PlayerData",GameDatasFolder + "PlayerData.json"},
		{"GamePanelData",GameDatasFolder + "GamePanelData.json"},

		{"ItemData", ItemDatasFolder + "ItemData.json"},
		{"ItemFunctionData", ItemDatasFolder + "ItemFunctionData.json"},
		{"ItemTypeData",ItemDatasFolder + "ItemTypeData.json"},

		{"GameMapData", MapDatasFolder + "GameMapData.json"},
		{"AccessPointData",MapDatasFolder + "AccessPointData.json"},
		{"FurnitureData", MapDatasFolder + "FurnitureData.json"},
		{"FurnitureTypeData", MapDatasFolder + "FurnitureTypeData.json"},

		{"DefaultCharacter", CharacterConfigurationFolder + "DefaultCharacter.json"},



		{"end", "end"}
	
	};




	public static readonly Dictionary<string, string> GamePrefabPath = new Dictionary<string, string> {

		{"GamePanels","Prefab/GamePanels/"}
	};




	public static readonly Dictionary<int, string> GamePanelIDictionary = new Dictionary<int, string> {
		{-1,"MainCanvas"},
		{0,"TransparentPanel"},
		{1,"IntroMenuPanel"},

		//Play Mode
		{3, "MainGamePanel"},
		{8, "PlayerMenuPanel"},
		{9, "DialoguePanel"},
		{6, "CharacterInspectionPanel"},
		{5, "CharacterInventoryPanel"},
		{4, "NPCViewPanel"},
		{12, "MapPanel"},
		{2, "PauseMenu"},

		//Build Mode
		{7, "CharacterCreationPanel"},
		{13, "MapCreationPanel"},
		{11, "WriteDiaryPanel"},	
		{10, "DiaryPanel"},
		{30,"end"}
	};

	public static readonly Dictionary<string, string> GamePanelPath = new Dictionary<string, string> {
		{"MainCanvas","MainCanvas"},
		{"IntroMenuPanel",PrefabPanelGeneralMode + "IntroMenuPanel"},
		{"TransparentPanel",PrefabPanelGeneralMode + "TransparentPanel" },

		//Play Mode
		{"MainGamePanel", PrefabPanelPlayMode +  "MainGamePanel"},
		{"PlayerMenuPanel",PrefabPanelPlayMode +  "PlayerMenuPanel"},
		{"DialoguePanel",PrefabPanelPlayMode + "DialoguePanel"},
		{"CharacterInventoryPanel",PrefabPanelPlayMode + "CharacterInventoryPanel"},
		{"MapPanel",PrefabPanelPlayMode + "MapPanel"},
		{"PauseMenu",PrefabPanelPlayMode + "PauseMenu"},

		//Build Mode
		{"CharacterCreationPanel",PrefabPanelBuildMode + "CharacterCreationPanel"},
		{"MapCreationPanel",PrefabPanelBuildMode + "MapCreationPanel"},
		{"CharacterInspectionPanel",PrefabPanelBuildMode + "CharacterInspectionPanel"},
		{"NPCViewPanel",PrefabPanelBuildMode + "NPCViewPanel"},

		{"WriteDiaryPanel",PrefabPanelBuildMode + "WriteDiaryPanel"},	
		{"DiaryPanel",PrefabPanelBuildMode + "DiaryPanel"},


		{"end","end"}
	};



	public static readonly Dictionary<int, string> Layer1Dictionary = new Dictionary<int, string> {
		{-1,"MainCanvas"},
		{0,"TransparentPanel"},
		{1,"IntroMenuPanel"},

		//Play Mode
		{3, "MainGamePanel"},
		{8, "PlayerMenuPanel"},
		{9, "DialoguePanel"},
		{6, "CharacterInspectionPanel"},
		{5, "CharacterInventoryPanel"},
		{4, "NPCViewPanel"},
		{12, "MapPanel"},
		{2, "PauseMenu"},

		//Build Mode
		{7, "CharacterCreationPanel"},
		{13, "MapCreationPanel"},
		{11, "WriteDiaryPanel"},	
		{10, "DiaryPanel"},
		{30,"end"}
	};


	public static readonly Dictionary<string, string> TimeManagerPath = new Dictionary<string, string> {

		{"TimeText","/StreamingAssets/Game Datas/GamePanelData.json"},
		{"WriteDiaryPanel", "WriteDiaryPanel"}
	};


}
