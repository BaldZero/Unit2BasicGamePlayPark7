using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] vertanimalprefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float spawnRangeZ = 15f;
    private float spawnRangeZ2 = 3f;
    private float spawnPosX = 15;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnRandomAnimal()
    {
        //Spawns animals randomly

        int aniIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int vertaniIndex = Random.Range(0,vertanimalprefabs.Length);
        Vector3 spawnPosHorizontal = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZ2, spawnRangeZ));

        Instantiate(animalPrefabs[aniIndex], spawnPos,
        animalPrefabs[aniIndex].transform.rotation);

        Instantiate(animalPrefabs[vertaniIndex], spawnPosHorizontal);
        
    }
}
