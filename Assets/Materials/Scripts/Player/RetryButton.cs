﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Restart()
    {
        SceneManager.LoadScene("Main Game");
    }
}
