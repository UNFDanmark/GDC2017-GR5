using UnityEngine;
using System.Collections;

public class KnightSpawner : MonoBehaviour {

    public float spawnDelay = 10f;
    public float timer = 0;
    public TargetScript Knight;
    public GameObject Crystal;
    public float negSpawnDelay = 0.1f;
    //public AnimationCurve lol;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnDelay)
        {
            spawn();
            timer = 0;
            spawnDelay = spawnDelay - negSpawnDelay;
        }
        else
        {
            timer = timer + (1 * Time.deltaTime);
        }
    }
    public void spawn()
    {
        TargetScript newKnight = Instantiate(Knight);
        newKnight.transform.position = transform.position;
        newKnight.Crystal = Crystal;
    }
}