using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerClassLibrary;

namespace Mosh2AccessModifiers_InternalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customers();
            var calculator = new CustomerClassLibrary.RateCalculator();//here is the use of internal
            //above line should be in that way that we are unable to instantiate in the first step...
        }
    }
}
