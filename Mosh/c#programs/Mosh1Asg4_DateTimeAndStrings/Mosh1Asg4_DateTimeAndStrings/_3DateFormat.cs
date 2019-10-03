using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class _3DateFormat
    {
        public void DateCheck()
        {
            
            Console.WriteLine("please enter a date in the format of this in the 24 hr format eg 19:00 00:00 to 23:59");
            var input = Console.ReadLine();//*
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid");
            }

            var pattern = @"^(([0-1]{1}\d)|(2[0-3]{1})):[0-5]{1}\d$";//*
            var reg = new Regex(pattern);//*
            //var isDateCorrect = reg.IsMatch(input);//*

            var match = reg.Match(input);
            if (match.Success)
            {
                Console.WriteLine("valid\n");
                Console.WriteLine($"matched value is {match.Value}");
            }
            else
            {
                Console.WriteLine("invalid\n");
            }


            
            //var strArr = input.Split(':');
            //var strNew = String.Join("", strArr);
            //var num = Convert.ToInt32(strNew);
        }
    }
}
//public void Exercise3()
//{
//    Console.Write("Enter time: ");
//    var input = Console.ReadLine();

//    if (String.IsNullOrWhiteSpace(input))
//    {
//        Console.WriteLine("Invalid Time");
//        return;
//    }

//    var components = input.Split(':');
//    if (components.Length != 2)
//    {
//        Console.WriteLine("Invalid Time");
//        return;
//    }

//    try
//    {
//        var hour = Convert.ToInt32(components[0]);
//        var minute = Convert.ToInt32(components[1]);

//        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
//            Console.WriteLine("Ok");
//        else
//            Console.WriteLine("Invalid Time");
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid Time");
//    }
//}
