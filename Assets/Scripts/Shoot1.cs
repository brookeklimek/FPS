﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shoot1 : MonoBehaviour {
	public GameObject projectile;
	public GameObject shotPoint;
	public float shotForce = 8.0f;
	public float shotTTL = 5.0f;
	public float rechargeTime = 2.2f;
	public float totalAmmo;

	public GameObject ammoCanvas;
	public Text ammoText;


	public AudioClip launchNoise;

	private float lastShotTime;

	void Start () { 
		if (totalAmmo > 0) {
			ammoCanvas.SetActive (true);
			ammoText.text = "" + totalAmmo;
		}
		else {
			ammoCanvas.SetActive (false);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Fire1") > 0 && Time.time > lastShotTime + rechargeTime && totalAmmo > 0) {
			Shoot ();
		}
	}

	void Shoot () {
		GameManager.shots++;

		lastShotTime = Time.time;

		if (launchNoise != null) {
			AudioSource.PlayClipAtPoint (launchNoise, shotPoint.transform.position, 1.0f);
		}

		GameObject newshot = Object.Instantiate (projectile, 
			shotPoint.transform.position, 
			this.transform.rotation);
		
		newshot.GetComponent<Rigidbody>().AddForce(transform.up * shotForce, ForceMode.Impulse);

		Object.Destroy (newshot, shotTTL);
		DecreaseAmmo ();
	}

	void DecreaseAmmo () {
		totalAmmo--;

		if (totalAmmo >= 0) {
			ammoText.text = "" + totalAmmo;
		}
		else {
			ammoCanvas.SetActive (false);
		}
	}


}