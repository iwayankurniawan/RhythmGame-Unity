﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton3 : MonoBehaviour {

	public static bool value = false;

	void OnMouseDown(){

		value = true;
		GetComponent<Transform> ().localScale = new Vector3 (20, 20, 1);
	}

	void OnMouseUp () {
		GetComponent<Transform> ().localScale = new Vector3 (22, 22, 1);
		value = false;
	}
}
