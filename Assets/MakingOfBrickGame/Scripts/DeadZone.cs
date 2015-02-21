using UnityEngine;
using System.Collections;

namespace MafingOfBrickGame {
    public class DeadZone : MonoBehaviour {
        void OnTriggerEnter(Collider other) {
            if (other.gameObject.tag == "Ball") {
                Destroy(other.gameObject);
                Application.LoadLevel(0);
            }
        }
    }
}