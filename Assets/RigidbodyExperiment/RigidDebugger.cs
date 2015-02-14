using UnityEngine;
using System.Collections;

public class RigidDebugger : MonoBehaviour {

    void OnDrawGizmos() {
        if (rigidbody == null) {
            return;
        }

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + (rigidbody.velocity.normalized * 3f));
    }
}
