using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float movementSpeed = 1f;
    public GameObject cam;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        move();
        
	}

    void move() {

        if (Input.GetKey(KeyCode.W) == true) {
            float camRotation = cam.transform.rotation.y;
            transform.Rotate(0, camRotation, 0);
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.S) == true) {
            float camRotation = cam.transform.rotation.y;
            transform.Rotate(0, camRotation, 0);
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.A) == true) {
            float camRotation = cam.transform.rotation.y;
            transform.Rotate(0, camRotation, 0);
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D) == true) {
            float camRotation = cam.transform.rotation.y;
            transform.Rotate(0, camRotation, 0);
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }

    }
}
