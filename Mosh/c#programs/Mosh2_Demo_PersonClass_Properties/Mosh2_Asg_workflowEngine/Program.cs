using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Asg_workflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new WorkFlow();

            work.workList.Add(new Activity1());
            work.workList.Add(new Activity1());
            work.workList.Add(new Activity1());

            var workEngine = new WorkflowEngineEngine();
            workEngine.Run(work);
        }
    }
}
