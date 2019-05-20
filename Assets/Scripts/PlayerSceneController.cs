using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (coll.gameObject.CompareTag("Next Map"))
        {
            System.Console.Out.WriteLine(SceneManager.GetActiveScene().name);
        }
    }
}
