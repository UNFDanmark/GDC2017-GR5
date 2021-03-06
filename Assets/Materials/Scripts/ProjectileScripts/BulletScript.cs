﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BulletScript : MonoBehaviour {

    // Values
    public Vector2 initialVelocity;
    public Rigidbody myRigidbody;
    public float lifeTime = 10;
    public float damage = 25;
    void Awake()
    {
        // Rigidbody
        myRigidbody = GetComponent<Rigidbody>();
        
    }

    // Use this for initialization
    void Start () {
        // Movement
    myRigidbody.velocity = transform.forward * initialVelocity.x + transform.up * initialVelocity.y;
        Destroy(gameObject, lifeTime);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    // Destroy / kill
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
          
            other.GetComponent<TargetScript>().TakeDamage(damage);
        
            
        }
    }
   
}
