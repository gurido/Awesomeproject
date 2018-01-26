using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class LogicSubTypeContent{
	public int ID;
	public string Name;
	public string Description;

	public LogicSubTypeContent(int id, string name, string description){
		ID = id;
		Name = name;
		Description = description;
	}
}

[SerializeField]
public class LogicTypeContent{
	public int ID;
	public string Name;
	public string Description;
	public List<LogicSubTypeContent> SubtypeList;

	public LogicTypeContent(int id, string name, string description, List<LogicSubTypeContent> subtypelist){
		ID = id;
		Name = name;
		Description = description;
		SubtypeList = subtypelist;
	}
}



[SerializeField]
public class DataLogic{
	public int ID;
	public string Name;
	public List<LogicTypeContent> Content;

	public DataLogic(int id, string name, List<LogicTypeContent> content){
		ID = id;
		Name = name;
		Content = content;

	}

}



[SerializeField]
public class MapObject{
	public int Type;//Furniture, Access Point, Wall, Water
	public int ID;// if its access point, it means the location it leads to
	public int PositionX;
	public int PositionY;

	public MapObject(){
		Type = -1;
	}
	public MapObject(int type, int id, int positionx, int positiony){
		Type = type;
		ID = id;
		PositionX = positionx;
		PositionY = positiony;
	}
}

[SerializeField]
public class MapTile{
	public int ID;
	public int TileType;
	public int PositionX;
	public int PositionY;

	public MapTile(){
		ID = -1;
	}

	public MapTile(int id, int type, int x, int y){
		ID = id;
		TileType = type;
		PositionX = x;
		PositionY = y;
	}


}


[SerializeField]
public class GameMap{

	public int ID;
	public string Name;//my house, supermarket, city park, amigo's house etc
	public string Description;//my cool house 
	public int Type;//world, country, city, street, building, room
	public int SizeX;
	public int SizeY;
	public List<MapTile> MapTileList;
	public List<MapObject> MapObjectList;


	public GameMap(){
		ID = -1;
	}

	public GameMap(int id, string name, string description, int type, int sizex, int sizey,List<MapTile> maptilelist, List<MapObject> mapobjectlist){
		ID = id;
		Name = name;
		Description = description;
		Type = type;
		SizeX = sizex;
		SizeY = sizey;
		MapTileList = maptilelist;
		MapObjectList = mapobjectlist;
	}

}






public class MapClassMONO : MonoBehaviour {

}
