using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IElectronicDevice
    {
        // We want each device to have 
        // these capabilities
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();

    }
}
