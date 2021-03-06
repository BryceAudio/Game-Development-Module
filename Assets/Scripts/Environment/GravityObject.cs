﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is attached to every objectthat can be controlled by gravity

public class GravityObject : MonoBehaviour
{
    private Rigidbody2D rgb2d;

    private bool globalGravityState;
    private bool localGravityState;

    private void Start() {
        rgb2d = GetComponent<Rigidbody2D>();
        globalGravityState = false;
        localGravityState = false;
        GameStateController.OnGravityChange += HandleGlobalGravitySwitch;
        
    }

    //Unsubscribe on destruction
    private void OnDestroy() {
        GameStateController.OnGravityChange -= HandleGlobalGravitySwitch;
    }


    private void HandleGlobalGravitySwitch(bool newGrav){

        globalGravityState = newGrav;
        
        this.SetGravity();
        
    }

    public void SwitchLocalGravity(){
        localGravityState = !localGravityState;
        this.SetGravity();
    }

    //Set the gravity scale of current object based on both global and local gravity settings
    private void SetGravity(){
        //Debug.Log("Switching gravity on object: " + this.gameObject.name);
        if ((!globalGravityState&&!localGravityState)||(globalGravityState&&localGravityState)){
            rgb2d.gravityScale = Mathf.Abs(rgb2d.gravityScale);
            
        }
        else {
            rgb2d.gravityScale = -Mathf.Abs(rgb2d.gravityScale);
            
        }
    }

    //Return whether or not (as a result of both global and local gravity) the current object is under normal gravity
    //Currently only used for determining whether or not to flip a transform
    public bool GetGravityState(){

        return !((!globalGravityState&&!localGravityState)||(globalGravityState&&localGravityState));

    }

   

}
