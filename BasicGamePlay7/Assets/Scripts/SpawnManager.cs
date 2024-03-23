using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float spawnRangeZ = 15f;
    private float spawnRangeZ2 = 0f;
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
        Vector3 spawnPosHorizontal = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZ2, spawnRangeZ));
   
        Vector3 spawnPosHorizontal2 = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZ2, spawnRangeZ));
        

        Instantiate(animalPrefabs[aniIndex], spawnPos, animalPrefabs[aniIndex].transform.rotation);
        Instantiate(animalPrefabs[aniIndex], spawnPosHorizontal, Quaternion.Euler(0, 270, 0));
        Instantiate(animalPrefabs[aniIndex], spawnPosHorizontal2, Quaternion.Euler(0, 90, 0));

    }
}
