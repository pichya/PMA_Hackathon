using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotManager : MonoBehaviour {

	public int currentDot;
	public int totalDots;

	public GameObject dot1;
	public GameObject dot2;
	public GameObject dot3;
	public GameObject dot4;


	public void UpdateDot(int dotNumber){
		dot1.SetActive (false);
		dot2.SetActive (false);
		dot3.SetActive (false);
		dot4.SetActive (false);
		//
		if (dotNumber == 0) {
			dot1.SetActive (true);
		}

		if (dotNumber == 1) {
			dot2.SetActive (true);
		}

		if (dotNumber == 2) {
			dot3.SetActive (true);
		}

		if (dotNumber == 3) {
			dot4.SetActive (true);
		}

	}

}
