using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Asg_workflowEngine
{
    class Activity2 :IActivity
    {
        public void Execute()
        {
            Console.WriteLine("\nActivity2 Started");
            Console.WriteLine("Activity2 Done\n");
        }
    }
}
