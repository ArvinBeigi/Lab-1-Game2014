using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float despawnY = 6f;
    public int pointsPerObstacle = 10;

    private float moveSpeed;

    public void Launch(float speed)
    {
        moveSpeed = speed;
    }

    void Update()
    {
        transform.Translate(
            Vector3.up * moveSpeed * Time.deltaTime,
            Space.World
        );

        if (transform.position.y > despawnY)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            ScoreManager scoreManager =
                FindFirstObjectByType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddPoints(pointsPerObstacle);
            }

            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
