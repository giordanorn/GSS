using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text bullets;
    public Firepoint playerFirepoint;

    // Update is called once per frame
    void Update()
    {
        if (playerFirepoint.getRemainingBullets() == 0)
        {
            bullets.text = "Bullets: Reloading";
        }
        else
        {
            bullets.text = "Bullets: " + playerFirepoint.getRemainingBullets();
        }
    }
}
