using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursor : MonoBehaviour {

    public Texture2D myszka;
    public CursorMode cursor = CursorMode.Auto;
    public Vector2 v = Vector2.zero;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(myszka, v, cursor);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
