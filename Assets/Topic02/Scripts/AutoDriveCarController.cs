using UnityEngine;
using System.Collections;

public class AutoDriveCarController : MonoBehaviour {
    public float Speed;
    public float RotateSpeed;
    public int State;
    public float TimeCounter;

    void Start() {
        State = 0;
        TimeCounter = 0;
    }

    void Update() {
        if (State == 0) {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            TimeCounter += Time.deltaTime;
            if (TimeCounter > 1f) {
                TimeCounter = 0;
                State = 1;
            }
        }
        else if (State == 1) {
            transform.Rotate(Vector3.up, 1f * RotateSpeed * Time.deltaTime);
            TimeCounter += Time.deltaTime;
            if (TimeCounter > 1f)
            {
                TimeCounter = 0;
                State = 0;
            }
        }
    }
}
