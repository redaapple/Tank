﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExploDestory : MonoBehaviour
{
    public float time=1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
