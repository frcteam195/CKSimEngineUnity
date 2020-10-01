using CKSimEngineUnity;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public string LatestTopic, LatestData;

    public Text TextObject;

    void Start()
    {

        UnityEngine.Debug.Log("Starting test...");

        TextObject = GameObject.Find("Text").GetComponent<Text>();

        SimEngine.InitializeSockets();
    }

    void Update()
    {
        bool Success = SimEngine.ReceiveControlMessage(out LatestTopic, out LatestData);

        if (Success)
        {
            TextObject.text = LatestData;
        }    
    }

    void OnApplicationQuit()
    {
        SimEngine.DisposeSockets();
        Debug.Log("Application ending after " + Time.time + " seconds.");
    }
}