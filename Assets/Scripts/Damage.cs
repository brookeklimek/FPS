using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	// Barrel and drones use same script? 
	// if so then where to turn off gravity


	internal int health;
	// add canvas and text properties to this
	// add canvas and text to objects using damage script


	// Use this for initialization
	void Start () {
		health = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) { 
		gameObject.GetComponent<Rigidbody>().useGravity = true;

		if (other.CompareTag ("Hellwailer")) {
			
			if (health > 0) {
				health = health - 100;
				Debug.Log ("health decremented");

			}

			if (health <= 0) {
				Destroy (gameObject);
			}
		}

//		if (other.CompareTag ("Fire Sleet")) {
//			if (health > 0) {
//				health = health - 20;
//				Debug.Log ("health decremented");
//
//			}
//
//			if (health <= 0) {
//				Destroy (gameObject);
//			}
//		}

		if (other.CompareTag ("Archtronic")) {
			if (health > 0) {
				health = health - 35;
				Debug.Log ("health decremented");

			}
			if (health <= 0) {
				Destroy (gameObject);
			}

		}
	}
}
