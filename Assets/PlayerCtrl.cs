using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	public float speed;
	public float jumpVelocity;
	public float nb_jumps_max;
	float nb_jumps = 0;
	bool can_jump = true;
	bool grounded = true;


	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		float move = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (speed*move,rb.velocity.y);

		// let's make the jumps :)
		can_jump = grounded || nb_jumps < nb_jumps_max;


		if (Input.GetButtonDown ("Jump") && can_jump){
			rb.velocity = Vector2.up*jumpVelocity;
			nb_jumps ++;
			grounded = false;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
	        if(coll.gameObject.tag == "Ground"){
						grounded = true;
						nb_jumps=0;
					}
	}

	void FixedUpdate(){

	}
}
