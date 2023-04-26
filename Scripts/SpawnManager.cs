using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs; 
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnRandomAnimals() {
        //randomly generate animal index and position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
