using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void Exit1()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
