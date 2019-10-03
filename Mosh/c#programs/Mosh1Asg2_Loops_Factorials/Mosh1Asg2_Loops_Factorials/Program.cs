using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("-----------------------------------------\n" +
                    "Enter 1 for countDivBy3\n" +
                    "Enter 2 for print ok or sum uptill now \n" +
                    "Enter 3 for factorial method1\n" +
                    "Enter 4 for factorial method2\n" +
                    "Enter 5 for guess game\n" +
                    "Enter 6 for max of num entered\n" +
                    "Enter 0 to exit\n" +
                    "------------------------------------------");

                Console.WriteLine("enter option no.\n");

                Console.WriteLine("you chose option\n");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                switch (option)
                {
                    case 1:
                        {
                            var c = new _1CountDivBy3();
                            c.CountDiv();
                            // Console.WriteLine($"total number of numbers div by 3 are{c.PdivCount}\n"); not needed the geter and setter
                            break;
                        }
                    case 2:
                        {
                            var pr1 = new _2SumToPrintOK();
                            pr1.Printok1();
                            break;
                        }

                    case 3:
                        {
                            var objfact = new _3Factorial1();
                            objfact.Fact();
                            Console.WriteLine("YOU big c enter now some number, get some factorial\n");
                            var num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(objfact.FactRecur(num));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("please enter the number for its factorial\n");
                            var objfact2 = new _3Factorial2();
                            objfact2.Pnum = Convert.ToInt32(Console.ReadLine());
                            var factorialValue = objfact2.Fact2(objfact2.Pnum);
                            Console.WriteLine($"the factorial of {objfact2.Pnum} is {factorialValue}\n");
                            break;
                        }
                    case 5:
                        {
                            var objfact3 = new _3FactorialLargeNumbers();
                            objfact3.FactLarge();
                            break;
                        }
                    case 6:
                        {
                            _4GuessGame objGues = new _4GuessGame();
                            objGues.GuessIt();
                            break;
                        }
                    case 7:
                        {
                            var objmax = new _5MaximumNumber();
                            objmax.MaxNum();
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
