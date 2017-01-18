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
			Debug.DrawRay(transform.position, camera.transform.forward * 50, Color.red, 1);
            if(Physics.Raycast(transform.position, camera.transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Shootable")
                {
                    hit.transform.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(camera.transform.forward * force, hit.point);
                    //TODO start coroutine for explosion SetFuse
                }
            }
        }
		
	}
}
