using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;

    public bool IsMoving { get; private set; }
    public bool IsFacingLeft { get; private set; }

    void FixedUpdate()
	{
		int horizontalMove = 0;
		
		if (Input.GetKey(KeyCode.D))
		{
			horizontalMove += 1;
		}

		if (Input.GetKey(KeyCode.A))
		{
			horizontalMove += -1;
		}

        IsMoving = horizontalMove != 0;
        IsFacingLeft = horizontalMove < 0;

        if (IsMoving)
        {
            if (IsFacingLeft)
            {
                transform.right = Vector3.left; 
            }
            else
            {
                transform.right = Vector3.right;
            }

            transform.Translate(speed * Vector3.right * Time.deltaTime);
        }
    }
}
