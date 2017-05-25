using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class googlePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();

		Social.localUser.Authenticate((result, errorMessage) => {
			if (result)
			{
				// 인증 성공
				Debug.Log("login Success");
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
