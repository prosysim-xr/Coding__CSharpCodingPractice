using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _3Factorial1
    {
        public void Fact()
        {
            Console.WriteLine("Enter the num for which you wnat to find factoria\n");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine($"the factorial for {num} is 1");
            }
            else
            {
                int fact = 1;
                for (int i = num; i > 0; i--)
                {
                    fact *= i;
                }
                //-----------Alternate solution------------
                //var factorial = 1;
                //for (var i = 1; i <= number; i++)
                //    factorial *= i;
                //-----------------------------------------


                Console.WriteLine($"the factorial for {num} is {fact}");
            }

        }

        //public void TakeInput()
        //{
        //    Console.WriteLine("Enter the num for which you wnat to find factoria\n");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //}


        public int FactRecur(int num)
        {
            if(num == 1) { return 1; }
            return num*FactRecur(num-1);//stack overflow exception will be thrown if fact(1)=1 not defined
        }
    }
}
