using UnityEngine;

public class Battler : MonoBehaviour
{
    public float maxHealth;
    public float damageCooldown;
    private float health;
    private float cooldown;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (cooldown <= 0.0f)
        {
            health -= damage;
            cooldown = damageCooldown;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0.0f)
        {
            cooldown -= Time.deltaTime;
        }

        if (health <= 0.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
