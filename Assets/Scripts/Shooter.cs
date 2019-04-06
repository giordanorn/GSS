using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public int bulletMax;
    public float timeReset;

    private int bulletCount = 0;
    private float timeCount = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (bulletCount >= bulletMax)
        {
            timeCount += Time.deltaTime;
            if (timeCount >= timeReset)
            {
                timeCount = 0.0f;
                bulletCount = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation);
            bulletInstance.AddComponent<Bullet>();
            bulletCount++;
        }
    }
}
