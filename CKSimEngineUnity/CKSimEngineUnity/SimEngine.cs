using NetMQ.Sockets;
using UnityEngine;
using System;
using System.Diagnostics;
using NetMQ;
using System.Threading;

namespace CKSimEngineUnity
{

    public class SimEngine
    {
        public static SubscriberSocket ControlSubscriber = new SubscriberSocket();

        public static void DisposeSockets()
        {
            ControlSubscriber.Dispose();
        }

        public static void InitializeSockets()
        {
            try
            {
                // Create the control subscriber and subscribe to the default topic.
                ControlSubscriber.Connect("tcp://localhost:10502");
                ControlSubscriber.Subscribe("");

                UnityEngine.Debug.Log("Created socket the status socket!");
            }
            catch (Exception Except)
            {
                UnityEngine.Debug.Log("Exception occur when creating the status socket!");
                UnityEngine.Debug.Log("Message: " + Except.Message);
            }
        }

        public static bool ReceiveControlMessage(out string Topic, out string Data)
        {
            Topic = "";
            Data = "";

            bool Success = ControlSubscriber.TryReceiveFrameString(out string Message);

            if (Success)
            {
                string[] SplitMessage = Message.Split(' ');

                Topic = SplitMessage[0];
                Data = SplitMessage[1];
            }

            return Success;
        }
    }
}