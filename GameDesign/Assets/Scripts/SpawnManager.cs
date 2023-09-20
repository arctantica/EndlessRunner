using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<ObstacleMovement> preFabs = new List<ObstacleMovement>();
    public float spawnTimer = 0;
    public float spawnSpeed = 0;
    public float spawnThreshhold = 0;
    public List<Vector3> spawnPoints;

    private void Update()
    {
        spawnTimer += spawnSpeed;
        if (spawnTimer > spawnThreshhold)
        {
            spawnTimer = 0;
            spawnObstacle(preFabs[(int)Random.Range(0, preFabs.Count)]);
        }
    }

    private void spawnObstacle(ObstacleMovement objects)
    {
        
    }
}
