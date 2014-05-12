using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	[HideInInspector]
	private bool facingRight = true;			// For determining which way the player is currently facing.
	[HideInInspector]
	public bool jump = false;				// Condition for whether the player should jump.

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 2f;				// The fastest the player can travel in the x axis.
	private float distToGround;
	public float jumpForce = 1000f;			// Amount of force added when the player jumps.
	public bool grounded = false;			// Whether or not the player is grounded.
	private Animator anim;					// Reference to the player's animator component.

	Vector2 frontLinecastEnd;
	RaycastHit2D frontHitInfo;
	[HideInInspector]
	public bool currentCharacter;

	void Awake()
	{

	}


	void Start(){
		currentCharacter = false;
		anim = GetComponent<Animator>();

	}



void OnGUI(){
	GUI.Box (new Rect (10,10,100,90), "Loader Menu");
}

	void Update(){
		transform.position = new Vector3 (transform.position.x, transform.position.y, 2);
		if (currentCharacter == true) {
			transform.position = new Vector3(transform.position.x, transform.position.y, 1);
			if (Input.GetButtonDown ("Jump") && grounded){
				jump = true;
			}
		}
	}


	void FixedUpdate (){
		if (currentCharacter == true) {
			// Cache the horizontal input.
			float h = Input.GetAxis ("Horizontal");

			anim.SetFloat ("Speed", Mathf.Abs (h));

			// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
			if (h * rigidbody2D.velocity.x < maxSpeed)
// ... add a force to the player.
					rigidbody2D.AddForce (Vector2.right * h * moveForce);

			// If the player's horizontal velocity is greater than the maxSpeed...
			if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
// ... set the player's velocity to the maxSpeed in the x axis.
					rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

			// If the input is moving the player right and the player is facing left...
			if (h > 0 && !facingRight)
					// ... flip the player.
					Flip ();
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (h < 0 && facingRight)
			// ... flip the player.
					Flip ();
			//If the player is falling
			if (!grounded) {
					anim.SetBool("Grounded", false);

			}
			// If the player should jump...
			if (jump) {
				Debug.Log("Jump!");
					grounded = false;
					// Set the Jump animator trigger parameter.
					anim.SetBool("Grounded", false);
					anim.SetBool ("Jump", true);

					// Play a random jump audio clip.
					//int i = Random.Range(0, jumpClips.Length);
					//AudioSource.PlayClipAtPoint(jumpClips[i], transform.position);

					// Add a vertical force to the player.
					rigidbody2D.AddForce (new Vector2 (0f, jumpForce));

					// Make sure the player can't jump again until the jump conditions from Update are satisfied.
					jump = false;


			}
			else{
				anim.SetBool ("Jump", false);
				if (!grounded){
					anim.SetBool("Fall", true);
				}else{
					anim.SetBool ("Fall", false);
				}
			}

		}
	}


	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "ground") {
						grounded = true;
						anim.SetBool ("Grounded", true);
				}
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnClimb()
	{
		rigidbody2D.isKinematic = true;
		transform.Translate (0, 100  * Time.deltaTime, 0);
		}

}

