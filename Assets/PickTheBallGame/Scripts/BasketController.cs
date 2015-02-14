using UnityEngine;
using System.Collections;


namespace PickTheBallGame
{
    public class BasketController : MonoBehaviour
    {
        public float Speed;

        // Update is called once per frame
        void Update()
        {
            float h = Input.GetAxis("Horizontal");
            Vector3 direction = new Vector3(h, 0, 0);
            transform.Translate(h * Speed * Time.deltaTime, 0, 0);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Ball")
            {
                Debug.Log("Ball enter");
                Destroy(other.gameObject);
            }
        }
    }
}