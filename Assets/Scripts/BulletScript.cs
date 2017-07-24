using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletScript : MonoBehaviour {

    // Values
    public Vector2 initialVelocity;
    public Rigidbody myRigidbody;
    public float lifeTime = 10;
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
    myRigidbody.velocity = transform.forward * initialVelocity.x + transform.up * initialVelocity.y;
        Destroy(gameObject, lifeTime);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
   
}
