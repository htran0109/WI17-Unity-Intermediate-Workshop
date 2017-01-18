using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInBox : MonoBehaviour {

    public GameObject prefab;
    public float timeBetweenSpawn = 2.0f;

    private BoxCollider box;

	// Use this for initialization
	void Start () {
        box = gameObject.GetComponent<BoxCollider>();
        StartCoroutine("SpawnOverTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnOverTime() {
		while(true) {
            SpawnRandom();
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }

    void SpawnRandom() {
        Bounds bounds = box.bounds;
        float x = Random.Range(box.bounds.min.x, box.bounds.max.x);
        Debug.Log("x: " + x);
        float y = Random.Range(box.bounds.min.y, box.bounds.max.y);
        float z = Random.Range(box.bounds.min.z, box.bounds.max.z);

        if(prefab != null)
        {
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
        }

        //bounds.min 
        //Instantiate(prefab, );
    }
}
