using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareManager : MonoBehaviour {

	const string FACEBOOK_APP_ID = "124608541444801";
	const string FACEBOOK_URL = "http://www.facebook.com/dialog/feed";
	//const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";

	public static void ShareToFacebook(
		string linkParameter, string nameParameter, string captionParameter,
		string descriptionParameter, string pictureParameter, string redirectParameter
	)
	{
		Application.OpenURL(FACEBOOK_URL + "?app_id=" + FACEBOOK_APP_ID +
			"&link=" + WWW.EscapeURL(linkParameter) +
			"&name=" + WWW.EscapeURL(nameParameter) +
			"&caption=" + WWW.EscapeURL(captionParameter) +
			"&description=" + WWW.EscapeURL(descriptionParameter) +
			"&picture=" + WWW.EscapeURL(pictureParameter) +
			"&redirect_uri=" + WWW.EscapeURL(redirectParameter));
	}

	//public static void ShareToTwitter(string textToDisplay, string language)
	//{// language: "en", "kor", "jap"
	//	Application.OpenURL(TWITTER_ADDRESS +
	//		"?text=" + WWW.EscapeURL(textToDisplay) +
	//		"&amp;lang=" + WWW.EscapeURL(language));
	//}

	public void OnBtnFaceBook()
	{
		ShareToFacebook(
			"https://play.google.com/store/apps/details?id=com.hanaabiru.scandalK",            // linkParameter - TODO: app download link
			"OPIc을 깨 보자!",                // nameParameter
			"developed by somingoose of coalamovement",           	// captionParameter
			"OPIc Breakers Game",       	// descriptionParameter
			"https://www.google.co.kr/images/srpr/logo11w.png", 	// pictureParameter - TODO: app icon image
			"http://www.facebook.com"       // redirectParamter
		);
	}

	//public void OnBtnTwitter()
	//{
	//	ShareToTwitter("http://sunbug.net", "kor");
	//}

}
