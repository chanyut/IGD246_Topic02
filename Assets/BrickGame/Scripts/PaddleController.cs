using UnityEngine;
using System.Collections;

namespace BrickGame {
    public class PaddleController : MonoBehaviour {
        public float Speed = 1f;

        // Update is called once per frame
        void Update() {
            float h = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(h * Speed * Time.deltaTime, 0, 0));
            if (transform.position.x < -9f) {
                transform.position = new Vector3(-9f, 0, 0);
            }
            if (transform.position.x > 9f) {
                transform.position = new Vector3(9f, 0, 0);
            }
        }
    }
}