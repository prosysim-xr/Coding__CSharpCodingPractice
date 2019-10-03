using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            while(exit != true)
            {
                Console.WriteLine();
                Console.WriteLine(
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "Please enter 1 for Stopwatch\n" +
                "Please enter 2 for moshes Stopwatch with wrong practice \n"+
                "Please enter 3 for moshes Stopwatch with good practice \n" +
                "Please enter 4 for BlogPost\n" +
                "Please enter 0 for exit\n" +
                "-------------------------------------------------");
                Console.Write("you entered: ");
                var option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                switch (option)
                {
                    case 1:
                        {
                            var objStopWatch = new StopWatch();
                            Console.WriteLine(
                                    "..........................................\n" +
                                    "Enter a for start the timer\n" +
                                    "Enter s for end the timer \n" +
                                    "Enter x for  exit \n" +
                                    ".........................................." );

                            var prevChar = 'q';
                            var exit1 = false;
                            while(exit1 != true)
                            {
                                var newChar = Convert.ToChar(Console.ReadLine().ToLower());
                                if (prevChar == 'a'&& newChar == 'a')
                                {
                                    Console.WriteLine("Invalid please enter s to stop");
                                }
                                if (prevChar == 's' && newChar == 's')
                                {
                                    Console.WriteLine("Invalid please enter a to start");
                                }

                                if (newChar == 'a'&&(prevChar=='q'||prevChar!='a'))
                                {
                                    objStopWatch.Start();
                                }
                                if (newChar == 's' && (prevChar == 'q' || prevChar != 's'))
                                {
                                    objStopWatch.Stop();
                                    Console.WriteLine("the duration of the stop watch is: "+ objStopWatch.Duration());
                                    Console.WriteLine();
                                }
                                if (newChar == 'x')
                                {
                                    exit1 = true;
                                }

                                prevChar = newChar;

                            }
                            break;
                        }
                    case 2:
                        {
                            var objSW = new StopWatch_mosh_wrong_way();
                            for (var i = 0; i < 2; i++)
                            {
                                objSW.Start(DateTime.Now);
                                //[a]bec i hv access in public properties i can do this
                                //[a]objSW.P_startTime = DateTime.Today.AddDays(1);
                                //[b]similarly we can messup here
                                //[b]objSW.Start(DateTime.Now.AddDays(1)); ...i can mess in code
                                Thread.Sleep(1000);
                                objSW.Stop(DateTime.Now);
                                //[a]and then i do this
                                //[a]objSW.P_endTime = DateTime.Today.AddYears(-1);
                                //[a]we just messed up bc properties were public

                                //[b]objSW.Stop(DateTime.Now.AddYears(-1));



                                Console.WriteLine(objSW.GetInterval().ToString());
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            var objSW = new StopWatch_mosh_wrong_way();
                            for (var i = 0; i < 2; i++)
                            {
                                objSW.Start(DateTime.Now);
                                Thread.Sleep(1000);
                                objSW.Stop(DateTime.Now);

                                Console.WriteLine(objSW.GetInterval().ToString());
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 4:
                        {
                            var objW = new BlogWriter();
                            var objR = new BlogReader();
                            Console.WriteLine(
                                ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                                "press a for login as reader\n"+
                                "press b for login as writter\n"+
                                "press x for exit\n"+
                                "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                            var option1 = Convert.ToChar(Console.ReadLine().ToLower());
                            var exit1 = false;
                            while(exit1!= true)
                            {
                                switch (option1)
                                {
                                    case 'a':
                                        {
                                            Console.WriteLine(
                                                ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n" +
                                                "press 1 for show\n" +
                                                "press 2 for lile\n" +
                                                "press 3 for dislike\n" +
                                                "press 0 for exit\n" +
                                                "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                                            var option2 = Convert.ToInt32(Console.ReadLine());
                                            var exit2 = false;
                                            while (exit2 != true)
                                            {
                                                switch (option2)
                                                {
                                                    case 1:
                                                        {
                                                            objR.Show(objW, objR);
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            objR.GiveLikes();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            objR.GiveDislikes();
                                                            break;
                                                        }
                                                    case 0:
                                                        {
                                                            exit = true;
                                                            break;
                                                        }
                                                }
                                            }
                                            break;
                                        }

                                    case 'b':
                                        {
                                            objW.Write();
                                            break;
                                        }

                                    case 'x':
                                        {
                                            exit = true;
                                            break;
                                        }
                                }  
                            }
                            break;
                        }
                    case 0:
                        {
                            exit = true;
                            break;
                        }
                }
            }
            Console.ReadKey();


        }
    }
}
