﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGrav : MonoBehaviour
{
    private bool gravityInverted = true;
    private PlayerControls playerCtrl;


    private void Awake()
    {
        playerCtrl = transform.root.GetComponent<PlayerControls>();
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            //transform.Rotate(Vector3.forward * 180);
            gravityInverted = !gravityInverted;
        }
    }

}
