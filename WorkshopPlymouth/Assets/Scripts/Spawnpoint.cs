using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public Obstacle obstacle;

    public float xSpeedOfObstacle;

    private float timeBetweenSpawns;

    // Update is called once per frame
    void Update()
    {
        if(timeBetweenSpawns <= 0)
        {
            obstacle.xSpeed = xSpeedOfObstacle;
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBetweenSpawns = Random.Range(1, 5);
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
