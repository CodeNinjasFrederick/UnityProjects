﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Default")]

    public float speed;




    // Update is called once per frame
    void Update()
    {





        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

