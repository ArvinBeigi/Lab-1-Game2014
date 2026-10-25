using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float despawnY = -6f;

    void Update()
    {
        transform.Translate(
            Vector3.down * moveSpeed * Time.deltaTime,
            Space.World
        );

        if (transform.position.y < despawnY)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LifeManager lifeManager =
                FindFirstObjectByType<LifeManager>();

            if (lifeManager != null)
            {
                lifeManager.LoseLife();
            }

            gameObject.SetActive(false);
        }
    }
}
