using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour {

	public GameObject Star1;
	public GameObject Star2;
	public GameObject Star3;
	public GameObject Star4;
	public GameObject Star5;

	public void ClearStar () {
		Star1.SetActive (false);
		Star2.SetActive (false);
		Star3.SetActive (false);
		Star4.SetActive (false);
		Star5.SetActive (false);
	}
	public void OneStar () {
		Star1.SetActive (true);
		Star2.SetActive (false);
		Star3.SetActive (false);
		Star4.SetActive (false);
		Star5.SetActive (false);
	}
	public void TwoStar () {
		Star1.SetActive (true);
		Star2.SetActive (true);
		Star3.SetActive (false);
		Star4.SetActive (false);
		Star5.SetActive (false);
	}

	public void ThreeStar () {
		Star1.SetActive (true);
		Star2.SetActive (true);
		Star3.SetActive (true);
		Star4.SetActive (false);
		Star5.SetActive (false);
	}
	public void FourStar () {
		Star1.SetActive (true);
		Star2.SetActive (true);
		Star3.SetActive (true);
		Star4.SetActive (true);
		Star5.SetActive (false);

	}
	public void FivesStar () {
		Star1.SetActive (true);
		Star2.SetActive (true);
		Star3.SetActive (true);
		Star4.SetActive (true);
		Star5.SetActive (true);
	}

}
