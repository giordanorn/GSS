﻿using System;
using UnityEngine;


[RequireComponent(typeof(Battler))]
public class HealthReserve : MonoBehaviour
{
    public float maximumHealth;
    public float regeneratePerSecond;
    
    public float CurrentHealth {get; private set;}
    private Battler battler;

    void Start()
    {
        CurrentHealth = maximumHealth;
        battler = GetComponent<Battler>();
    }

    void Update()
    {
        if (CurrentHealth < maximumHealth)
        {
            Regenerate(regeneratePerSecond);
        }
    }
    
    public void Consume(float healthToConsume)
    {
        if (CanConsume(healthToConsume))
        {
            CurrentHealth -= healthToConsume;
        }
        else {
            CurrentHealth = 0.0f;
        }
    }

    public bool IsEmpty()
    {
        return CurrentHealth == 0.0f;
    }

    private bool CanConsume(float healthToConsume)
    {
        return CurrentHealth >= healthToConsume;
    }

    private void Regenerate(float regeneratePerSecond) {
        CurrentHealth = Math.Min(CurrentHealth + (Time.deltaTime * regeneratePerSecond), maximumHealth);
    }
}
