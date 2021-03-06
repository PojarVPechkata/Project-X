﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 10.0f;
	public float rotateSpeed = 5.0f;
	public float sprintSpeed = 15.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Debug.Log(Input.GetAxis("Jump"));
			Debug.Log ("Pressing Space Key");
		}
		if (Input.GetKey("left shift") && Input.GetKey("w")) {
			transform.Translate (Vector3.forward * sprintSpeed * Time.deltaTime);
		}else if (Input.GetKey ("w")) {
			transform.Translate ((Vector3.forward) * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey ("s")) {
			transform.Translate ((Vector3.back) * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey ("a")) {
			transform.Rotate (Vector3.down * rotateSpeed);
			//transform.Translate ((Vector3.left) * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey ("d")) {
			transform.Rotate (Vector3.up * rotateSpeed);
			//transform.Translate (Vector3.Normalize(Vector3.right) * moveSpeed * Time.deltaTime);
		}

		if (Input.GetMouseButton (0)) {
			
			Debug.Log ("Mouse button 1");
		}
			
		if (Input.GetMouseButton (1)) {
			Debug.Log ("Mouse button 2");
		}
	}
}
