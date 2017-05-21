using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickEvent() {
		Application.OpenURL ("https://www.opic.or.kr/opics/servlet/controller.opic.site.receipt.ExamReceiptServlet?p_process=select-list&p_nav=1_1");
	}
}
