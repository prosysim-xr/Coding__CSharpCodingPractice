using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Asg_workflowEngine
{
    class Activity3: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("\nActivity3 Started");
            Console.WriteLine("Activity3 Done\n");
        }
    }
}
