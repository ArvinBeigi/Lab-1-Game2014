
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public BulletPool bulletPool;
    public float fireInterval = 0.4f;
    public float bulletSpeed = 8f;

    private float fireTimer;

    void Update()
    {
        fireTimer -= Time.deltaTime;

        bool firePressed = false;

        if (Touchscreen.current != null &&
            Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            firePressed = true;
        }
        else if (Mouse.current != null &&
                 Mouse.current.leftButton.wasPressedThisFrame)
        {
            firePressed = true;
        }

        if (firePressed && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireInterval;
        }
    }

    void Shoot()
    {
        GameObject bullet = bulletPool.GetBullet();

        if (bullet == null)
            return;

        bullet.transform.position = transform.position;
        bullet.transform.rotation = Quaternion.identity;
        bullet.SetActive(true);

        BulletMovement movement =
            bullet.GetComponent<BulletMovement>();

        if (movement != null)
        {
            movement.Launch(bulletSpeed);
        }
    }
}

