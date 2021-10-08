using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbox : MonoBehaviour
{
    public GameObject boxSpawn;
    public float range;

    public int repeattime;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", time, repeattime);
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-range, range);
        float y = Random.Range(-range, range);

        return new Vector2(x, y);
    }

    void SpawnObject()
    {
        Instantiate(boxSpawn, GetSpawnPoint(), Quaternion.identity, transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
