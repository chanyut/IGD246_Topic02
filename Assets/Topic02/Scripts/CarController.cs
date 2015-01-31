using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
    public float Speed;
    public float RotateSpeed;

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.up, -RotateSpeed * Time.deltaTime);
        }
    }
}
