
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
}
