using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _1CountDivBy3
    {
        public void CountDiv()
        {

            //int num = Convert.ToInt32(Console.ReadLine());
            var flag = 0;
            int num = 0;
            while (num < 100)
            {
                if (num % 3 == 0)
                {
                    flag++;
                }
                num++;
                // divCount = num++;//use of post increment understood here even though the code doesnt fit here

            }
            Console.WriteLine($"total number of numbers div by 3 between 1 to 100 are: {flag}\n");
        }
    }
}
