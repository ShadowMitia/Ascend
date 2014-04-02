using UnityEngine;
using System.Collections;

public class ControlledPlatforms : Platforms {
	public GameObject platformController;
	// Use this for initialization
	void Start () {
	/*
		fixedPlatform = false;
		pos = GameObject.FindGameObjectWithTag("Greg").transform;
		*/

		if (platformController != null) {
			if (platformController.name == "Greg"){
				fixedPlatform = false;
			}
		} else {
			pos = GetComponent<Transform> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		pos = platformController.GetComponent<Transform> ();
				if (stopped != true) {
						if (goesPositive) {
								currentDistance--;
						} else { 
								currentDistance++;
						}
		
						if (currentDistance == 0) {
								goesPositive = false;		
						} else if (currentDistance == distanceMax) {
								goesPositive = true;
						}
		
						if (goesUp) {
								if (goesPositive) {
										transform.position = new Vector3 (pos.position.x, pos.position.y + speed * Time.deltaTime, pos.position.z);
								} else {
										transform.position = new Vector3 (pos.position.x, pos.position.y - speed * Time.deltaTime, pos.position.z);
								}
						} else {
								if (goesPositive) {
										transform.position = new Vector3 (pos.position.x + speed * Time.deltaTime, pos.position.y, pos.position.z);
								} else {
										transform.position = new Vector3 (pos.position.x - speed * Time.deltaTime, pos.position.y, pos.position.z);
								}
						}
				}
		}
}
