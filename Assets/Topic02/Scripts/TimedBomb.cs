using UnityEngine;
using System.Collections;

public class TimedBomb : MonoBehaviour {
    public float TimeCounter;

    // Update is called once per frame
	void Update () {
        TimeCounter = TimeCounter + Time.deltaTime;
        if (TimeCounter > 5f) {
            Debug.Log("Boooom !!");
        }
	}
}