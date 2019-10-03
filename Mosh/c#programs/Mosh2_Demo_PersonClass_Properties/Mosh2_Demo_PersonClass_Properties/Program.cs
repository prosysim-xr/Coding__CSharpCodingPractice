using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Demo_PersonClass_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 1, 1));
            //person.P_birthdate = new DateTime(1994, 1, 1);
            Console.WriteLine(person.P_age);
            Console.ReadKey();
        }
    }
}
