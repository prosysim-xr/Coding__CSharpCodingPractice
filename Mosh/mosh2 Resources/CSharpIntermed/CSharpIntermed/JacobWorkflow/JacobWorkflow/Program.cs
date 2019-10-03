using System;
using System.Collections.Generic;

namespace JacobWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
        var workflow = new WorkFLowEngine();
        workflow.Run(new WorkFlow());
        }

    }


    class WorkFLowEngine
    {
        public WorkFLowEngine()
        {
            Console.WriteLine("Running Your Workflow!!");
        }
        public void Run(WorkFlow workFlow)
        {
        }
    }
    class WorkFlow
    {
        private IList<IWorkflowItem> _workFLowItem;

        public WorkFlow()
        {
            _workFLowItem = new List<IWorkflowItem>();
            AddWorkFLowItem(new UploadVideo());
            AddWorkFLowItem(new CallWebService());
            AddWorkFLowItem(new SendEmail());
            AddWorkFLowItem(new ChangeDatabaseStatus());
            IterateWorkflows();
        }
        private void AddWorkFLowItem(IWorkflowItem workflowItem)
        {
            _workFLowItem.Add(workflowItem);
        }
        private void IterateWorkflows()
        {
            foreach (var workflows in _workFLowItem)
            {
                workflows.Execute();
            }
        }


    }
    interface IWorkflowItem
    {
        void Execute();
    }
    class UploadVideo : IWorkflowItem
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video");
        }
    }
    class CallWebService : IWorkflowItem
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service that video is ready");
        }
    }
    class SendEmail : IWorkflowItem
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
    class ChangeDatabaseStatus : IWorkflowItem
    {
        public void Execute()
        {
            Console.WriteLine("DataBase status updated to Processing");
        }
    }
}
