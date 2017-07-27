using UnityEngine;
using System.Collections;

public class ShotgunShotScript : MonoBehaviour {


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
    void Start()
    {
        // Movement
        Vector3 myRotation = transform.rotation.eulerAngles;
        myRotation.x += Random.Range(-2f, 2f);
        myRotation.y += Random.Range(-2f, 2f);
        transform.rotation = Quaternion.Euler(myRotation);
      //  print(myRotation);

    myRigidbody.velocity = transform.forward * initialVelocity.x + transform.up * initialVelocity.y;
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Destroy / kill
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<TargetScript>().TakeDamage(damage);
            //Destroy(other.gameObject);
        }
    }
   
}
