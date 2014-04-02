using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool currentlySelected = GameObject.FindGameObjectWithTag("Greg");
	private Rigidbody2D body;
	public int moveForce;
	public int jumpForce;
	private bool jump = false;


	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		if (currentlySelected == true) {
			float inputX = Input.GetAxis ("Horizontal");


			body.AddForce (new Vector2 (inputX * moveForce * rigidbody2D.mass, rigidbody2D.velocity.y));

			if (jump == true) {
				rigidbody2D.AddForce (new Vector2 (0f, jumpForce));
				jump = false;
			}
		}
	}
}
