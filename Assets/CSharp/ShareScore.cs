using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareScore : MonoBehaviour {

	Timer currentScore;
	float nowScore;

	// Use this for initialization
	void Start () {
		currentScore = GameObject.Find ("Timer").GetComponent<Timer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnShareButton ()
	{
		nowScore = currentScore.time;
		// OS별 일반적 공유
		GeneralShare generalShare = new GeneralShare ();   
		generalShare.shareText ("OPIc Breakers", "\ud83c\udfc6" + nowScore.ToString()
			+ "점 달성\ud83c\udfc6 나에게 꼭 맞는 질문으로 외국어 능력을 측정할 수 있는 OPIc! " +
			"응시하기 전 OPIc Breaker로 함께 OPIc을 깨 보자!!\ud83d\ude06\ud83d\ude06 " +
			"다운로드\ud83d\udc49http://play.google.com/store/apps/details?id=com.somingoose.OPIcBreakers");

		// 이미지 공유시
		//generalShare.shareImageWithText ("MyGameApp", "Message", _myScreenShot);
	}
}
