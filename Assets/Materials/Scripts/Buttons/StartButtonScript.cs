﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Tourturial()
    {
        SceneManager.LoadScene("Tourturial");
    }
}
