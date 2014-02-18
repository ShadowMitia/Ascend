using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {

	public int currentSelection = 0;
	public int numberCharactersLevel = 1;
	private GameObject character;
	
	void Awake(){
		character = GameObject.Find("Greg");
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		
		if (Input.GetKeyDown ("1")) {
			character = GameObject.Find("Greg");
			currentSelection = 0;
			Debug.Log ("Greg");
		} else if (Input.GetKeyDown ("2") && numberCharactersLevel > 1) {
			character = GameObject.Find("Paolo");
			currentSelection = 1;
			Debug.Log ("Paolo");
			
		} else if (Input.GetKeyUp ("3") && numberCharactersLevel > 2) {
			character = GameObject.Find ("Bob");
			currentSelection = 2;
			Debug.Log ("Bob");

		} 
		
		GameObject[] chars = GameObject.FindGameObjectsWithTag ("Player");
		foreach (var element in chars) {
			element.GetComponent<PlayerControl>().currentCharacter = false;
		}
		character.GetComponent<PlayerControl> ().currentCharacter = true;
    
  }
  
}
