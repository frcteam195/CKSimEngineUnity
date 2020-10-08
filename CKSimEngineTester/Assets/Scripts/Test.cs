﻿using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public Text TextObject;

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_destroy();

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_init();

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_step();

    void Start()
    {
        Debug.Log("Starting the application...");

        // Initialize the ZMQ interface.
        robosim_zmq_interface_init();

        // Get the text box object.
        TextObject = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update()
    {
        // Step the ZMQ interface to receive the latest motor data.
        robosim_zmq_interface_step();
    }

    void OnApplicationQuit()
    {
        // Close the ZMQ sockets.
        robosim_zmq_interface_destroy();

        Debug.Log("Application ending after " + Time.time + " seconds.");
    }
}