using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour {

	private static ScreenController instance;
	public static ScreenController Instance{get {return instance;}}

	public GameObject ImageTracker;

	public GameObject StartScreen;
	public GameObject Instruction1Screen;
	public GameObject Instruction2Screen;
	public GameObject RatingScreen;
	public GameObject InfoScreen;
	public GameObject NavBar;

	public void Start(){
		instance = this;
	}

	public void StartButtonClick(){
		StartScreen.SetActive (false);
		Instruction1Screen.SetActive (true);
		ImageTracker.SetActive (false);
	}

	public void Instuction1ButtonClick(){
		Instruction1Screen.SetActive (false);
		Instruction2Screen.SetActive (true);
	}

	public void Instuction2ButtonClick(){
		Instruction2Screen.SetActive (false);
		NavBar.SetActive (true);
		ImageTracker.SetActive (true);
	}

	public void ShowHelp(){
		ImageTracker.SetActive (false);
		RatingScreen.SetActive (false);
		NavBar.SetActive (false);
		InfoScreen.SetActive (false);
		Instruction1Screen.SetActive (true);
	}

	public void ShowInfo(){
		InfoScreen.SetActive (true);
		NavBar.SetActive (false);
	}

	public void HideInfo(){
		InfoScreen.SetActive (false);
		NavBar.SetActive (true);
	}

	public void RatingsScreenActive(){
		ImageTracker.SetActive (false);
		RatingScreen.SetActive (true);
		NavBar.SetActive (false);
		InfoScreen.SetActive (false);
	}

	public void RatingsScreenInactive(){
		ImageTracker.SetActive (true);
		RatingScreen.SetActive (false);
		NavBar.SetActive (true);
		InfoScreen.SetActive (false);
	}


}
