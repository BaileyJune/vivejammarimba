using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	void OnTriggerEnter(Collider info){
		if (info.tag == "MalletTip") {
			GetComponent<Renderer> ().material.color = Color.green;
		}
	}
	void OnTriggerExit(Collider info){
		if (info.tag == "MalletTip") {
			GetComponent<Renderer> ().material.color = Color.white;
		}
	}
}
