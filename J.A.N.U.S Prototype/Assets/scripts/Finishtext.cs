using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishtext : MonoBehaviour {

    public Canvas canvas;

	// Use this for initialization
	void Start () {
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision) {
        canvas.enabled = true;
    }

}
