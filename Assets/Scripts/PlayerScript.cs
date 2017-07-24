using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    public Rigidbody myRigidbody;
    public float rotationspeed = 20f;
    // Use this for initialization
    void Awake()
    {
        myRigidbody = GetComponent <Rigidbody>();
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationspeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        transform.Rotate(rotationspeed * Time.deltaTime * Input.GetAxis("Vertical"), 0, 0);
	}
}
