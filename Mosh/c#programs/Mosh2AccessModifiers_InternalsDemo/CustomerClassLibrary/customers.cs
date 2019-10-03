using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClassLibrary
{
    public class Customers
    {
        public int P_id { get; set; }
        public string P_name { get; set; }

        public void Promote()
        {
            var objcalculator = new RateCalculator();       
            //shouldnot do instantiation here bc it results in coupling
            //using interfaces this can be improved

            var rating = objcalculator.Calculate(this);//this in here refers to customer class object ...it somwhat looks like recursion
            Console.WriteLine("some promote logic");
        }
    }
}
