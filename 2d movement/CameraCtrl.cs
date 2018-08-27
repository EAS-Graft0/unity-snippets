using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

    public GameObject Player;

    private Vector3 Offset;

	// Use this for initialization
	void Start () { //without specifying an object before transform is uses 'this' which is the game oject it's attached too.
        Offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Player.transform.position + Offset;
	}
}
