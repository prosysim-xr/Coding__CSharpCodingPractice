using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_upcasting_inheritence_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackObj = new Stack();
            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);

            //Console.WriteLine("expected output is: \n3\n2\n1");

            //Console.WriteLine("Your output is: ");
            //Console.WriteLine(stackObj.Pop());
            //Console.WriteLine(stackObj.Pop());
            //Console.WriteLine(stackObj.Pop());
            stackObj.Clear();
            //stackObj.Push(3);
            foreach (var value in stackObj)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(stackObj.Pop());
            Console.ReadKey();
        }
    }
}
