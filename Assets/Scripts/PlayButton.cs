using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	public float x;
	public float y;
	public float h;
	public float w;
	Transform trans;
	public Texture texture;
	Rect pos;
	// Use this for initialization
	void Start () {

	}

	void OnGUI() {
		pos.x = x;
		pos.y = y;
		pos.height = h;
		pos.width = w;
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (pos, texture)) {
			Application.LoadLevel ("TestLevel");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
