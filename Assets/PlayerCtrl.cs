using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	public float speed;
	public float jumpVelocity;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (speed*move,rb.velocity.y);
		if (Input.GetButtonDown ("Jump")){
			rb.velocity = Vector2.up*jumpVelocity;
		}

	}

	void FixedUpdate(){

	}
}
