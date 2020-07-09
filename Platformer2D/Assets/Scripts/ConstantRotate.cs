using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotate : MonoBehaviour
{
    public Transform item;

    void Update()
    {
        item.Rotate(0, 0, 1);
    }
    
}
