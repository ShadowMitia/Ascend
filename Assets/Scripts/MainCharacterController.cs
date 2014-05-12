using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {

	public int currentSelection = 0;
	private int numberCharactersLevel;
	private GameObject character;
	
	void Awake(){

	}
	
	// Use this for initialization
	void Start () {
		controlledCharacterText.text = "Greg";
		character = GameObject.Find("Greg");
		character.GetComponent<PlayerControl> ().currentCharacter = true;
		numberCharactersLevel = GameObject.FindGameObjectsWithTag ("Player").Length;
		Debug.Log ("Number of players: " + numberCharactersLevel);
	}

	public GUIText controlledCharacterText;

	// Update is called once per frame

	void Update () {
		
		if (Input.GetKeyDown ("1")) {
			character.GetComponent<PlayerControl>().currentCharacter = false;
			character = GameObject.Find("Greg");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			controlledCharacterText.text = "Greg";
			currentSelection = 0;
			Debug.Log ("Greg");
		} else if (Input.GetKeyDown ("2") && numberCharactersLevel > 1) {
			character.GetComponent<PlayerControl>().currentCharacter = false;
			character = GameObject.Find("Paolo");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			controlledCharacterText.text = "Paolo";
			currentSelection = 1;
			Debug.Log ("Paolo");
			
		} else if (Input.GetKeyUp ("3") && numberCharactersLevel > 2) {
			character.GetComponent<PlayerControl>().currentCharacter = false;
			controlledCharacterText.text = "Bob";
			character = GameObject.Find ("Bob");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			currentSelection = 2;
			Debug.Log ("Bob");

		} 
  }
  
}
