using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics;
using debug = UnityEngine.Debug;

public class CBall : MonoBehaviour {
	enum enumBallMode {
		ready, letsrock, gameover
	}

	GameObject playerGameObj;
	GameObject gameController;
	//enumBallMode curMode = enumBallMode.ready;
	enumBallMode curMode;


	void Start () {
		playerGameObj = GameObject.Find ("Paddle");
		gameController = GameObject.Find ("floor");
		curMode = enumBallMode.ready;
	}
	

	void Update () {

		if (curMode == enumBallMode.ready) {
			Vector3 pos = playerGameObj.transform.position;
			pos.y += 0.26f;

			transform.position = pos;
		}

		if (curMode != enumBallMode.gameover && transform.position.y <= -4.7f) {
			//transform.position.y = -5.0f;
			curMode = enumBallMode.gameover;
			Time.timeScale = 0;
			gameController.SendMessage("GameOver");
		}
	}

	void Fire() {
		if (curMode == enumBallMode.letsrock)
			return;
		
		Vector3 vel = Vector3.zero;
		vel.x = playerGameObj.transform.position.x;
		vel.y = 10;

		vel.Normalize();
		vel *= 7.0f; // ball speed

		Rigidbody2D rb = (Rigidbody2D)GetComponent (typeof(Rigidbody2D));
		rb.velocity = vel;

		curMode = enumBallMode.letsrock;
	}
}
