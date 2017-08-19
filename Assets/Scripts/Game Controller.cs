using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	ModelController model;
	SceneBuilder builder;

	Action transferEvent(Event e) {

		return null;
	}

	void transferAsyncEvent(Event e) {
		
	}

	void transferNode(Node content) {
		
	}

	// Use this for initialization
	void Start () {
		model = new ModelController ();
		builder = new SceneBuilder ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
