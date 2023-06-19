using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour {

	[SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;

	void Awake () {
		Debug.Log(DateTime.Now);
		hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
	}
}