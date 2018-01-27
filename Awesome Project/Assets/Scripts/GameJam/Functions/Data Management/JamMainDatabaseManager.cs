using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class JamMainDatabaseManager : MonoBehaviour {

	private JsonData CurrentJsonData;

	/*private List<MainDatabaseMap> CurrentMapList = new List<MainDatabaseMap> ();
	private List<DataLogic> CurrentDataLogic = new List<DataLogic>();


	public List<MainDatabaseMap> DatabaseMapList = new List<MainDatabaseMap>();
	public List<DataLogic> DatabaseMapLogic = new List<DataLogic>();
	public List<MainDatabaseCharacter> DatabaseCharacterList = new List<MainDatabaseCharacter>();
*/



	public void LoadPlayer(){
	}

	public void LoadMainDatabase(){
	}
	/*

	private void LoadLogicContent(){
		for(int i = 0; i < CurrentJsonData.Count; i ++){
			int ID = (int)CurrentJsonData [i] ["ID"];
			string Name = CurrentJsonData [i] ["Name"].ToString ();
			List<LogicTypeContent> TypeList = new List<LogicTypeContent> ();

			for(int x = 0; x < CurrentJsonData[i]["Content"].Count; x ++){
				int TypeID = (int)CurrentJsonData [i] ["Content"] [x] ["ID"];
				string TypeName = CurrentJsonData [i] ["Content"] [x] ["Name"].ToString();
				string TypeDescription = CurrentJsonData [i] ["Content"] [x] ["Description"].ToString ();
				List<LogicSubTypeContent> SubTypeList = new List<LogicSubTypeContent> ();

				for(int y = 0; y < CurrentJsonData[i]["Content"][x]["SubtypeList"].Count; y ++){
					int SubtypeID = (int)CurrentJsonData [i] ["Content"] [x] ["SubtypeList"] [y] ["ID"];
					string SubtypeName = CurrentJsonData[i]["Content"][x]["SubtypeList"][y]["Name"].ToString();
					string SubtypeDescription = CurrentJsonData [i] ["Content"] [x] ["SubtypeList"] [y] ["Description"].ToString ();
					LogicSubTypeContent NewSubtype = new LogicSubTypeContent (SubtypeID, SubtypeName,SubtypeDescription);
					SubTypeList.Add (NewSubtype);
				}
				LogicTypeContent NewType = new LogicTypeContent (TypeID,TypeName,TypeDescription,SubTypeList);	
				TypeList.Add (NewType);
			}

			DataLogic newlogic = new DataLogic (ID,Name, TypeList);
			CurrentDataLogic.Add (newlogic);
		}
	}*/

}
