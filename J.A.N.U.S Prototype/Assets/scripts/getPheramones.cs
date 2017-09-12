using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPheramones : MonoBehaviour {

    public GameObject wall;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision) {
        Destroy(wall);
        Destroy(this.gameObject);
    }
}
