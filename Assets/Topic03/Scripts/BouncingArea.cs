using UnityEngine;
using System.Collections;

public class BouncingArea : MonoBehaviour {
    void Start () {
        Debug.Log("BouncingArea: Start");
	}

    void OnTriggerEnter(Collider other) {
        string objectName = other.gameObject.name;
        Debug.Log("Floor: " + objectName + " hit!");
        other.rigidbody.AddForce(20f * Vector3.up, ForceMode.Impulse);
    }
}