using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public float spawnLimitXLeft = -22;
    public float spawnLimitXRight = 7;
    public float spawnPosY = 30;

    public float startDelay = 1.0f;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void Update()
    {
        if ((spawnInterval -= Time.deltaTime) <= 0)
        {
            SpawnRandomBall();
            spawnInterval = Random.Range(3, 5);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int spawnIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[spawnIndex].transform.rotation);
    }

}
