﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float valor = 100;
    public Vida padreRef;
    public float multiplicadorDeDaño = 1.0f;
    public float dañoTotal;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecibirDaño(float daño)
    {
        daño *= multiplicadorDeDaño;
        if (padreRef != null)
        {

            padreRef.RecibirDaño(daño);
            return;
        }
        valor -= daño;
        dañoTotal = daño;
        if (valor < 0)
        {
            valor = 0;
            
        }
    }
}
