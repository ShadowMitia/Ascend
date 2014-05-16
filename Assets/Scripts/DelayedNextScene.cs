using UnityEngine;
using System.Collections;

public class DelayedNextScene : MonoBehaviour {
  private float now;
  public Texture2D texture;

	public SceneFadeInOut other;

	// Use this for initialization
	void Start () {
    	now = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
    if (Time.time - now > 3 || Input.GetKeyDown("space"))
      {
			other.EndScene();
      }
	}
}

