using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _2SumToPrintOK
    {
        public void Printok1()
        {
            //var strNum = 0;
            //var exit = false;
            //while(!exit)
            //{

            //    Console.WriteLine("Enter a num to show sum uptil now or Enter OK to exit\n");
            //    var str1 = Console.ReadLine();

            //    if (str1 == "ok")
            //    {
            //        exit = true;
            //    }
            //    else if (str1 == " ")
            //    {
            //        exit = true;
            //    }
            //    else if (str1 == String.Empty)
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        strNum += Convert.ToInt32(str1);
            //        Console.WriteLine($"The sum uptill now is: {strNum} \n");

            //    }



            //}

            ////-------------------alternate soln-----------------

            {
                var sum = 0;
                while (true)
                {
                    Console.Write("Enter a number (or 'ok' to exit): ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "ok")
                        break;
                    var strInt = Convert.ToInt32(input);
                    sum += strInt;
                }
                Console.WriteLine("Sum of all numbers is: " + sum);
            }
            ////----------------------------------------------------

        }
    }

}
