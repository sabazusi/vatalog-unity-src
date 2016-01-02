using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0))
	//	if (Input.touchCount > 0)
		{
			Application.LoadLevel("main");
		}
	}
}
