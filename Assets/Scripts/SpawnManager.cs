using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float xRange = 9.8f;
    private float zRange = 30;
    public float spawnDelay;
    public float spawnInterval;


    // Start is called before the first frame update
    void Start()
    {   
        //Spawning animals with a delay and at intervals on launch
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn animal method
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(xRange,-xRange), 0, zRange);

        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
}
