using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		// simple rotation character.
		transform.Rotate(0, 1, 0);
	}
}
