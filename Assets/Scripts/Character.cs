using UnityEngine;
using System.Collections;


[RequireComponent (typeof(Animator))]

public class Character : MonoBehaviour
{

		public bool grounded;
		public bool jump;
		public float speed;
		public bool climb;
		public bool selected;

		private Animator anim;
		public LayerMask whatIsGround;

		private Transform groundCheck;
		public float groundCheckRadius;

		void Awake ()
		{

		}

		// Use this for initialization
		void Start ()
		{
				anim = this.GetComponent<Animator> ();
				grounded = false;
				jump = false;
				speed = 0.0f;
				climb = false;
				selected = false;
				groundCheck = transform.Find ("GroundCheck");
				groundCheckRadius = 10.0f;
		}
	
		// Update is called once per frame
		void Update ()
		{
				speed = CrossPlatformInput.GetAxis ("Horizontal");

				// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
				bool g = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
				anim.SetBool ("Ground", g);

				if (selected) {
						anim.SetBool ("Selected", true);
				} else {
						anim.SetBool ("Selected", false);
				}
				if (grounded == true) {
						anim.SetBool ("Ground", true);
				} else {
						anim.SetBool ("Ground", false);
				}

				if (jump == true) {
						anim.SetBool ("Jump", true);
				} else {
						anim.SetBool ("Jump", false);
				}

				anim.SetFloat ("Speed", speed);
		}
}
