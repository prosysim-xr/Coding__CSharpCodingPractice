using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_AccessModifier_Internal_demo_clss_lib
{
    class Customer
    {
        public int P_id { get; set; }
        public string P_name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(false);

            if (rating == 0)
            {
                Console.WriteLine("promoted to level 1");
            }
            else
            {
                Console.WriteLine("Promoted to level  2");
            }
        }
        //private int CalculateRating() //try to make this private only when CalculateRating() is stable use protected
        protected int CalculateRating(bool excludeOrder)
        {
            return 0;
        }
    }
}
