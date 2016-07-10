using UnityEngine;
using System;
using System.Collections;

public class playSound : MonoBehaviour
{
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided!!");
    }
}
