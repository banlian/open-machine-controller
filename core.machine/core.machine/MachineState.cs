using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.machine
{
    public enum MachineState
    {
        EMGENCY,
        ERROR,
        MANUAL,
        AUTO,
    }


    public enum MachineAutoState
    {
        WAITRESET,
        RESETTING,
        WAITRUN,
        RUNNING,
        PAUSE,
    }
}
