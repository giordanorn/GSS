using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Bullet;
    public int BulletMax;
    public float TimeReset;

    private int bulletCount = 0;
    private float timeCount = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (bulletCount >= BulletMax)
        {
            timeCount += Time.deltaTime;
            if (timeCount >= TimeReset)
            {
                timeCount = 0.0f;
                bulletCount = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);
            bullet.AddComponent<Bullet>();
            bulletCount++;
        }
    }
}
