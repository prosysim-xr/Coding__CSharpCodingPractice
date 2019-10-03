using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class UniqueResultDisplay
    {
        public void Unique()
        {
            var listx = new List<int> { };
            while (true)
            {
                Console.WriteLine("Enter a Number or type quit to exit\n");
                var str = Console.ReadLine();
                if(str.ToLower() == "quit")
                {
                    break;
                }
                listx.Add(Convert.ToInt32(str));
            }
            var total = listx.Count;
            var listNew = new List<int> { };
            for(var i=0; i<total; i++)
            {

                var num1 = listx[i];
                if (listNew.Contains(num1))
                {
                    total--;
                    continue;
                }
                //listNew[i] = listx[i];
                listNew.Add(num1);
            }



            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}

            foreach (var value in listNew)
            {
                Console.WriteLine(value);
            }
        }
    }
}
