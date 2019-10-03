using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mosh2_Demo_ShapeClass_Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = new Text();
            Shape shape1 = text1;

            text1.P_width = 200;
            shape1.P_width = 100;

            Console.WriteLine(text1.P_width);

            //streamReader example
            //StreamReader reader = new StreamReader(new FileStream);
        }
    }
}
