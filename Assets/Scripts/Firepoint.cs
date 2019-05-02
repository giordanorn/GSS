using UnityEngine;

public class Firepoint : MonoBehaviour
{
    public EnergyReserve energyReserve;
    public GameObject bullet;

    void Update()
    {
        Shootable shootable = bullet.GetComponent<Shootable>();
        if (Input.GetKeyDown(KeyCode.Space) && energyReserve.ConsumeEnergy(shootable.energyCost))
        {
            GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
