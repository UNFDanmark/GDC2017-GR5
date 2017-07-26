using UnityEngine;
using System.Collections;

public class PriestSpawnerScript : MonoBehaviour {
    public float spawnDelay = 10f;
    public float timer = 0;
    public TargetScript Priest;
    public GameObject Crystal;
    public float negSpawnDelay = 0.1f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(timer >= spawnDelay)
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
        TargetScript newPriest = Instantiate(Priest);
        newPriest.transform.position = transform.position;
        newPriest.Crystal = Crystal;
    }
}
