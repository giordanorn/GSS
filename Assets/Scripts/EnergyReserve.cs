using System;
using UnityEngine;

public class EnergyReserve : MonoBehaviour
{
    public float energyMax;
    public float energyRestoreAmount;

    public float Energy { get; private set; }

    void Start()
    {
        Energy = energyMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (Energy < energyMax)
        {
            Energy += Time.deltaTime * energyRestoreAmount;
            Energy = Math.Min(Energy, energyMax);
        }
    }

    public bool ConsumeEnergy(float energyToConsume)
    {
        if (Energy >= energyToConsume)
        {
            Energy -= energyToConsume;
            return true;
        }

        return false;
    }
}
