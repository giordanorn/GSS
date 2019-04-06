using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerAnimation : MonoBehaviour
{
    public Sprite[] sprites;
    public float framesPerSecond = 4.0f;
    
    private PlayerMovement playerMovement;
    private SpriteRenderer spriteRenderer;
    private int currentSpriteIdx;
    private float timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.IsMoving)
        {
            timeCounter += Time.deltaTime;

            if (timeCounter * framesPerSecond >= 1.0f)
            {
                currentSpriteIdx = (currentSpriteIdx + 1) % sprites.Length;
                spriteRenderer.sprite = sprites[currentSpriteIdx];
                timeCounter = 0.0f;
            }
        }
    }
}
