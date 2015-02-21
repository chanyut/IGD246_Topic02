using UnityEngine;
using System.Collections;

namespace MakingOfBrickGame {
    public class Game : MonoBehaviour {
        public int CurrentScore;
        public int NumberOfTotalBricks;
        public int NumberOfDestroyedBricks;

        public void IncreaseScore(int score) {
            CurrentScore += score;
        }

        public void IncreaseNumberOfDestroyedBrick() {
            NumberOfDestroyedBricks++;
            if (NumberOfDestroyedBricks >= NumberOfTotalBricks) {
                Debug.Log("You win!!");
                Application.LoadLevel(0);
            }
        }
    }
}