using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour {

    public NavMeshAgent navAgent;
    public GameObject Crystal;
    public float CurHP = 100;
    public Renderer rend;
    public float redDuration = 0.2f;
    float redTimer = 0.2f;
    bool isRed = false;
    public AudioSource DeathAudio;
    // Use this for initialization
    void Start () {
        navAgent = GetComponent<NavMeshAgent>();
        DeathAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update() {
        if (navAgent.enabled)
        {
            navAgent.destination = Crystal.transform.position;
        }

        if (isRed == true)
        {
            redTimer -= Time.deltaTime;
            if (redTimer <= 0)
            {
                isRed = false;
                redTimer = redDuration;
                rend.material.color = Color.white;
            }
        }

        if (CurHP <= 0 && !DeathAudio.isPlaying)
        {
            Destroy(gameObject);
        }
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
        if (CurHP > 0) {
            rend.material.color = new Color(0.5f, 0, 0, 1);
            isRed = true;
        }
        //rend.material.color = new Color(0.5f, 0, 0, 1);
        //isRed = true;

        if(CurHP <= 0)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            navAgent.enabled = false;
            DeathAudio.Play();
            //Destroy(gameObject);
           
        }
    }
}
