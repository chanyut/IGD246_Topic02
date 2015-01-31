using UnityEngine;
using System.Collections;

public class Ex05Array : MonoBehaviour {
    public GameObject[] Balls;

    public void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            for (int i = 0; i < Balls.Length; i++) {
                Balls[i].rigidbody.AddForce(10 * Vector3.up, ForceMode.Force);
            }
        }
    }
}