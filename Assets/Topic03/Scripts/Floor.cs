using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
    void Start() {
        Debug.Log("I am Floor");
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log("Floor: Something hit me: " + other.gameObject.name);
    }

    void OnCollisionStay(Collision other) {
        string objectName = other.gameObject.name;
        Debug.Log(string.Format("Floor: {0} Stay", objectName));
    }

    void OnCollisionExit(Collision other) {
        string objectName = other.gameObject.name;
        Debug.Log(string.Format("Floor: {0} Exit", objectName));
    }

    void OnTriggerEnter(Collider other) {
        string objectName = other.gameObject.name;
        Debug.Log(string.Format("Floor: {0} enter Trigger", objectName));
    }

    void OnTriggerExit(Collider other) {
        string objectName = other.gameObject.name;
        Debug.Log(string.Format("Floor: {0} exit Trigger", objectName));
    }

    void OnTriggerStay(Collider other) {
        string objectName = other.gameObject.name;
        Debug.Log(string.Format("Floor: {0} stay Trigger", objectName));
    }
}
