using UnityEngine;
using System.Collections;

public class CostumeController : MonoBehaviour {
    public bool IsAngry;

    void Update() {
        if (IsAngry == true) {
            Renderer myRenderer = GetComponent<Renderer>();
            myRenderer.material.color = new Color(1, 0, 0, 1);
        }
        else {
            Renderer myRenderer = GetComponent<Renderer>();
            myRenderer.material.color = new Color(1, 1, 1, 1);
        }
    }
}
