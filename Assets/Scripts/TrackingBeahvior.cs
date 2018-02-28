using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingBeahvior : MonoBehaviour {

	public float speed;
	private Transform target; 


	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	void Update () {
		TrackPlayer();
	}

	void TrackPlayer() {
		if (DetectPlayer.playerInRange) {
			Rigidbody rigidbody = GetComponent <Rigidbody> ();
			rigidbody.velocity = transform.forward * speed;

			//Vector3 targetDir = target.position - transform.position;
			float step = speed * Time.deltaTime;
			//Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

			//Debug.DrawRay(transform.position, newDir, Color.red);
			//transform.rotation = Quaternion.LookRotation(newDir);
		}
		else {
			return;
		}
	}
}
