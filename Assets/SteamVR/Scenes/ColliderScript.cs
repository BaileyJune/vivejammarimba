using UnityEngine;
using System.Collections;
using System;

public class ColliderScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
		Debug.Log ("Colliding");
    }
}