using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickEvent() {
		Application.OpenURL ("https://www.opic.or.kr/opics/servlet/controller.opic.site.about.AboutServlet?p_process=move-page-introduce&p_nav=3_1_1");
	}
}
