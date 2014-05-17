using UnityEngine;
using System.Collections;

public class LadderExit : MonoBehaviour {

	public string nextLevel;
	public int delay = 2;
	float now;

	// Use this for initialization
	void Start () {
		now = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		other.gameObject.rigidbody2D.isKinematic = true;
		other.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		other.gameObject.transform.localScale = new Vector3(Mathf.Abs (other.gameObject.transform.localScale.x), other.gameObject.transform.localScale.y, other.gameObject.transform.localScale.y);
		other.gameObject.GetComponent<Animator> ().SetTrigger ("Climbing");

		if (Time.time - now > delay) {
			Application.LoadLevel(nextLevel);
		}
	}
}
