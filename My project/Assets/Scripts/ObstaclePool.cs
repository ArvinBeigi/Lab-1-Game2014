
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int poolSize = 5;

    private List<GameObject> obstacles =
        new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obstacle = Instantiate(
                obstaclePrefab,
                transform
            );

            obstacle.SetActive(false);
            obstacles.Add(obstacle);
        }
    }

    public GameObject GetObstacle()
    {
        foreach (GameObject obstacle in obstacles)
        {
            if (!obstacle.activeInHierarchy)
            {
                obstacle.SetActive(true);
                return obstacle;
            }
        }

        return null;
    }
}

