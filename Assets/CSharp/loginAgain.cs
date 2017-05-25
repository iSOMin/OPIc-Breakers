using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loginAgain : MonoBehaviour {

	public GameObject loginButton;
	public GameObject successButton;

	// Use this for initialization
	void Start () {
		loginButton = GameObject.Find ("login");
		successButton = GameObject.Find ("loginSuccess");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loginToPlayGames() {
		Social.localUser.Authenticate((bool success) => {
			//if (result)
			if (success)
			{
				// 인증 성공
				Debug.Log("login Success");
				loginButton.SetActive(false);
				successButton.SetActive(true);
			}
			else
			{
				// 인증 실패
				Debug.Log("login Failure");
			}
		});
	}
}
