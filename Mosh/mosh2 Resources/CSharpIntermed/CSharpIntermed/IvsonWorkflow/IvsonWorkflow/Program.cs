using System;
using System.Collections.Generic;

namespace IvsonWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {

            var activities = new List<IActivity>()
            {
                new UploadVideo(),
                new NotifyWebService(),
                new NotifyOwner(),
                new ChangeVideoStatus()
            };

            var workflow = new Workflow(activities);
            workflow.Run();
        }
    }

    public interface IActivity
    {
        void Run();
    }


    public class UploadVideo : IActivity
    {
        public void Run()
        {
            Console.WriteLine("The video is being uploaded.");
        }
    }

    public class NotifyWebService : IActivity
    {
        public void Run()
        {
            Console.WriteLine("The WebService has been notified that there's a new video to be encoded.");
        }
    }


    public class NotifyOwner : IActivity
    {
        public void Run()
        {
            Console.WriteLine("The owner of the video has been notified.");
        }
    }


    public class ChangeVideoStatus : IActivity
    {
        public void Run()
        {
            Console.WriteLine("The video is now being processed.");
        }
    }


    public class Workflow
    {
        public Workflow(List<IActivity> activities)
        {
            _activities = activities;
        }

        private List<IActivity> _activities;

        public void Run()
        {
            foreach (var activity in _activities)
                activity.Run();
        }
    }














}
