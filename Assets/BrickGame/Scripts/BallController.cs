using UnityEngine;
using System.Collections;

namespace BrickGame
{
    public class BallController : MonoBehaviour
    {
        public float Speed = 5f;
        public Vector3 Direction = Vector3.up;
        public Game CurrentGame;

        void Start()
        {
            Direction = new Vector3(1, 1, 0);
        }

        void Update()
        {
            int ballLayerMask = 1 << 8;
            int deadZoneLayerMask = 1 << 9;
            int layerMask = ballLayerMask | deadZoneLayerMask;
            layerMask = ~layerMask;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, Direction, out hit, 0.6f, layerMask))
            {
                Direction = Vector3.Reflect(Direction, hit.normal);
                Direction.Normalize();
                if (hit.collider.gameObject.tag == "Brick")
                {
                    CurrentGame.NumberOfHitBricks++;
                    Destroy(hit.collider.gameObject, 0.1f);
                }
            }

            transform.position += Direction * Speed * Time.deltaTime;
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position + (Direction * 2f));
        }
    }
}