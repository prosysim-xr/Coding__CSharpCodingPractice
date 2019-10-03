using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _5MaximumNumber
    {
        public void MaxNum()
        {
            Console.WriteLine("Please enter no.s seperated by comma of which you want to \n" +
            "find the maximum number");
            var str = Console.ReadLine();
            var str1 = str.Replace(",", "");
            var str2 = str1.Replace(" ", "");
            Console.WriteLine(str2);
            //int strNum = Convert.ToInt32(str2);
            var numArr = new int[str.Length];
            foreach (var strCount in str2)
            {
                numArr[strCount - 1] = str2[strCount - 1];
            }
            var max = numArr[0];
            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] > max)
                {
                    max = numArr[i];
                    Console.WriteLine($"the maximum number is {max}");
                }
            }

        }
        //------------much better soln--------------------------
        public void Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
            //-------------------------------------------------------

        }
    }
}
