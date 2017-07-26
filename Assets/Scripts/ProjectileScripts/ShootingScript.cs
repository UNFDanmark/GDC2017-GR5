using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
    public KeyCode testButton1 = KeyCode.R;
    public KeyCode testButton2 = KeyCode.T;
    public KeyCode testButton3 = KeyCode.Y;
    public float timeOfLastShot = 0;
    public float reloadTime = 2;
    public GameObject Bullet;
    public GameObject Ice;
    public CameraScript place;
    public GameObject Stone;
    int BulletCount = 10;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Command
        if (Input.GetMouseButtonDown(0) && (Time.time - timeOfLastShot) >= reloadTime && place.placement == 0)
      //  if (Input.GetKeyDown(testButton1) && (Time.time - timeOfLastShot) >= reloadTime)
        {
            Shoot1();
        }
        else if (Input.GetMouseButtonDown(0) && (Time.time - timeOfLastShot) >= reloadTime && place.placement == 1)
        {
            Shoot2();
        }
        else if (Input.GetMouseButtonDown(0) && (Time.time - timeOfLastShot) >= reloadTime && place.placement == 2)
        {
            Shoot3();
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

    public void Shoot3()
    {
for (int i = 0; i < BulletCount; i++)
        {
            timeOfLastShot = Time.time;
            GameObject newBullet = Instantiate(Stone);

            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
        }
    }
}
