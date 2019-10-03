using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class UnrepeatedNumberList
    {
        public void Rept()
        {
            Console.WriteLine("Please enter a number\n");
            var namesArr = new int[5];

            for (var i = 0; i < 5; i++)
            {
                namesArr[i] = Convert.ToInt32(Console.ReadLine());
                for (var j = 0; j < i; j++)
                {
                    if (namesArr[i] == namesArr[j])
                    {
                        Console.WriteLine("try again\n");
                        i--;
                        break;
                    }
                }
            }

            Array.Sort(namesArr);
            Array.Reverse(namesArr);


            Console.WriteLine();
            foreach (var value in namesArr)
            {
                Console.WriteLine(value);
            }

            //-------------------MOSHES SOLUTION------------------------------
            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a number: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You've previously entered " + number);
            //        continue;
            //    }

            //    numbers.Add(number);
            //}

            //numbers.Sort();

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //------------------------another----------------------------------
            //bool didSwap;
            //do
            //{
            //    didSwap = false;
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            int temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //            didSwap = true;
            //        }
            //    }
            //} while (didSwap);
            //for (int i = 0; i != arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //}
        }
    }
}
