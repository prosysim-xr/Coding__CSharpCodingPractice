using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_InterfaceAndTestability_Demo_correct
{

    class Program
    {
        static void Main(string[] args)
        {                                                                      //main method is like match makeer. it knows  different concrete type and tie them together           
            var orderProcessor = new OrderProcessor(new ShippingCalculator()); //here in main only concrete class and the parameter passed is also concrete class //here we need instance of Ishiiping calcularor which can be done because of abouve reason
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 110f };
            orderProcessor.Process(order);

            
        }
    }
}
