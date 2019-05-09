using UnityEngine;

public class Battler : MonoBehaviour
{
    private HealthReserve healthReserve;
    private DamageCooldown damageCooldown;

    void Start()
    {
        healthReserve = GetComponent<HealthReserve>();
        damageCooldown = GetComponent<DamageCooldown>();
    }

    public void TakeDamage(float damage)
    {
        if (!IsImmune())
        {
            if (HasHealthReserve())
            {
                healthReserve.Consume(damage);
                if (healthReserve.IsEmpty())
                {
                    Die();
                }
            }
            if (HasDamageCooldown())
            {
                damageCooldown.ResetCooldown();
            }
        }
    }
    
    public void Kill()
    {
        Die();
    }
    
    private bool IsImmune()
    {
        if (!HasHealthReserve())
        {
            return true;
        }
        else if (HasDamageCooldown())
        {
            return damageCooldown.InCooldown();
        }
        else
        {
            return false;
        }
    }

    private bool HasHealthReserve()
    {
        return healthReserve != null;
    }

    private bool HasDamageCooldown()
    {
        return damageCooldown != null;
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
