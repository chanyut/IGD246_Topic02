using UnityEngine;
using System.Collections;

namespace MakingOfBrickGame {
    public class BallController : MonoBehaviour {
        public float Speed = 5f;
        public Vector3 Direction = Vector3.up;
        public Game CurrentGame;

        void Update() {
            transform.position += Direction * Speed * Time.deltaTime;
        }

        void OnCollisionEnter(Collision other) {
            Debug.Log("Collided: " + other.gameObject.name);
            Direction = Vector3.Reflect(Direction, other.contacts[0].normal);
            Direction.Normalize();

            if (other.gameObject.tag == "Brick") {
                Destroy(other.gameObject);
                CurrentGame.IncreaseScore(10);
                CurrentGame.IncreaseNumberOfDestroyedBrick();
            }
        }
    }
}