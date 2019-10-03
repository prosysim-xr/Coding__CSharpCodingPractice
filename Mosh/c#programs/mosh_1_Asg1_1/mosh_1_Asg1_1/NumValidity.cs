using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_1_Asg1_1
{
    public class NumValidity
    {
        public static void NumValidCheck()
        {
            int num;
            Console.WriteLine("enter a num");
            var numStr1 = Console.ReadLine();
            num = Convert.ToInt32(numStr1);
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("the num is valid");
            }
            else
            {
                Console.WriteLine("the num is invalid");
            }

            //Console.ReadKey();
        }
    }
}
