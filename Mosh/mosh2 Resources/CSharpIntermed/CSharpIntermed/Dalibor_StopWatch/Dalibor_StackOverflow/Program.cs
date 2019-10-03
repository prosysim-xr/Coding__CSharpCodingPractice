using System;

namespace Dalibor_StopWatch
{
 class Program
 {
  static void Main()
  {
   Console.WriteLine("1.. Stopwatch - normal usage");
   Console.WriteLine("2.. Stopwatch - raise the error on purpose");
   Console.WriteLine("--------------------------------------------");
   Console.Write("Please enter your choice [1-2]: ");
 
   switch (Convert.ToInt16(Console.ReadLine()))
   {
    case 1:
     TestCase1();
     break;
    case 2:
     TestCase2();
     break;
   }
 
   void TestCase1()
   {
    // Test Case 1: Normal behaviour
 
    var stopWatch = new StopWatch();
    var isItNow = "";
 
    Console.Write("Say when you're ready to start by typing 'now': ");
    while (true)
    {
     isItNow = Console.ReadLine();
     if (isItNow.ToUpper() == "NOW")
      break;
    }
 
    stopWatch.Start();
 
 
    Console.Write("The stopwatch is now running...");
    Console.WriteLine();
    Console.Write("Say when you're ready to stop by typing 'stop': ");
    while (true)
    {
     isItNow = Console.ReadLine();
     if (isItNow.ToUpper() == "STOP")
      break;
    }
 
    stopWatch.Stop();
    Console.WriteLine(@"Stopwatch running time: {0}", stopWatch.PassedTimeSpan);
   }
 
 
   void TestCase2()
   {
    //Test Case 2: Get exception thrown by the class
    var stopWatch = new StopWatch();
    var isItNow = "";
 
 
    Console.Write("Say when you're ready to start by typing 'now': ");
    while (true)
    {
     isItNow = Console.ReadLine();
     if (isItNow.ToUpper() == "NOW")
      break;
    }
    stopWatch.Start();
 
 
    Console.Write("Say when you're ready to start by typing 'now': ");
    while (true)
    {
     isItNow = Console.ReadLine();
     if (isItNow.ToUpper() == "NOW")
      break;
    }
 
    try
    {
     stopWatch.Start();
    }
    catch (InvalidOperationException e)
    {
     Console.WriteLine(@"Error restarting stopwatch: {0}", e.Message);
    }
 
   }
 
 
  }
 }
}