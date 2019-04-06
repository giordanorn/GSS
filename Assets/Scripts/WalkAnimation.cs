using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
    public Sprite[] sprites;

    private SpriteRenderer spriteRenderer;
    private PlayerMovement playerMovement;

    private int currentSpriteIdx;
    private float timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.IsMoving)
        {
            timeCounter += Time.deltaTime;

            if (timeCounter * playerMovement.speed >= 1.0f)
            {
                currentSpriteIdx = (currentSpriteIdx + 1) % sprites.Length;
                spriteRenderer.sprite = sprites[currentSpriteIdx];
                timeCounter = 0.0f;
            }
        }
    }
}
