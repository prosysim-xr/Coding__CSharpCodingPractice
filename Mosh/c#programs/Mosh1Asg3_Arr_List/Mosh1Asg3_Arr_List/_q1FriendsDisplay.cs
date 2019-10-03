using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class _q1FriendsDisplay
    {
        public void FreindDisplay()
        {
            var nameList = new List<string> { "suman", "sumesh", "manish", "sameer",
                "alan", "britnie", "chris", "david", "jack", "kane","bulbul","bunty" };

            var random = new Random();

            //var random1 = new Random();

            //var random2 = new Random();

            //var random3 = new Random();

            var friendsLiked = random.Next(1,10);


            var nameList2 = new List<string> { } ;
            for (var i = 0; i < friendsLiked; i++)
            {
                nameList2.Add("");
            }
            
            for (var i = 0; i < friendsLiked; i++)
            {
                if (i == 0)
                {
                    nameList2[i] = nameList[random.Next(0, 11)];
                }
                else
                {
                    int x = 1;
                    while (x>0)
                    {
                        int flag = 0;
                        nameList2[i] = nameList[random.Next(0, 11)];
                        for (var k = 0; k < i; k++)
                        {
                            if (nameList2[i] == nameList2[k])
                            {
                                flag++;
                            }
                        }

                        if (flag == 0)
                        {
                            break;
                        }
                    }  
                }
            }


            Console.WriteLine($"{nameList2[0]}, {nameList2[1]} and {nameList2.Count() - 2} others" +
                " liked your comment");
            Console.WriteLine();
            Console.WriteLine("So total of "+nameList2.Count() +
                " of your friends liked your comment:");

            foreach (string str in nameList2)
            {

                Console.WriteLine(str);

            }

            //for (var i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(nameList2[i]);
            //}

        }
    }
}
