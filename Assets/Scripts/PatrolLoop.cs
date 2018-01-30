using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolLoop : MonoBehaviour {

	public float speed;
	private Vector3 pivot; 

	void Update () {
		pivot = new Vector3 (0, 30, 0);
		transform.RotateAround(pivot, Vector3.up, speed * Time.deltaTime);
	}
}