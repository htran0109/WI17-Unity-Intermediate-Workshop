using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {
	public string levelName = "Main";

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel(levelName);
	}
}
