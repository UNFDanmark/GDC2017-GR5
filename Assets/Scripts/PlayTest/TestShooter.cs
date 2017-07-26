using UnityEngine;
using System.Collections;

public class TestShooter : MonoBehaviour {
    public KeyCode testButton1 = KeyCode.R;
    public KeyCode testButton2 = KeyCode.T;
    public KeyCode testButton3 = KeyCode.Y;
    public float timeOfLastShot = 0;
    public float reloadTime = 2;
    public GameObject Bullet;
    public GameObject Ice;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Command
        //if (Input.GetMouseButtonDown(0) && (Time.time - timeOfLastShot) >= reloadTime)
        if (Input.GetKeyDown(testButton1) && (Time.time - timeOfLastShot) >= reloadTime)
        {
            Shoot1();
        }
        if (Input.GetKeyDown(testButton2) && (Time.time - timeOfLastShot) >= reloadTime)
        {
            Shoot2();
        }
    }
    // Shoot
    public void Shoot1()
    {
        timeOfLastShot = Time.time;
        GameObject newBullet = Instantiate(Bullet);


        newBullet.transform.position = transform.position;
        newBullet.transform.rotation = transform.rotation;
    }
    public void Shoot2()
    {
        timeOfLastShot = Time.time;
        GameObject newBullet = Instantiate(Ice);

        newBullet.transform.position = transform.position;
        newBullet.transform.rotation = transform.rotation;
    }
}
