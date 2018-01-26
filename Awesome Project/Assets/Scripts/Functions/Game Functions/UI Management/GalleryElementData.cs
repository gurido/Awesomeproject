using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GalleryElementData : MonoBehaviour, IPointerDownHandler{

	public int ElementID;
	public GameObject GalleryMenu;
	private GalleryUIManager gallerymanager;
	public Text ElementText;
	public Image ElementImage;


	public void StartGalleryElement(){

		GalleryMenu = this.transform.parent.gameObject.transform.parent.gameObject;
		gallerymanager = GalleryMenu.GetComponent<GalleryUIManager> ();


	}

	public void OnPointerDown(PointerEventData eventData){
		

		gallerymanager.SelectElement (ElementID);


	}



}
