﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Laser door buttons

public class Switch : MonoBehaviour
{
    public GameObject switchObj;

    [SerializeField] private GameObject targetKey;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == targetKey)
        {
            source.Play();
            Debug.Log("Deactivating Lazer Door");
            switchObj.SetActive(false);
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == targetKey)
        {
            source.Play();
            switchObj.SetActive(true);
        }
    }

    
}
