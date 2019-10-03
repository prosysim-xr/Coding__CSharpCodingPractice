using System;
using SotirisStopWatch;

namespace StopWatch

{

    class Program

    {

        static void Main(string[] args)

        {

            bool quitProgramm = false;

            bool currentSituation = false;



            while (!quitProgramm)

            {

                Console.WriteLine("Enter 'Start' to start the watch,'Stop' to to stop the watch or 'Quit' to quit the console:");

                string inputFromUser = Console.ReadLine();

                Duration duration = new Duration();

                try

                {

                    if (!string.IsNullOrWhiteSpace(inputFromUser) && inputFromUser.ToLower() == "start" && currentSituation == false)

                    {

                        Console.WriteLine("Starting the watch\n");

                        duration.Start = DateTime.Now;

                        Console.WriteLine("Enter 'stop' when you want to stop the watch and see the Duration:");

                        currentSituation = true;

                        inputFromUser = Console.ReadLine();

                    }



                    if (inputFromUser.ToLower() == "start" && currentSituation == true)

                    {

                        throw new InvalidOperationException("Cannot perform the same command,please try again\n");

                    }



                    if (!string.IsNullOrWhiteSpace(inputFromUser) && inputFromUser.ToLower() == "quit")

                    {

                        quitProgramm = true;

                        Console.WriteLine("exit programm");

                        break;

                    }



                    if (!string.IsNullOrWhiteSpace(inputFromUser) && inputFromUser.ToLower() == "stop" && currentSituation == true)

                    {

                        Console.WriteLine("Stoping the watch\n");

                        duration.Stop = DateTime.Now;

                        duration.calculateDuration();

                        currentSituation = false;

                    }

                }

                catch (Exception)

                {



                    Console.WriteLine("Cannot perfom the same command!Please try again");

                }

            }

        }

    }



}

