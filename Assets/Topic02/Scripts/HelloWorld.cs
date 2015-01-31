using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour
{
    void Awake() 
    {
        Debug.Log("Hello world - Awake");
    }

    void Start()
    {
        Debug.LogWarning("Hello world - Start");
    }

    void Update()
    {
        Debug.LogError("Hello world - Update");
    }
}