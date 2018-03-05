using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour {
    public Rigidbody2D face;

	// Use this for initialization
	void Start ()
    {
        face = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
		
	}
}
