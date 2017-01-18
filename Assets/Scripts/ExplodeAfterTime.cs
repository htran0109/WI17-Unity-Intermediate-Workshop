using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeAfterTime : MonoBehaviour {
	public GameObject explosion = null;
    public float fusetime = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator SetFuse() {
        //TODO create explosion prefab after some time
        Destroy(gameObject);
    }
}
