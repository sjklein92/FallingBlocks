﻿using UnityEngine;
using System.Collections;

public class Mover_rb : MonoBehaviour {

	public Rigidbody rb;
	public float speed;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		//rb.velocity = transform.forward*speed;
	}

    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
