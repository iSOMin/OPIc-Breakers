using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(800, 1280, true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.platform == RuntimePlatform.Android) {
			if(Input.GetKey(KeyCode.Escape)) {
				Application.Quit();
			}
		}
	}
}
