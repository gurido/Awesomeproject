using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryElement{
	public int ID;
	public string ElementTitle;
	public Sprite ElementSprite;

	public GalleryElement(int id, string title, Sprite sprite){
		ID = id;
		ElementTitle = title;
		ElementSprite = sprite;
	}
}




public class GalleryUI{

	public int ID;
	public string Name;
	public bool CanCreatNew;
	public string CreateNewElementText;
	public int OptionsAvailable;
	public List<string> OptionTextList;

	public List<GalleryElement> GalleryElementList;


	public GalleryUI(){
		ID = -1;
	}

	public GalleryUI(int id, string name,  bool cancreatenew, string createnewelementtext, int optionsavailable, List<string> optiontextlist, List<GalleryElement> galleryelementlist){
		ID = id;
		Name = name;
		CanCreatNew = cancreatenew;
		CreateNewElementText = createnewelementtext;
		OptionsAvailable = optionsavailable;
		OptionTextList = optiontextlist;
		GalleryElementList = galleryelementlist;
	}

}

public class UITemplateClassMONO : MonoBehaviour {


}
