using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float walkSpeed = 10f;
    public float sprintSpeed = 20f;
    public float jumpForce = 300f;
    public Rigidbody rb;
    float movementSpeed = 10f;
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

        if (Input.GetKey(KeyCode.LeftShift) == true || Input.GetKey(KeyCode.RightShift) == true) {
            movementSpeed = sprintSpeed;
        } else {
            movementSpeed = walkSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround()) {
            rb.AddForce(new Vector3(0,jumpForce,0));
        }

    }

    bool onGround() {
        return Physics.Raycast(transform.position, -Vector3.up, 1.5f); ;
    }

}
