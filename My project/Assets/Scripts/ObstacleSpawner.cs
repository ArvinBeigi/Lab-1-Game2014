
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public ObstaclePool obstaclePool;
    public float spawnInterval = 2f;
    public float spawnY = 6f;
    public float horizontalRange = 4f;

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnObstacle();
            spawnTimer = 0f;
        }
    }

    void SpawnObstacle()
    {
        GameObject obstacle = obstaclePool.GetObstacle();

        if (obstacle != null)
        {
            float randomX = Random.Range(
                -horizontalRange,
                horizontalRange
            );

            obstacle.transform.position =
                new Vector3(randomX, spawnY, 0f);
        }
    }
}
