using System;
namespace Mosh2_InterfaceAndExtensibility_demo
{
    public class ConsoleLogger : ILogger
    {

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("message");
        }

        public void LogInfo(string message, DateTime now)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("message");
        }
    }
}