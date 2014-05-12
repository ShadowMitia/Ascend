using UnityEngine;
using System.Collections;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D other){
		Debug.Log ("Reset!");
		Application.LoadLevel(Application.loadedLevel);
	}
}
