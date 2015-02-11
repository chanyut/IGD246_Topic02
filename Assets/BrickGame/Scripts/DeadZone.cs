using UnityEngine;
using System.Collections;

namespace BrickGame
{
    public class DeadZone : MonoBehaviour
    {
        public Game CurrentGame;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Ball")
            {
                CurrentGame.Restart();
            }
        }
    }
}