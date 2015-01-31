using UnityEngine;
using System.Collections;

public class BouncingFloor : MonoBehaviour {
    void Start () {
        Debug.Log("Bouncing Floor: Start");
	}

    void OnCollisionEnter(Collision other) {
        string objectName = other.gameObject.name;
        Debug.Log("Floor: " + objectName + " hit!");
        other.rigidbody.AddForce(20f * Vector3.up, ForceMode.Force);
    }
}
