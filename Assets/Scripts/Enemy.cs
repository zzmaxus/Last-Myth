﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform playerLocation;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void FixedUpdate()
    {
        playerLocation = GameObject.FindWithTag("Player").transform;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerLocation.position, speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Application.Quit();
            Debug.Log("Game Over");
        }
    }
}