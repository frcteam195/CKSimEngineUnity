#include "zmqInterface.h"

extern "C"
{
    __declspec(dllexport) void robosim_zmq_interface_destroy() { robosim::zmq_interface::destroy(); }

    __declspec(dllexport) void robosim_zmq_interface_init() { robosim::zmq_interface::init(); }

    __declspec(dllexport) void robosim_zmq_interface_step() { robosim::zmq_interface::step(); }
}