using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float[] spawnLocations;

    //private Vector3 spawnPos = new Vector2(25, 0);
    private float startDelay = 3;
    private float repeatRate = 2.2f;
    private PlayerTwoController playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        playerTwo = GameObject.Find("Player").GetComponent<PlayerTwoController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstacle.Length);
        int randomSpawn = Random.Range(0, spawnLocations.Length);
        float randomChoose = spawnLocations[randomSpawn];
        Vector3 spawnPos = new Vector2(80.0f, randomChoose);

        if (playerTwo.gameOver == false)
        {
            Instantiate(obstacle[index], spawnPos, obstacle[index].transform.rotation);
        }
    }
}
