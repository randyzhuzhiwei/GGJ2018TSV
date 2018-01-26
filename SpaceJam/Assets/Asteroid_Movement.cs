using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Movement : MonoBehaviour {

    public float thrust;
    public float speed;
    public Rigidbody2D rb;

    private Vector3 startDirection;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        startDirection = transform.up;
    }
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(startDirection * thrust);
       // rb.MoveRotation(rb.rotation + speed * Time.fixedDeltaTime);
    }
}
