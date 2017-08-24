using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportToGreen : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision) {
        player.transform.position = new Vector3(20, -8, 1);
    }
}
