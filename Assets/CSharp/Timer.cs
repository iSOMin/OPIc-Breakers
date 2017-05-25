using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

	public float time;
	GameObject gameController;
	bool gameOverFlag;

	void Start () {
		time = 10000f;
		//time = 1000f;
		gameController = GameObject.Find ("floor");
		gameOverFlag = false;
	}

	void Update () {

		Text uiText = GetComponent<Text> ();

		time -= Mathf.Ceil(Time.deltaTime);


		uiText.text = "Score " + time.ToString ();

		if (gameOverFlag == false && time == 0) {
			gameController.SendMessage ("GameOver");
			gameOverFlag = true;
		}
	}

	string currentScore() {
		return time.ToString ();
	}
}
