using UnityEngine;
using System.Collections;

public class PriestSpawnerScript : MonoBehaviour {
    public float spawnDelay = 10f;
    public float timer = 0;
    public TargetScript Priest;
    public GameObject Crystal;
    public float negSpawnDelay = 0f;
    public float MaxSpawntime = 0.5f;
    public int SpawnCount = 0;
    public float x = 0;
    public float y = 0;
    public float z = 0;

    // Use this for initialization
    void Start () {
        negSpawnDelay = spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= spawnDelay && timer >= MaxSpawntime)
        {
            spawn();
            timer = 0;
            spawnDelay = negSpawnDelay - (SpawnCount * x + Mathf.Sin(SpawnCount * y) * z);
            SpawnCount++;
        }
        else
        {
            timer += Time.deltaTime;
        }
	}
    public void spawn()
    {
        TargetScript newPriest = Instantiate(Priest);
        newPriest.transform.position = transform.position;
        newPriest.Crystal = Crystal;
    }
}
