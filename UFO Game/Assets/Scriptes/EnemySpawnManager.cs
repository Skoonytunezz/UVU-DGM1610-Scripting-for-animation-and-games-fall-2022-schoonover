using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public float spawnRangeX;
    public float spawnPosZ;
     
    private float startDelay = 2f;
    private float spawnInterval = 2f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        // generate a position to spawn at
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        // pick a random enemy from the array
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        // spawn the enemy indexed from array
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

    }
}
