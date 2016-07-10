using UnityEngine;
using System.Collections;
using System;
using TobiasErichsen.teVirtualMIDI.test;


public class ColliderScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
		int note;
		KeyNote script; 
		//teVirtualMIDI.ProduceSound(other.Note)
		if (other.CompareTag ("key")) {
			script = other.GetComponent<KeyNote> ();
			note = script.getNote ();
			KeyToSoundIntegrator.ProduceSound (note);
		}
    }
}