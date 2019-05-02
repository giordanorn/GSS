using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class EnergyBar : MonoBehaviour
{
    public EnergyReserve energyReserve;
    private float barMaxWidth;
    private RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        barMaxWidth = rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        float width = barMaxWidth * (energyReserve.Energy / energyReserve.energyMax);
        float height = rectTransform.sizeDelta.y;

        rectTransform.sizeDelta = new Vector2(width, height);
    }
}
