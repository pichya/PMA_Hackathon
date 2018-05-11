using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
	public GameObject m_Animator;

	void Awake()
	{
		//Get the animator, attached to the GameObject you are intending to animate.
		m_Animator.GetComponent<Animator>().speed = 0.8f;
	}
		
}