﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textopn1 : MonoBehaviour
{
    public float Tiempodevida = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tiempodevida -= Time.deltaTime;
        if (Tiempodevida <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}
