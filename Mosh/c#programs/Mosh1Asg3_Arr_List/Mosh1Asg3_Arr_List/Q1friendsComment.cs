using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class Q1friendsComment
    {
        public void FrindsDisplay()
        {
            Console.WriteLine("please enter friends name\n");

            var list = new List<string> { };
            while (true)
            {
                
                var str = Console.ReadLine();
                if (String.IsNullOrEmpty(str))
                {
                    break;
                }
                list.Add(str);
                //if (str!="")
                //{
                //    list.Add(str);
                //}


                //if (str=="")
                //{
                //    break;
                //}
            }

            if (list.Count() == 1)
            {
                Console.WriteLine(list[0] + " liked your comment");
            }
            else if (list.Count() == 2)
            {
                Console.WriteLine($"{list[0]} and {list[1]} " + "liked your comment");
            }
            else if(list.Count() >2)
            {
                Console.WriteLine($"{list[0]}, {list[1]} and {list.Count()-2} other " + "liked your comment");
            }
            //else
            //{
            //    Console.WriteLine();
            //}
        }
    }
}
