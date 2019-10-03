using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Asg_workflowEngine
{
    class WorkflowEngineEngine
    {
        public void Run(WorkFlow workflow)
        {
            foreach (var work in workflow)
            {
                Execute(work);
            }
            
        }
        public void Execute(WorkFlow work)
        {

        }
    }
}
