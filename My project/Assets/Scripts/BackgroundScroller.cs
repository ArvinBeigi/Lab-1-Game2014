
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;

    void Update()
    {
        transform.Translate(
            Vector3.down * scrollSpeed * Time.deltaTime
        );
    }
}

