using UnityEngine;
using System.Collections;

namespace BrickGame
{
    public class Game : MonoBehaviour
    {
        public int NumberOfHitBricks;
        public int NumberOfTotalBricks;

        void Start()
        {
            NumberOfHitBricks = 0;
        }

        void Update()
        {
            if (NumberOfHitBricks >= NumberOfTotalBricks) 
            {
                Debug.Log("Win!");    
            }
        }

        public void Restart()
        {
            Application.LoadLevel(0);            
        }
    }
}