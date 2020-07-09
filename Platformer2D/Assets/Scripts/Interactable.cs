using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject player;
    public PlayerController controller;
    private bool hasDoneSpeed = false;
    private float speedBefore;

    void Start()
    {
        Debug.Log(controller.speed);
        speedBefore = controller.speed;
        controller = player.GetComponent<PlayerController>();

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (hasDoneSpeed == false)
            {
                controller.speed = controller.speed * 2;
                Debug.Log(controller.speed);

                Destroy(gameObject);
            }
        }
            
    }
}
