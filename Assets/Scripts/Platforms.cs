﻿using UnityEngine;
using System.Collections;

public class Platforms : MonoBehaviour {

    public bool goesUp = false;
    protected int currentDistance;
    public int distanceMax;
    public float speed;
    public bool fixedPlatform = true;
    protected bool goesPositive = false;
    protected Transform pos;
	protected Transform originalPos;
	public bool stopped = false;


    // Use this for initialization
    void Start () {
        pos = GetComponent<Transform>();
		originalPos = GetComponent<Transform> ();
        currentDistance = 0;
    }

	/*
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.collider.name == "Paolo") {
			fixedPlatform = true;
			Debug.Log("FIXATION");
				}
		}


	void OnCollisionExit2D(Collision2D collision){
	if (collision.collider.name == "Paolo") {
		fixedPlatform = false;
			Debug.Log("PAAAS FIXATION");
	}
}
*/


    // Update is called once per frame
    void Update () {
    }


	void FixedUpdate(){

		if (fixedPlatform == false && stopped != true) {
			if (goesPositive) {
				currentDistance--;
			} else {
				currentDistance++;
			}
			
			if (currentDistance == 0){
				goesPositive = false;		
			} else if (currentDistance == distanceMax) {
				goesPositive = true;
			}

			if (goesUp){
				if (goesPositive){
					pos.position = new Vector3(pos.position.x , pos.position.y + speed *Time.deltaTime,pos.position.z) ;
				}
				else {
					pos.position = new Vector3(pos.position.x , pos.position.y - speed *Time.deltaTime,pos.position.z) ;
				}
			}
			else {
				if (goesPositive){
					pos.position = new Vector3(pos.position.x+ speed*Time.deltaTime , pos.position.y ,pos.position.z) ;
				}
				else {
					pos.position = new Vector3(pos.position.x  - speed *Time.deltaTime, pos.position.y,pos.position.z) ;
				}
			}
		}
	}



}
