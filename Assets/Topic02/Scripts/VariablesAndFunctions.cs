using UnityEngine;
using System.Collections;


public class VariablesAndFunctions : MonoBehaviour {
    public int IntVariable;
    public bool BoolVariable;
    public float FloatVarible;

    public float Number1;
    public bool UseFactor01;
    public float NumberOutput;
    private float mFactor01;
    float mFactor02;

    void Start() {
        Debug.Log("Varibles and Functions1");
        Number1 = FloatVarible;
        mFactor01 = 0.5f;
        mFactor02 = 0.7f;
    }

    void Update() {
        if (UseFactor01) {
            NumberOutput = Multiply(Number1, mFactor01);
        }
        else {
            NumberOutput = Multiply(Number1, mFactor02);
        }
        WriteNumber(NumberOutput);
    }

    void WriteNumber(float number) {
        Debug.Log("Number is " + number);
    }

    float Multiply(float num1, float num2) {
        return num1 * num2;
    }
}