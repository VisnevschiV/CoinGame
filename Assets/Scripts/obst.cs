﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obst : MonoBehaviour
{
    public static float ObstmoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        ObstmoveSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0f,-ObstmoveSpeed*Time.deltaTime);
        
    }
    
}
