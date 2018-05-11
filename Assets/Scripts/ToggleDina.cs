using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDina : MonoBehaviour {

	public GameObject dinaContent;
	public int textNumber = 0;

	public GameObject TextObj;

	// Use this for initialization
	void Start () {
		
	}

	void Update() {
		if (Input.GetMouseButtonUp(0)) {
			dinaContent.SetActive (true);
			this.gameObject.SetActive (false);
			ScreenController.Instance.ShowInfo ();
			//
			//TextObj.SetActive (true);
		}
	}
}
