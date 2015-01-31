using UnityEngine;
using System.Collections;

public class TreasureBoxBuilder : MonoBehaviour {
    public GameObject TreasureBoxPrefab;
    public GameObject CreatePostionProxy;

    void Start() {
        Debug.Log("TreasureBoxBuild - Start");
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) { 
            Vector3 pos = new Vector3(0, 0, 0);
            pos = CreatePostionProxy.transform.position;
            GameObject newTreasureBox = Instantiate(
                TreasureBoxPrefab, pos, Quaternion.identity) as GameObject;
            if (newTreasureBox.rigidbody != null) {
                newTreasureBox.rigidbody.AddForce(10 * Vector3.up, ForceMode.Impulse);
            }
        }
    }
}