using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class _2DuplicateDisplay
    {
        public void DuplDisp()
        {
            Console.WriteLine("please enter number seperated by comma example 12-23-45\n");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
                
            var strArr = input.Split('-');
            var numList = new List<int>();
            foreach(var value in strArr)
            {
                numList.Add(Convert.ToInt32(value));
            }

            for(var i=0; i < numList.Count-1; i++)
            {
                var flag = 0;
                for(var j = i+1; j < numList.Count; j++)
                {
                    if (numList[i] == numList[j])
                    {
                        flag++;
                        break;
                    }
                }
                if (flag > 0)
                {
                    Console.WriteLine("duplicate value is present\n");
                    break;
                }
            }
            //// ---------------alternative Method---------------
            //var uniques = new List<int>();
            //var includesDuplicates = false;
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //    else
            //    {
            //        includesDuplicates = true;
            //        break;
            //    }
            //}
            ////----------------end-------------------------------
        }
    }
}
