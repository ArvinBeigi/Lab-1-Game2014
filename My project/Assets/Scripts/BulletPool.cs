
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public BulletFactory bulletFactory;
    public int poolSize = 10;

    private List<GameObject> bullets =
        new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet =
                bulletFactory.CreateBullet(transform);

            bullets.Add(bullet);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet;
            }
        }

        return null;
    }
}
