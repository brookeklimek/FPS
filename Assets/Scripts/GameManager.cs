using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static int shots = 0;
	public static int hits = 0;

	public GameObject scoreCanvas;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		if (shots > 0) {
			scoreCanvas.SetActive (true);
			float hitPct = hits / (float)shots * 100;
			hitPct = Mathf.RoundToInt (hitPct);
			scoreText.text = hits + " / " + shots + " : " + hitPct + "%";
		} else {
			scoreCanvas.SetActive (false);
		}
	}
}
