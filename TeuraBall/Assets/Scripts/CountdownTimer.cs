using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	float currentTime=0f;
	float startingTime=120f;

	[SerializeField] Text countdownText;

	void Start() {
		//postavljanje vremena na 120 sekundi
		currentTime = startingTime;
	}

	void Update() {
		//odbrojavanje
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = "Vrijeme: " + currentTime.ToString("0");

		//ukoliko vrijeme dođe do 0, odnosno istekne, igra je gotova
		if (currentTime <= 0) {
			currentTime = 0;
			Application.LoadLevel("Lose");
		}
	}
}
