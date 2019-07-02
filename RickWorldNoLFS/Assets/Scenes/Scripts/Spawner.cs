using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform startPoint;
    public GameObject spawn;
    public float spawnTime;
    public float spawnDelay;
    public float xRangeMinus;
    public float xRangePlus;
    public float zRangeMinus;
    public float zRangePlus;

    void Start()
    {
        InvokeRepeating("Spawnee", spawnTime, spawnDelay);
    }

    public void Spawnee()
    {
        Instantiate(spawn, new Vector3(Random.Range((startPoint.position.x + xRangeMinus), (startPoint.position.x + xRangePlus)), startPoint.position.y, Random.Range((startPoint.position.z + zRangeMinus), (startPoint.position.z + zRangePlus))), transform.rotation);
    }
}
