using UnityEngine;

public class Shootable : MonoBehaviour
{
    public float damage = 5.0f;
    public float speed = 5.0f;
    
    void FixedUpdate()
    {
        transform.Translate(speed * Vector3.right * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Collide(coll.gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Collide(coll.gameObject);
    }

    private void Collide(GameObject other)
    {
        Battler battler = other.GetComponent<Battler>();
        if (battler != null)
        {
            battler.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
