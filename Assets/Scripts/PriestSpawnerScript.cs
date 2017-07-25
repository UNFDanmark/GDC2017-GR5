using UnityEngine;
using System.Collections;

public class PriestSpawnerScript : MonoBehaviour {
    public float spawnDelay = 10f;
    public float timer = 0;
    public GameObject Priest;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(timer >= spawnDelay)
        {
            spawn();
            timer = 0;
        }
        else
        {
            timer = timer + (1 * Time.deltaTime);
        }
	}
    public void spawn()
    {
        GameObject newPriest = Instantiate(Priest);
        newPriest.transform.position = transform.position;
    }
}
