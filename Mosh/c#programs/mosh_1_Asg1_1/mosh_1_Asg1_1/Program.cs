using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mosh_1_Asg1_1
{

    class Program
    {
        static void Main(string[] args)
        {
            


            bool exit = false;
            while(exit!=true)
            {
                Console.WriteLine("--------------------------------------------------------\n"+
                    "Enter 1 for MaximumNum\n" + 
                    "Enter 2 for NumValidCheck\n"+
                    "Enter 3 for CheckVIew\n"+ 
                    "Enter 4 for speedAnalyze\n"+
                    "Enter 0 for exit\n"+ 
                    "--------------------------------------------------------\n");
                Console.WriteLine("you chose option:");
                var option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            MaximumNum max1 = new MaximumNum();
                            max1.FindMaxNum();

                            break;
                        }
                    case 2:
                        {
                            NumValidity.NumValidCheck();
                            break;
                        }
                    case 3:
                        {
                            CheckImageView view1 = new CheckImageView();
                            
                            Console.WriteLine("\n\nNow enter the length and breadth: ");
                            view1.Plength = Convert.ToInt32(Console.ReadLine());
                            view1.Pbredth = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"length is {view1.Plength}, bredth is {view1.Pbredth}");
                            view1.CheckView(view1.Plength, view1.Pbredth);
                            break;
                        }
                    case 4:
                        {
                            SpeedLimit speed1 = new SpeedLimit();
                            Console.WriteLine("enter speed");
                            speed1.Pspeed= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter speedlimit");
                            speed1.PspeedLimit = Convert.ToInt32(Console.ReadLine());
                            speed1.AnalyzeSpeed(speed1.Pspeed, speed1.PspeedLimit);

                            break;
                        }
                    case 0:
                        {
                            exit = true;

                            break;
                        }

                }
            }
            
        }
    }

}
