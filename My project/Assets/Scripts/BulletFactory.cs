
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject bulletPrefab;

    public GameObject CreateBullet(Transform parent)
    {
        GameObject bullet = Instantiate(
            bulletPrefab,
            parent
        );

        bullet.SetActive(false);
        return bullet;
    }
}
