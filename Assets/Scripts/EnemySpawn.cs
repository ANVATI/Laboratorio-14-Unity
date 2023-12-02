using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Transform SpawnerLeft;
    public Transform SpawnerRight;

    void Start()
    {
        Invoke("SpawnEnemies", 1);
    }

    void SpawnEnemies()
    {
        float randomX = Random.Range(SpawnerLeft.position.x, SpawnerRight.position.x);
        Vector3 spawnPosition = new Vector3(randomX, SpawnerLeft.position.y, SpawnerLeft.position.z);

        Instantiate(enemigoPrefab, spawnPosition, transform.rotation);

        Invoke("SpawnEnemies", 1);
    }
}


