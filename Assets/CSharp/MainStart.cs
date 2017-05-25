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
	/*
	public void learnMore() {
		Application.OpenURL ("https://www.opic.or.kr/opics/servlet/controller.opic.site.about.AboutServlet?p_process=move-page-introduce&p_nav=3_1_1");
	}

	public void goTest() {
		Application.OpenURL ("https://www.opic.or.kr/opics/servlet/controller.opic.site.receipt.ExamReceiptServlet?p_process=select-list&p_nav=1_1");
	}
	*/
}
