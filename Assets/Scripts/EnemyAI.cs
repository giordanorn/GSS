using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyAI : MonoBehaviour
{
    public Battler player;
    public float followRadius;
    public float speed;
    public float damage;
    public Sprite idleSprite;
    public Sprite attackingSprite;

    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private bool isTouchingPlayer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = idleSprite;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = player.transform.position - transform.position;

        isTouchingPlayer = Vector3.Magnitude(delta) < player.transform.lossyScale.magnitude / 10f;

        if (isTouchingPlayer)
        {
            player.TakeDamage(damage);
        }
        else if (Vector3.Magnitude(delta) < followRadius)
        {
            spriteRenderer.sprite = attackingSprite;
            spriteRenderer.flipX = Vector3.Angle(Vector3.right, delta) < 90;

            transform.Translate(speed * Time.deltaTime * Vector3.Normalize(delta));

            if (audioSource != null && audioSource.enabled && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            spriteRenderer.sprite = idleSprite;
        }
    }
}
