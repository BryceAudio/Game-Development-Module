﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unused in final game due to time constraints

public class SpinCupOnCollision : MonoBehaviour
{
 
    public bool canRotate;
   

    void Start()
    {
        canRotate = false;
    }

    //if upgrav is true and you fire at it, go back up
    void Update()
    {


        if (canRotate == true)
        {
            //trackTransform = this.transform;

             if ((this.transform.rotation.z >= 0) && (this.transform.rotation.z <= 1))
            {
                //Debug.Log(this.transform.rotation.z);
                this.transform.Rotate(Vector3.forward * (Time.deltaTime * 180));
               
            }

         

           



        }





    }
}

    
