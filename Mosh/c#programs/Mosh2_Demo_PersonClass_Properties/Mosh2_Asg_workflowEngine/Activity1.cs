using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Asg_workflowEngine
{
    class Activity1 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("\nActivity1 Started");
            Console.WriteLine("Activity1 Done\n");
        }
    }
}
