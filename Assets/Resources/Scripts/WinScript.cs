﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("youWin");
        }
    }
}
