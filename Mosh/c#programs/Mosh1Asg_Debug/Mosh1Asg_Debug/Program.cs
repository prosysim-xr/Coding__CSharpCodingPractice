using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int> { 2, 5, 1, 4, 3, 6 };
            var smallest_3List = GetSmallest_3(numList, 3);
            foreach (var value in smallest_3List)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }

        public static List<int> GetSmallest_3(List<int> numList, int count)
        {

            var sortedList = new List<int> { };
            for(var i =0; i<numList.Count; i++)
            {
                sortedList.Add(numList[i]);
            }
            //code for sorting
            //for(var i= 0; i<sortedList.Count-1; i++)
            //{
            //    for(var j=i+1; j<sortedList.Count; j++)
            //    {
            //        if (sortedList[i] > sortedList[j])
            //        {
            //            var temp = sortedList[i];
            //            sortedList[i] = sortedList[j];
            //            sortedList[j] = temp;
            //        }
            //    }
            //}

            sortedList.Sort();


            var smallList = new List<int> { };
            for(var i = 0; i<3; i++)
            {
                smallList.Add(sortedList[i]);
            }

            return smallList;
        }
    }
}
