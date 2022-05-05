using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab; // what prefab we are going to be spawning into the game
    public int spawnCount = 5; // how many of these spawnrefabs do we want to spawn in?
    public float spawnOffset = 1.5f; // the spawn offset that is going to be applied to each object. This will incrase their x position so they spawn within a line of each other.

    void Start() 
    {
        // we need to make sure that the spawnPrefab assigned before we spawn enemies. Otherwise return an error.
        if (spawnPrefab != null) 
        {
            SpawnEnemies();
        }
        else
        {
            Debug.LogError("Cannot spawn enemies! Prefab is missing.");
        }
    }

    void SpawnEnemies() 
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(spawnPrefab, Vector3.zero, Quaternion.identity);
        }
    } 
}
