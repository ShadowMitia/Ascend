using UnityEngine;
using System.Collections;

public class PlatformCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name  == "Paolo" && transform.parent.gameObject.GetComponent<Platforms>().fixedPlatform == false) {
						transform.parent.gameObject.GetComponent<Platforms> ().fixedPlatform = true;
						Debug.Log ("Platform fixed");
				} else {

						other.collider2D.gameObject.transform.parent = transform;
				}
	}

	void OnTriggerExit2D(Collider2D other){

		if (other.gameObject.name == "Paolo" && transform.parent.GetComponent<Platforms> ().fixedPlatform == true) {
						transform.parent.gameObject.GetComponent<Platforms> ().fixedPlatform = false;
						Debug.Log ("Platform unfixed");
				} else {
						other.collider2D.gameObject.transform.parent = null;
				}
	}



}
