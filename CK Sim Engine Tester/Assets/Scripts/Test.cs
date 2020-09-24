using CKSimEngineUnity;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text TextObject;

    void Start()
    {
        Debug.Log("Starting test...");
        Debug.Log(SimEngine.FooFunction());

        TextObject = GameObject.Find("Text").GetComponent<Text>();
        TextObject.text = SimEngine.FooFunction();
    }

    void Update()
    {

    }
}