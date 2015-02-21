using UnityEngine;
using System.Collections;

namespace MakingOfBrickGame {
    public class PaddleController : MonoBehaviour {
        public float Speed;
        
        // Update is called once per frame
        void Update() {
            float h = Input.GetAxis("Horizontal");
            Vector3 velo = new Vector3(Speed * h, 0, 0);
            rigidbody.velocity = velo;
        }
    }
}