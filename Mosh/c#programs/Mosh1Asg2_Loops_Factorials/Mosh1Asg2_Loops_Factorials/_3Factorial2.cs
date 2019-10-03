using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _3Factorial2
    {
        private int num;
        //public int Pnum { get; set; } easiest way of defining get and setter in c#
        public int Pnum
        {
            get => num;
            set => num = value;
        }
        //public Factorial2(int num) => this.num = num;  
        //If constructor is defined in this way 
        //then we have to provide parameters even in while creating an object of the class
        //Factorial2-->as Factorial objfact2 = new Factorial2(25)

        public int Fact2(int num)
        {
            //var fact = 1;
            if (num == 0)
            {
                return 0;
            }
            else
            {
                var fact = 1;
                for (int i = num; i > 0; i--)
                {
                    fact *= i;
                }
                return fact;
            }

            //{
            //    try
            //    {

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("invalid number for a factorial");
            //    }
            //    //return 0;//exception can be raised here. Sort of validation required.
            //}
        }
    }
}
