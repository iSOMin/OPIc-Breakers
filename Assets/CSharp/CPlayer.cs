using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour {
	Vector3 position;
	bool isDrag;
	GameObject ballGameObj;

	Vector3 dragStartPos;


	void Start () {
		position = transform.position;
		isDrag = false;
		ballGameObj = GameObject.Find ("Ball");
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			isDrag = true;
			dragStartPos = Input.mousePosition;
		}

		if (Input.GetMouseButtonUp (0)) {
			isDrag = false;
			ballGameObj.SendMessage ("Fire");
		}

		if (isDrag) {
			Vector3 delta = Input.mousePosition - dragStartPos;
			dragStartPos = Input.mousePosition;

			position.x += delta.x / 32.0f;

			if(position.x > 2.3f) position.x = 2.3f;
			if (position.x < -2.3f) position.x = -2.3f;
		}

		transform.position = position;

	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject == ballGameObj) {
			Vector3 vel = Vector3.zero;
			vel.x = (ballGameObj.transform.position.x - transform.position.x) * 3.0f;
			vel.y = 10;

			vel.Normalize();
			vel *= 7.0f;

			Rigidbody2D rb = (Rigidbody2D)ballGameObj.GetComponent (typeof(Rigidbody2D));
			rb.velocity = vel;
		}
	}
}
