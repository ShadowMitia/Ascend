 using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	public string nextScene;
	public Font font;
	public Sprite image;

	// Use this for initialization
	void Start () {
	}

	void OnGUI() {
		/*
		GUI.backgroundColor = Color.clear;
		if (GUILayout.Button ( image.texture ) {
			Application.LoadLevel (nextScene);
		}
		*/

		/*
		GUI.backgroundColor = Color.clear;
		GUILayout.BeginArea(new Rect(Screen.width / 2 - Screen.width * 0.4f / 2,Screen.height / 2, Screen.width * 0.4f,Screen.height));
		{
			GUILayout.BeginVertical(); // also can put width in here
			{

			//	GUILayout.Label("some text");
			//	GUILayout.Label("some text");

		if (GUILayout.Button(image.texture)) // also can put width here
				{
					Application.LoadLevel(nextScene);
				}
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndArea();
		*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
