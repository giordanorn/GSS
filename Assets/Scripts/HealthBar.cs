﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class HealthBar : MonoBehaviour
{
    public HealthReserve healthReserve;
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
        float width = barMaxWidth * (healthReserve.CurrentHealth / healthReserve.maximumHealth);
        float height = rectTransform.sizeDelta.y;

        rectTransform.sizeDelta = new Vector2(width, height);
    }
}
