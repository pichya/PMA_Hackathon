using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour {

	public GameObject contentObj;
	public DotManager dotObj;

	public int imageTotal = 3;
	public int imageCounter = 0;

	public float scrollIncrement = 6.5f;

	private float time;
	private float scrollTime;

	private Vector3 currentPosition;
	private Vector3 targetPosition;

	private bool lerpFlag = false;

	private void Start(){
		lerpFlag = false;
		scrollTime = 0.25f;
	}

	private void Update(){
		if (SwipeManager.Instance.IsSwiping (SwipeDirection.Left) && lerpFlag==false) {
			//Debug.Log ("LEFT");
			ScrollRight();
			SwipeManager.Instance.Direction = SwipeDirection.None;
		}else if (SwipeManager.Instance.IsSwiping(SwipeDirection.Right) && lerpFlag==false){
			//Debug.Log ("RIGHT");
			ScrollLeft();
			SwipeManager.Instance.Direction = SwipeDirection.None;
		}
	}

	private void FixedUpdate(){
		if (lerpFlag) {
			time += Time.deltaTime;
			float normalisedTime = time / scrollTime;

			if (time > scrollTime) {
				time = 0.0f;
				lerpFlag = false;
				normalisedTime = 1.0f;
			}
			contentObj.transform.position = Vector3.Lerp (currentPosition, targetPosition, normalisedTime);
		}
	}

	private void ScrollLeft(){
		if (imageCounter < imageTotal) {
			currentPosition = new Vector3 (imageCounter * scrollIncrement, 0, 0);
			imageCounter++;
			targetPosition = new Vector3 (imageCounter * scrollIncrement, 0, 0);
			dotObj.UpdateDot (imageCounter);
			lerpFlag = true;
		}
	}

	private void ScrollRight(){
		if (imageCounter > 0) {
			currentPosition = new Vector3 (imageCounter * scrollIncrement, 0, 0);
			imageCounter--;
			targetPosition = new Vector3 (imageCounter * scrollIncrement, 0, 0);
			dotObj.UpdateDot (imageCounter);
			lerpFlag = true;
		}
	}


}
