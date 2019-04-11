using UnityEngine;

public class Firepoint : MonoBehaviour
{
    public GameObject bullet;
    public int bulletMax;
    public float reloadingTime;

    private int bulletCount = 0;
    private float timeCount = 0.0f;


    public int getRemainingBullets()
    {
        return bulletMax - bulletCount;
    }

    void Update()
    {
        if (bulletCount >= bulletMax)
        {
            timeCount += Time.deltaTime;
            if (timeCount >= reloadingTime)
            {
                timeCount = 0.0f;
                bulletCount = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation);
            bulletCount++;
        }
    }
}
