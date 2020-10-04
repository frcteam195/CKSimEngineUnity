using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public string LatestTopic, LatestData;

    public Text TextObject;

    [DllImport ("CKSimEngineUnityPlugin")]

    private static extern float FooPluginFunction();

    void Start()
    {
        UnityEngine.Debug.Log("Starting test...");

        TextObject = GameObject.Find("Text").GetComponent<Text>();

        UnityEngine.Debug.Log("Foo Function from C++ DLL: " + FooPluginFunction().ToString());
    }

    void Update()
    {
    }

    void OnApplicationQuit()
    {
        Debug.Log("Application ending after " + Time.time + " seconds.");
    }
}