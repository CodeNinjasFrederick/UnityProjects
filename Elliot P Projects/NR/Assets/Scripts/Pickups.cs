﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    
    public Text scoreText;

    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }
}
