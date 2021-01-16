using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float spawnXRange = 13.0f;
    public float spawnZPosition = 20.0f;

    private float startDelay = 2.0f;
    private float spwanInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spwanInterval);
    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}
    }

    private void SpawnRandomAnimal()
    {
        // Use Random.Range for getting a number between 0 and length of the array(animalPrefabs)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        float spawnXRangeRandom = Random.Range(-spawnXRange, spawnXRange);
        Vector3 spawnPosition = new Vector3(spawnXRangeRandom, 0.0f, spawnZPosition);

        Instantiate(animalPrefabs[animalIndex], spawnPosition,
                    animalPrefabs[animalIndex].transform.rotation);
    }
}
