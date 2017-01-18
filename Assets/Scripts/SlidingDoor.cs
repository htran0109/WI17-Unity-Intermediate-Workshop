using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour {
	public GameObject door = null;
	public Vector3 direction = new Vector3(-1, 0, 0);
	public float distance = 2f;
	public float duration = 0.5f;

	private bool isOpen;
	private float startTime;
	private Vector3 closePosition;
	private Vector3 openPosition;
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		direction.Normalize();
		isOpen = false;
		closePosition = door.transform.position;
		openPosition = closePosition + (distance * direction);
		startPosition = closePosition;
	}

	// Update is called once per frame
	void Update () {
		float progress = (Time.time - startTime) / duration;

		if (isOpen) {
            //TODO lerp from startPosition to openPosition
		}
		else {
            //TODO lerp from startPosition to closePosition
        }
    }

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
            //TODO Update startPosition and starttime
			isOpen = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
            //TODO Update startPosition and starttime
            isOpen = false;
		}
	}
}
