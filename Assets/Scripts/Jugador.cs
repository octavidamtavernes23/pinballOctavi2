﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad=1f;
    // Start is called before the first frame update

       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(2f,0f,0f) * velocidad * Time.deltaTime);
    }
}
