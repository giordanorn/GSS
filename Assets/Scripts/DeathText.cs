using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Battler))]
public class DeathText : MonoBehaviour
{

    public GameObject textObject;
    public string deathText;

    void Start()
    {
        textObject.SetActive(false);
    }

    public void showText()
    {
        textObject.SetActive(true);
        textObject.GetComponent<Text>().text = deathText;
    }
}
