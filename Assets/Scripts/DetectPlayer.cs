using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour {

	internal bool playerInRange;

	void Start () {

		playerInRange = false;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			playerInRange = true;
			Debug.Log ("player detected");
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			playerInRange = false;
			Debug.Log ("player exit");

		}
	}
}
