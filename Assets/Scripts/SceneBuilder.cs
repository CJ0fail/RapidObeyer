using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;


public class SceneBuilder : MonoBehaviour {


	public string text;
	public GameObject canvas;
	public GameObject background_image;
	public GameObject character_image;
	public string background_imagePath;
	public string character_imagePath;

	// Use this for initialization
	void Start () {

		background_imagePath = "Assets/Sprites/saltykong.jpg";
		character_imagePath = "Assets/Sprites/GottschalkLeona Small.jpg";
		//Create Canvas
		canvas = new GameObject ("Canvas");
		//Create Background image
		background_image = new GameObject ("Background");
		//Create character
		character_image = new GameObject ("Character");

		//Add components
		var back_image = background_image.AddComponent<Image> ();
		var canvasComp = canvas.AddComponent<Canvas>();
		var char_image = character_image.AddComponent<Image> ();

		//Set Canvas as parent
		background_image.transform.SetParent (canvas.transform);
		character_image.transform.SetParent (canvas.transform);


		canvasComp.renderMode = RenderMode.ScreenSpaceCamera;
		//Set position
		canvas.GetComponent<Transform> ().position = new Vector3 (0, 0, 0);

		//Set background image to the size of the camera
		var camCoord = Camera.main.pixelRect;
		background_image.GetComponent<RectTransform>().sizeDelta = camCoord.size;


		//Add background image
		back_image.sprite = (Sprite)UnityEditor.AssetDatabase.LoadAssetAtPath(background_imagePath, typeof(Sprite));
		char_image.sprite = (Sprite)UnityEditor.AssetDatabase.LoadAssetAtPath(character_imagePath, typeof(Sprite));


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
