﻿using System.CodeDom;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text MotorNumberBox;
    public Text ValueBox;

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_destroy();

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_init();

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_zmq_interface_step();

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern float robosim_get_motor(int motor_id);

    [DllImport("CKSimEngineUnityPlugin")]
    private static extern void robosim_set_encoder(int encoder_id, float value);

    void Start()
    {
        Debug.Log("Starting the application...");

        // Initialize the ZMQ interface.
        robosim_zmq_interface_init();
    }

    void Update()
    {
        // Step the ZMQ interface to receive the latest motor data.
        robosim_zmq_interface_step();

        // Show the latest motor values in the text object and reuse those values for the encoders.
        for(int i = 0; i < 6; i++)
        {
            GameObject.Find("Motor" + i + "Value").GetComponent<Text>().text = robosim_get_motor(i).ToString();
            robosim_set_encoder(i, robosim_get_motor(i));
        }
    }

    void OnApplicationQuit()
    {
        // Close the ZMQ sockets.
        robosim_zmq_interface_destroy();

        Debug.Log("Application ending after " + Time.time + " seconds.");
    }
}