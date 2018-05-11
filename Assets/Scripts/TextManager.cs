using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public GameObject popText1;
	public GameObject popText2;
	public GameObject popText3;
	public GameObject popText4;

	void Start(){
	}

	public void setTextString(int stringNum){
		popText1.SetActive (false);
		popText2.SetActive (false);
		popText2.SetActive (false);
		popText2.SetActive (false);
		switch(stringNum){
		case 0:
			popText1.SetActive (true);
			break;
		case 1:
			popText2.SetActive (true);
			break;
		case 2:
			popText3.SetActive (true);
			break;
		case 3:
			popText4.SetActive (true);
			break;
		/*case 0:
			popText.text = "Vincent Van Gogh painted a total of five large canvases with sunflowers in a vase, with three shades of yellow and nothing else";
			break;
		case 1:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 2:
			popText.text = "Founded in 1825 in Paris, CBG Mignot to this day continue the great tradition of lead soldiers for nearly two hundred years.";
			break;
		case 3:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 4:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 5:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 6:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 7:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 8:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 9:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 10:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 11:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 12:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 13:
			popText.text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;*/
		}
	}
}
