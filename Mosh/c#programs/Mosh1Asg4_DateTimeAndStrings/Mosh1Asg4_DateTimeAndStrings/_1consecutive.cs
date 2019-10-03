using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class _1consecutive
    {
        public void CheckConsecutive()
        {

            Console.WriteLine("Give a numbers seperated by hyphens\n");
            var str = Console.ReadLine();
            var strArr = str.Trim().Split('-');

            //to convert strArr to numList then to numArr
            //---------start--------------------------------
            
            var numList = new List<int> { };
            foreach(var value in strArr)
            {
                numList.Add(Convert.ToInt32(value));
            }

            var numArr = new int[numList.Count];
            for(var i=0; i<numList.Count; i++)
            {
                numArr[i] = numList[i];
            }
            //---------------end-----------------------------

            //~~~~~~~~~~~~~~~~~~extra~~~~~~~~~~~~~~~~~~~~~~~~

            //---------to convert strArr to strList----------
            //var strList = new List<string> (strArr);

            //---------to convert strArr to numArr directly--
            //var numArr = new int[strArr.Length];

            //Console.WriteLine(String.Join("/",strArr));
            //Console.WriteLine(String.Join("/", strList));
            //Console.WriteLine(String.Join("/", numList));
            //Console.WriteLine(String.Join("/", numArr));

            //~~~~~~~~~~~~~~~~end extra~~~~~~~~~~~~~~~~~~~~~~~

            
            //numArr2 with sorting
            var numArr2 = new int[numArr.Length];
            Array.Copy(numArr, numArr2, numArr.Length);
            
            for(var i =0; i<numArr2.Length-1; i++)
            {
                for (var j = i+1; j <numArr2.Length; j++)
                    if (numArr2[i] > numArr2[j])
                    {
                        var temp = numArr2[i];
                        numArr2[i] = numArr2[j];
                        numArr2[j] = temp;
                    }
            }

            //to check consecutivity
            var flag = 0;
            for (var i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == numArr2[i])
                {
                    flag++;
                }
                
            }
            if (flag == numArr.Length)
            {
                Console.WriteLine("consecutive");
            }
            else if (flag >numArr.Length||flag<numArr.Length)
            {
                Console.WriteLine("not consecutive");
            }

            ////var isConsecutive = true;
            ////for (var i = 1; i < numbers.Count; i++)
            ////{
            ////    if (numbers[i] != numbers[i - 1] + 1)
            ////    {
            ////        isConsecutive = false;
            ////        break;
            ////    }
            ////}


            ////to display
            //Console.WriteLine("1st " +String.Join("/", numArr2));


            ////numArr3 sorting
            //var numArr3 = new int[numArr.Length];
            //Array.Copy(numArr, numArr3, numArr.Length);
            //Array.Sort(numArr3);

            //Console.WriteLine("2nd " +String.Join("/", numArr3));


            ////numList2 sorting

            //var numList2 = new List<int>(numList);
            //numList.Sort();
            //Console.WriteLine("3rd "+String.Join("/", numList2));

        }
    }
}
