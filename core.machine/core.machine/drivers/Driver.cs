using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.machine.drivers
{
    public interface IDriver
    {
        void Initialize(params object[] configs);

        void Terminate();

        void Update();
    }

  
}