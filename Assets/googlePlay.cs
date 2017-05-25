using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class googlePlay : MonoBehaviour {

	public GameObject loginAgainButton;
	public GameObject loginSuccessButton;

	// Use this for initialization
	void Start () {
		loginAgainButton = GameObject.Find ("login");
		loginSuccessButton = GameObject.Find ("loginSuccess");
		loginSuccessButton.SetActive (false);

		PlayGamesPlatform.Activate ();

		//Social.localUser.Authenticate((result, errorMessage) => {
		Social.localUser.Authenticate((bool success) => {
			//if (result)
			if (success)
			{
				// 인증 성공
				Debug.Log("login Success");
				loginSuccessButton.SetActive(true);
			}
			else
			{
				// 인증 실패
				Debug.Log("login Failure");
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
