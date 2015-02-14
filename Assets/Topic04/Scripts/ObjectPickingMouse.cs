using UnityEngine;
using System.Collections;

public class ObjectPickingMouse : MonoBehaviour {
    public Camera CurrentCamera;
    public float RayCastDistance;

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = CurrentCamera.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;
            bool isHit = Physics.Raycast(ray, out hitInfo, RayCastDistance);
            if (isHit) {
                Debug.Log("Click at: " + hitInfo.collider.gameObject.name);
            }
        }
	}
}