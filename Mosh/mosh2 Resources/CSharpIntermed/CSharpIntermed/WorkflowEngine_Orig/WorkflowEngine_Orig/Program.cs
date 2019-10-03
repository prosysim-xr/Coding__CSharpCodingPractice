using System;
using System.Collections.Generic;

namespace WorkflowEngine_Orig
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine workFlow = new WorkFlowEngine();
            workFlow.AddWorkFlowObject(new VideoUploader());
            workFlow.AddWorkFlowObject(new CallWebService());
            workFlow.AddWorkFlowObject(new SendEmail());
            workFlow.AddWorkFlowObject(new ChangeStatus());

            workFlow.Run();

            Console.ReadLine();

        }
    }


    interface IIWorkFlow
    {
        void Execute();
    }

    class VideoUploader : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }

    class CallWebService : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    class SendEmail : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }

    class ChangeStatus : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status...");
        }
    }

    class WorkFlowEngine
    {
        private List<IIWorkFlow> T;

        public WorkFlowEngine()
        {
            T = new List<IIWorkFlow>();
        }

        public void AddWorkFlowObject(IIWorkFlow iObject)
        {
            T.Add(iObject);
        }

        public void RemoveWorkFlowObject(IIWorkFlow iObject)
        {
            T.Remove(iObject);
        }

        public void Run()
        {
            foreach (IIWorkFlow I in T)
            {
                I.Execute();
            }
        }
    }

}
