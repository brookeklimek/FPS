using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingBeahvior : MonoBehaviour {

	public float speed;
	internal DetectPlayer playerDetection;
	private Transform target; 


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		TrackPlayer();
		
	}

	void TrackPlayer() {
		if (playerDetection.playerInRange) {
			Vector3 targetDir = target.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);

			Debug.DrawRay(transform.position, newDir, Color.red);
			transform.rotation = Quaternion.LookRotation(newDir);
		}
		else {
			return;
		}
	}
}
