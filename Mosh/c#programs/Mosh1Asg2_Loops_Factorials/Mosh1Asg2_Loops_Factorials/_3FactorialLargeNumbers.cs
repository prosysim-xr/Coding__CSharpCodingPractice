using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _3FactorialLargeNumbers
    {
        ///to dos
        ///1st fun prototype then empty result array then 
        ///

        public void FactLarge()
        {
            Console.WriteLine("please enter a number of which you wnat to find the factorial");
            var num = Convert.ToInt32(Console.ReadLine());

            //empty array with 1st element initialised with 1
            var res = new int[1000];
            res[0] = 1;
            var resultSize = 1;
            int test = 5;
            
            for(var numIteration =2; numIteration<=num; numIteration++)
            {
                resultSize = Mul(numIteration, res, resultSize, test);
            }

            Console.WriteLine(resultSize);
            Console.WriteLine("the test must be is 6 what is actuly <" + test+"> If it is 5 primitive types new variable created every time it is passed in a function is proven");
            Console.Write($"the factorial of {num} is: ");//this proves primitive type  seperate var created
            var count = 0;
            for (var i =0; i<resultSize; i++)
            {
                Console.Write(res[resultSize-1-i]);
                count++;
            }
            Console.WriteLine("the count is"+ count);
        }


        public int Mul(int numIteration, int[] resu, int resultSize, int test)//instead of res resu still works because resu reference to same object ie. res
        {
            test++;
            Console.WriteLine("the value of test is " +test);
            Console.WriteLine();
            var carry = 0;

            for (var i = 0; i < resultSize; i++)
            {
            var prod = resu[i] * numIteration + carry;
            resu[i] = prod % 10;
            carry = prod / 10;
            }

            while (carry != 0)
            {
                resu[resultSize] = carry % 10;
                carry = carry / 10;
                resultSize++;
            }
            return resultSize;// without this return 100! dont come
        }
    }
}
