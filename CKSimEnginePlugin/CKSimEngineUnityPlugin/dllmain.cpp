#include <zmq.h>

extern "C"
{
    // Necessary ZMQ context.
    static void* zmq_context = NULL;

    // Control and status sockets.
    static void* control_subscriber_socket = NULL;

    __declspec(dllexport) float FooPluginFunction() { return 5.0F; }

    __declspec(dllexport) bool InitializeControlSocket() 
    {
        // Create a new context.
        zmq_context = zmq_ctx_new();

        // Close and recreate the control subscriber socket.
        zmq_close(control_subscriber_socket);
        control_subscriber_socket = zmq_socket(zmq_context, ZMQ_SUB);

        return false; 
    }
}