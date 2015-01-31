using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int Hp;

    void Update() {
        float v = Input.GetAxis("Vertical");
        Rigidbody myRigidbody = gameObject.GetComponent<Rigidbody>();
        if (myRigidbody != null) {
            myRigidbody.AddForce(v * Vector3.forward, ForceMode.Force);
        }

        CostumeController myCostumeController = gameObject.GetComponent<CostumeController>();
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            myCostumeController.IsAngry = !myCostumeController.IsAngry;
        }

        if (Hp <= 0) {
            Destroy(gameObject);
        }
    }

    public void Heal() {
        Hp++;
    }
}
