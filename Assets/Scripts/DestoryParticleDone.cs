using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryParticleDone : MonoBehaviour {
    private ParticleSystem ps;

	// Use this for initialization
	void Start () {
        ps = gameObject.GetComponent<ParticleSystem>();
        //TODO destroy when done
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
