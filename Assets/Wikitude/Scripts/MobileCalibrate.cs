using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCalibrate : MonoBehaviour {

	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	public bool tracking = false;
	public int statueNumber;

	// Use this for initialization
	void Start () {
		guiStyle.fontSize = 50; //change the font size
		guiStyle.normal.textColor = Color.white;
		//if (!tracking) {
			switch(statueNumber){
			case 0:
				// Official Start Parameters
				transform.position = new Vector3 (0f,-0.43f, 0f);
				transform.rotation = new Quaternion (0.001f, 0.979f, 0.005f, 0.202f);
				transform.localScale = new Vector3 (0.19f, 0.19f, 0.19f);
				break;
			case 1:
				// General Start Parameters
				transform.position = new Vector3 (0f,0f,0f);
				transform.rotation = new Quaternion (-0.0031f,0.997f,0.008f,-0.074f);
				transform.localScale = new Vector3 (0.166f,0.166f,0.166f);
				break;
			case 2:
				// Musician Start Parameters
				transform.position = new Vector3 (-0.05f,-0.15f,0f);
				transform.rotation = new Quaternion (-0.013f,0.950f,-0.012f,0.311f);
				transform.localScale = new Vector3 (0.19f,0.19f,0.19f);
				break;
			case 3:
				// Cavalryman Start Parameters
				transform.position = new Vector3 (0f,0f,0f);
				transform.rotation = new Quaternion (-0.014f,0.963f,0.000f,0.270f);
				transform.localScale = new Vector3 (0.177f,0.177f,0.177f);
				break;
			case 4:
				// Horse Start Parameters
				transform.position = new Vector3 (0f,-0.28f,0f);
				transform.rotation = new Quaternion (0.014f,0.996f,0.054f,0.065f);
				transform.localScale = new Vector3 (0.125f,0.125f,0.125f);
				break;
			case 5:
				// Infantryman Start Parameters
				transform.position = new Vector3 (0f,-0.52f,0f);
				transform.rotation = new Quaternion (0.004f,0.988f,0.013f,0.153f);
				transform.localScale = new Vector3 (0.171f,0.171f,0.171f);
				break;
			case 6:
				// Standing Archer Start Parameters
				transform.position = new Vector3 (0f, 0f, 0f);
				transform.rotation = new Quaternion (-0.0031f, 1.0f, 0.000f, 0.001f);
				transform.localScale = new Vector3 (0.181f, 0.181f, 0.181f);
				break;
			case 7:
				// Kneeling Start Parameters
				transform.position = new Vector3 (0f,0.117f,0f);
				transform.rotation = new Quaternion (0.010f,0.994f,-0.039f,0.105f);
				transform.localScale = new Vector3 (0.19f,0.19f,0.19f);
				break;
			//}
		}

	}

	void OnGUI(){
		GUI.Box (new Rect (10, 10, 1200, 240), "Occluder Transform");
		GUI.Label (new Rect (20, 40, 1200, 60), "Position: " + this.transform.position.ToString("F3"), guiStyle);
		GUI.Label (new Rect (20, 100, 1200, 60), "Rotation: " + this.transform.localEulerAngles.ToString("F3"), guiStyle);
		GUI.Label (new Rect (20, 160, 1200, 60), "Scale: " + this.transform.localScale.ToString("F3"), guiStyle);
	}
		
	// Update is called once per frame
	void Update () {
		if (tracking) {
			if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.Rotate (0, -touchDeltaPosition.x * 0.01f, 0);
				transform.Translate (0, 0, -touchDeltaPosition.y * 0.01f);
			} else if (Input.touchCount == 2 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.localScale = new Vector3 (transform.localScale.x + touchDeltaPosition.y * 0.001f,
													transform.localScale.y + touchDeltaPosition.y * 0.001f, 
													transform.localScale.z + touchDeltaPosition.y * 0.001f);				
			}
		}


	}
}
