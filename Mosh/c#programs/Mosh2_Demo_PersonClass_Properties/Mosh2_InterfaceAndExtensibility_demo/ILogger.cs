using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_InterfaceAndExtensibility_demo
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message, DateTime now);
    }
}
