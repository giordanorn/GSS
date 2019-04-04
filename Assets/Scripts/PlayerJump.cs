using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	private BoxCollider2D bc;
	private bool onAir;
	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		bc = GetComponent<BoxCollider2D>();
		onAir = true;
	}

	void FixedUpdate()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (onAir == false)
			{
				PerformJump();
				onAir = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		onAir = false;
	}
	void PerformJump()
	{
		rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
	}
}
