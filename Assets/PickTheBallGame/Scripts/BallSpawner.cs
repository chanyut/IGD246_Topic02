using UnityEngine;
using System.Collections;


namespace PickTheBallGame
{
    public class BallSpawner : MonoBehaviour
    {
        public Transform[] SpawnPoints;
        public GameObject BallPrefab;

        private float mTimer;

        void Start()
        {
            mTimer = 0;
        }

        void Update()
        {
            mTimer += Time.deltaTime;
            if (mTimer >= 1f)
            {
                int l = SpawnPoints.Length;
                int index = Random.Range(0, l);
                Instantiate(BallPrefab, SpawnPoints[index].position, Quaternion.identity);
                mTimer = 0;
            }
        }
    }
}