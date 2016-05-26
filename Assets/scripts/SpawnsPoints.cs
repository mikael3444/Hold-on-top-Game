using UnityEngine;
using System.Collections;

public class SpawnsPoints : MonoBehaviour {

    public GameObject enemy;
    public float spawnTime;
    public Transform[] spawnPoint;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    public void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);

        Instantiate(enemy, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
    }
}
