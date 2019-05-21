using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneController : MonoBehaviour
{
    private const int map1 = 0;
    private const int map2 = 1;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (coll.gameObject.CompareTag("Next Map"))
        {
            SceneManager.LoadScene(map2);
        }
    }
}
