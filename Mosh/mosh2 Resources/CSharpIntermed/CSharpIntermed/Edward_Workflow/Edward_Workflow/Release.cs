namespace Edward_Workflow
{
    class Release : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Application in release stage now.");
        }
    }
}
