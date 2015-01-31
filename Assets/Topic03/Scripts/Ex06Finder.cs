using UnityEngine;
using System.Collections;

public class Ex06Finder : MonoBehaviour {
    public string ObjectName01;
    public string TagName01;

    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            GameObject go = GameObject.Find(ObjectName01);
            if (go != null) {
                Destroy(go);
            }
            else {
                Debug.LogError("Cannot find object: " + ObjectName01);
            }
        }
        if (Input.GetKeyDown(KeyCode.B)) {
            GameObject go = GameObject.FindGameObjectWithTag(TagName01);
            if (go != null) {
                Destroy(go);
            }
            else {
                Debug.LogError("Cannot find object with Tag: " + TagName01);
            }
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            GameObject[] allGo = GameObject.FindGameObjectsWithTag(TagName01);
            for (int i = 0; i < allGo.Length; i++) {
                Destroy(allGo[i]);
            }
        }
    }
}