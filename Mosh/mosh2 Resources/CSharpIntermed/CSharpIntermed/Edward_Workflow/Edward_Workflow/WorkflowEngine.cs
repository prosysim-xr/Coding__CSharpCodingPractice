
namespace Edward_Workflow
{
    class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach(IActivity item in workflow)
            {
                item.Execute();
            }
        }
    }
}
