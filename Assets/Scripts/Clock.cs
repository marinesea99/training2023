using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour {

	[SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;

	const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

	void Awake () {
		DateTime time = DateTime.Now;
		hoursPivot.localRotation =
			Quaternion.Euler(0f, hoursToDegrees * time.Hour, 0f);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, minutesToDegrees * time.Minute, 0f);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, secondsToDegrees * time.Second, 0f);
	}

	void Update () {
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursPivot.localRotation =
			Quaternion.Euler(0f, hoursToDegrees * (float)time.TotalHours, 0f);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, minutesToDegrees * (float)time.TotalMinutes, 0f);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, secondsToDegrees * (float)time.TotalSeconds, 0f);
	}
}