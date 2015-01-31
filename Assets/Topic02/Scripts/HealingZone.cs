using UnityEngine;
using System.Collections;

public class HealingZone : MonoBehaviour {
    public GameObject PlayerGameObject;

	void Update () {
        Vector3 d = transform.position - PlayerGameObject.transform.position;
        float distance = d.magnitude;
        if (distance < 5) {
            PlayerController pc = PlayerGameObject.GetComponent<PlayerController>();
            pc.Heal();
        }
	}
}
