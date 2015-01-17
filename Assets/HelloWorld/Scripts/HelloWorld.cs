using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour
{
    void Awake() {
        Debug.Log("Hello world - Awake");
    }

    void Start()
    {
        Debug.Log("Hello world - Start");
    }

    void Update()
    {
        Debug.Log("Hello world - Update");
    }
}