using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class ReverseNum
    {
        public void Reverse1()
        {
            Console.WriteLine("Plese enter a number\n");
            var numStr = Console.ReadLine();
            var num = Convert.ToInt32(numStr);

            var sum = 0;
            //int digit;
            //for (var i=0; i<numStr.Length; i++)
            //{

            //    digit = num % 10;
            //    num = num / 10;
            //    sum = Convert.ToInt32(sum + digit * Math.Pow(10, numStr.Length-1-i));
            //}
            while (num > 0)
            {
                sum = sum * 10 + num % 10;
                num = num / 10;

            }
            Console.WriteLine($"reversed number is {sum}.\n");

            //// Iterative function to  
            //// reverse digits of num 
            //static int reversDigits(int num)
            //{
            //    int rev_num = 0;
            //    while (num > 0)
            //    {
            //        rev_num = rev_num * 10 + num % 10;
            //        num = num / 10;
            //    }
            //    return rev_num;
            //}



        }
    }
}
