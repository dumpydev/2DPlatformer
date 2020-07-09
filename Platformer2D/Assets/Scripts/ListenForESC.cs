using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListenForESC : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("QUITTING GAME");
            Application.Quit();
            
        }
    }
}
