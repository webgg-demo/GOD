﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private Rigidbody rig;
	private float speed = 2f;
	private float RotationSpeed = 100f;

	// Use this for initialization
	void Awake () {
		rig = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float rotation = Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime;
		Vector3 diffPos = new Vector3 (0, 0, -translation);

		transform.Translate(diffPos);
		transform.Rotate(Vector3.up, rotation);
	}
}
