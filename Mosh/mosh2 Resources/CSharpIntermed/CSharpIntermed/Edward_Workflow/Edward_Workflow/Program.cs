using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edward_Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Workflow();
 
            test.RegisterActivity(new TestSoftware());
            test.RegisterActivity(new RequirementsAnalyze());
            test.RegisterActivity(new DevelopeSoftware());
            test.RegisterActivity(new Release());
 
            var workflow = new WorkflowEngine();
            workflow.Run(test);
        }
    }
}
