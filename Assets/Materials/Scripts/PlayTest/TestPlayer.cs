﻿using UnityEngine;
using System.Collections;

public class TestPlayer : MonoBehaviour {

    //Values
    public Rigidbody myRigidbody;
    public float rotationspeed = 20f;
    public float timeOfLastShot = 0;
    public float reloadTime = 2;
    //public GameObject Bullet;
    public KeyCode testButton = KeyCode.T;

    // Use this for initialization
    void Awake()
    {
        // rigidbody
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // Cursor
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Look around
        transform.Rotate(0, rotationspeed * Time.deltaTime * Input.GetAxis("Mouse X"), 0, Space.World);
        transform.Rotate(rotationspeed * Time.deltaTime * Input.GetAxis("Mouse Y"), 0, 0);

        // Command
        //if (Input.GetMouseButtonDown(0) && (Time.time - timeOfLastShot) >= reloadTime)
        // if (Input.GetKeyDown(testButton) && (Time.time - timeOfLastShot) >= reloadTime)
        // {
        //Shoot();
        //}
    }
    // Shoot
    //public void Shoot()
    // {
    // timeOfLastShot = Time.time;
    // GameObject newBullet = Instantiate(Bullet);

    // newBullet.transform.position = transform.position;
    // newBullet.transform.rotation = transform.rotation;
    // }
}
