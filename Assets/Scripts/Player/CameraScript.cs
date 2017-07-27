using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
    public KeyCode testButton = KeyCode.J;
    public Rigidbody CamRigid;
    public float towerX1 = 0;
    public float towerX2 = 0;
    public float towerX3 = 0;
    public float towerY1 = 0;
    public float towerY2 = 0;
    public float towerY3 = 0;
    public float towerZ1 = 0;
    public float towerZ2 = 0;
    public float towerZ3 = 0;
    public float placement = 0;

    void awake()
    {
        CamRigid = GetComponent<Rigidbody>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1) && (placement == 0))
        {
            transform.position = new Vector3 (towerX1, towerY1, towerZ1);
            print("test 3.1");
            placement = 1;
        }
        else if (Input.GetMouseButtonDown(1) && (placement == 1))
        {
            transform.position = new Vector3(towerX2, towerY2, towerZ2);
            print("test 3.2");
            placement = 2;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            transform.position = new Vector3(towerX3, towerY3, towerZ3);
            print("test 3.3");
        
            placement = 0;
        }
        else
        {
        }

    }
}
