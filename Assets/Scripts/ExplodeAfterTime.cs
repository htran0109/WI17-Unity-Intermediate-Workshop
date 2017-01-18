using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeAfterTime : MonoBehaviour {

    public GameObject explosion;

    public float fusetime = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SetFuse()
    {
        yield return new WaitForSeconds(fusetime);
        Instantiate(explosion, transform.position, Quaternion.identity);

        Destroy(gameObject);

    }
}
