using UnityEngine;
using System.Collections;


namespace Topic04 {
    public class RayCaster : MonoBehaviour {
        public float Distance;
        public Vector3 Direction;
        
        // Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                Ray ray = new Ray(transform.position, Direction);
                RaycastHit[] allHitInfo;
                allHitInfo = Physics.RaycastAll(ray, Distance);
                for (int i=0; i<allHitInfo.Length; i++) {
                    RaycastHit hitInfo = allHitInfo[i];
                    Debug.Log("Hit: " + hitInfo.collider.gameObject.name);
                }
            }
            if (Input.GetKeyDown(KeyCode.Return)) {
                Ray ray = new Ray(transform.position, Direction);
                RaycastHit hitInfo;
                bool isHit = Physics.Raycast(ray, out hitInfo, Distance);
                if (isHit) {
                    Debug.Log("Hit something: " + 
                              hitInfo.collider.gameObject.name);
                }
                else {
                    Debug.Log("Hit nothing");
                }
            }
        }
    }
}