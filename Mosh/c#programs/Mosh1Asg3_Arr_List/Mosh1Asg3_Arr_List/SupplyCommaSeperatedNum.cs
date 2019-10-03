using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class SupplyCommaSeperatedNum
    {
        public void ListNum()
        {
            Console.WriteLine(" please enter comma seperated number\n");
            var str = Console.ReadLine();
            var list = new List<string> { };
            

            var seperatorArr = new char[] { ',', ' ' };
            var stringArr =str.Split(seperatorArr,
            StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < stringArr.Length; i++)
            {
                if (i == 0)
                {
                    list.Add(stringArr[0]);
                    list.Add(stringArr[1]);
                    i++;
                    i++;

                    while (true)
                    {

                        if (list[1] == list[0])
                        {
                            list[1] = stringArr[i];
                            i++;
                            continue;

                        }
                        break;
                    }
                }
                else
                {
                    list.Add(stringArr[i]);
                    for (var j = 0; j < list.Count-1; j++)
                    {

                        if (list[list.Count-1] == list[j])
                        {
                            list.Remove(list[list.Count-1]);
                            i++;
                            break;
                        }
                    }
                }
            }

            if (stringArr.Length >= 5)
            {
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.WriteLine("---------------------------------------------------------------------\n");

                foreach (var value in list)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("---------------------------------------------------------------------\n");
                list.Sort();
                foreach (var value in list)
                {
                    Console.WriteLine(value);
                }


                //break;
            }
            else if (stringArr.Length < 5)
            {
                Console.WriteLine("invalid input try again\n");
            }

        }
    }
}
///// <summary>
///// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
///// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
///// the 3 smallest numbers in the list.
///// 
///// </summary>
//public void Exercise5()
//{
//    string[] elements;
//    while (true)
//    {
//        Console.Write("Enter a list of comma-separated numbers: ");
//        var input = Console.ReadLine();

//        if (!String.IsNullOrWhiteSpace(input))
//        {
//            elements = input.Split(',');
//            if (elements.Length >= 5)
//                break;
//        }

//        Console.WriteLine("Invalid List");
//    }

//    var numbers = new List<int>();
//    foreach (var number in elements)
//        numbers.Add(Convert.ToInt32(number));

//    var smallests = new List<int>();
//    while (smallests.Count < 3)
//    {
//        // Assume the first number is the smallest
//        var min = numbers[0];
//        foreach (var number in numbers)
//        {
//            if (number < min)
//                min = number;
//        }
//        smallests.Add(min);

//        numbers.Remove(min);
//    }

//    Console.WriteLine("The 3 smallest numbers are: ");
//    foreach (var number in smallests)
//        Console.WriteLine(number);
//}
//    }
//}
