using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax2DFixed : MonoBehaviour
{
    private float deltaX;

    // Start is called before the first frame update
    void Start()
    {
        deltaX = Camera.main.transform.position.x - transform.position.x; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (
            Camera.main.transform.position.x - deltaX,
            transform.position.y,
            transform.position.z
            );
    }
}
