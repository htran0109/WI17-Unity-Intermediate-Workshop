using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject camera = null;
    public float force = 10.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, camera.transform.forward, out hit, Mathf.Infinity))
            {
                Debug.Log("HIT " + hit.transform.gameObject.tag);
                if (hit.transform.gameObject.tag == "Shootable")
                {
                    
                    //hit.transform.gameObject.GetComponent<Rigidbody>().velocity = camera.transform.forward * force;
                    hit.transform.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(camera.transform.forward * force, hit.point);
                }
            }
        }
		
	}
}
