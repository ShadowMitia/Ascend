using UnityEngine;
using System.Collections;


public class CharacterSelector : MonoBehaviour
{

		private GameObject[] characters;
		private int currentSelection = 0;
		private bool playerChanged = false;
	

		// Use this for initialization
		void Start ()
		{
				characters = new GameObject[3];
				GameObject[] tmp = new GameObject[3];
				tmp = GameObject.FindGameObjectsWithTag ("Player");
				foreach (GameObject element in tmp) {
						Debug.Log ("Found: " + element.name);
						if (element.name == "Greg") {
								characters [0] = element;
						} else if (element.name == "Bob") {
								characters [1] = element;
						} else if (element.name == "Paolo") {
								characters [2] = element;
						}
				}
				currentSelection = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
						
				//Debug.Log ("Currently using: " + characters [currentSelection].name);
				if (CrossPlatformInput.GetButtonDown ("1")) {
						characters [currentSelection].GetComponent<Character> ().selected = false;
						currentSelection = 0;
						playerChanged = true;
				}

				if (CrossPlatformInput.GetButtonDown ("2")) {
						characters [currentSelection].GetComponent<Character> ().selected = false;
						currentSelection = 1;
						playerChanged = true;
				}

				if (CrossPlatformInput.GetButtonDown ("3")) {
						characters [currentSelection].GetComponent<Character> ().selected = false;
						currentSelection = 2;
						playerChanged = true;
				}

				if (playerChanged) {
						characters [currentSelection].GetComponent<Character> ().selected = true;
				}
				
		}
}
