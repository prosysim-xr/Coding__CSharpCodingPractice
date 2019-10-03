using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_1_Asg1_1
{
    public class MaximumNum
    {
        public void FindMaxNum()
        {
            Console.WriteLine("enter two  numbers");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("1st number is greatrer than second number");
            }
            else
            {
                Console.WriteLine("2nd number is greater than 1st number");

            }


        }

        
    }
}
