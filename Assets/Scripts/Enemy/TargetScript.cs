using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour {

    public NavMeshAgent navAgent;
    public GameObject Crystal;
    public float CurHP = 100;

	// Use this for initialization
	void Start () {
        navAgent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
        navAgent.destination = Crystal.transform.position;
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Crystal")
        {
            SceneManager.LoadScene("Lost");
        }
    }

    public void TakeDamage(float damage) {
        CurHP = CurHP - damage;
        print(CurHP);
        if(CurHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
