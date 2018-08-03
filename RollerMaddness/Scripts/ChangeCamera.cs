using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Boo.Lang;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

	public Camera MainCamera;
	public Camera SecondaryCamera;

	void Start()
	{
		MainCamera.enabled = true;
		SecondaryCamera.enabled = false;	
	}
	
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player")
		{
			SecondaryCamera.enabled = true;	
			MainCamera.enabled = false;
		}
	}

}
	
