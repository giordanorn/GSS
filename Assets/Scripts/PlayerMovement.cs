﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float speed;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		float horizontalMove = 0.0f;
		
		if (Input.GetKey(KeyCode.D))
		{
			horizontalMove += 1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			horizontalMove += -1;
		}

		transform.position += new Vector3(horizontalMove * speed, 0, 0) * Time.deltaTime;
	}
}