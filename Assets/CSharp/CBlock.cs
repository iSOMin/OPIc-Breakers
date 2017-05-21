using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBlock : MonoBehaviour {

	GameObject blockCounter;

	// Use this for initialization
	void Start () {
		blockCounter = GameObject.Find ("floor");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll) {
		GameObject.Destroy (gameObject);
		blockCounter.SendMessage ("CounterDown");
	}
}
