﻿using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {
	
	private int numberCharactersLevel;
	private GameObject character;
	
	void Awake(){

	}
	
	// Use this for initialization
	void Start () {
		character = GameObject.FindGameObjectsWithTag("Player")[0];
		foreach (GameObject element in GameObject.FindGameObjectsWithTag("Player")){
			Debug.Log(element);
		}
		Debug.Log ("Current character: " + character);
		character.GetComponent<PlayerControl> ().currentCharacter = true;
		numberCharactersLevel = GameObject.FindGameObjectsWithTag ("Player").Length;
		Debug.Log ("Number of players: " + numberCharactersLevel);
	}

	public GUIText controlledCharacterText;

	// Update is called once per frame

	void Update () {
		if (Input.GetKeyDown ("1") && GameObject.Find ("Greg") && numberCharactersLevel > 1) {
			character.GetComponent<PlayerControl>().currentCharacter = false;
			character.GetComponent<SpriteRenderer>().color = Color.gray;
			character = GameObject.Find("Greg");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			character.GetComponent<SpriteRenderer>().color = Color.clear;
			//currentSelection = 0;
			Debug.Log ("Greg");
		} else if (Input.GetKeyDown ("2") && GameObject.Find ("Paolo") && numberCharactersLevel > 1) {
			character.GetComponent<PlayerControl>().currentCharacter = false;
			character.GetComponent<SpriteRenderer>().color = Color.gray;
			character = GameObject.Find("Paolo");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			character.GetComponent<SpriteRenderer>().color = Color.clear;
			//currentSelection = 1;
			Debug.Log ("Paolo");
			
		} else if (Input.GetKeyUp ("3") && GameObject.Find("Bob") && numberCharactersLevel > 1) {
			character.GetComponent<SpriteRenderer>().color = Color.gray;
			character.GetComponent<PlayerControl>().currentCharacter = false;
			character = GameObject.Find ("Bob");
			character.GetComponent<PlayerControl>().currentCharacter = true;
			character.GetComponent<SpriteRenderer>().color = Color.clear;
			//currentSelection = 2;
			Debug.Log ("Bob");

		}
		controlledCharacterText.text = gameObject.name;
  }
  
}
