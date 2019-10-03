using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine(
                    "\n-------------------------------------------------\n"+
                    "Please enter 1 for consecutive number check, sorting + array + list manipulations\n"+
                    "Please enter 2 for finding duplicate in the given  \n" +
                    "Please enter 3 for id date correct format \n" +
                    "Please enter 4 for hungarian pascal\n" +
                    "Please enter  for \n" +
                    "Please enter  for \n" +
                    "Please enter  for \n" +
                    "Please enter  for \n" +
                    "Please enter 0 for exit\n"+
                    "-------------------------------------------------\n");
                
                var option = Convert.ToInt32(Console.ReadLine());
                Console.Write("You entered ");
                Console.WriteLine(option);
                Console.WriteLine(
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                switch (option)
                {
                    case 1:
                        {
                            var objCons = new _1consecutive();
                            objCons.CheckConsecutive();
                            break;
                        }
                    case 2:
                        {
                            var objDup = new _2DuplicateDisplay();
                            objDup.DuplDisp();
                            break;
                        }
                    case 3:
                        {
                            var objDate = new _3DateFormat();
                            objDate.DateCheck();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("please inter words seperated by space\n");
                            var input = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(input))
                            {
                                Console.WriteLine("Error");
                                return;
                            }
                            var objCase = new _4PascalCaseConversion();
                            Console.Write("Pascal case form :");
                            objCase.PascalCase(input);
                            Console.Write("Hungarian case form :");
                            Console.WriteLine(objCase.HungarianCase(input));

                            objCase.Exercise4();
                            
                            break;
                        }
                    case 5:
                        {
                            var objVowel = new _5CountVowels();
                            objVowel.Exercise5();
                            objVowel.VowelCount();
                            objVowel.VowelCount2();
                            objVowel.VowelCountOnlyTotal();
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
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
