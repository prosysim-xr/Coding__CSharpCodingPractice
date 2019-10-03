
using System;

namespace Mosh2_InterfaceAndTestability_Demo_correct
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;       // now this is loose coupling
        

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // _shippingCalculator = new ShippingCalculator();             // now this is llose coupling
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            //validation; dont do too much else your code will be bloated with validations
            if (order.IsShipped)
            {
                throw new InvalidOperationException("this oder is already processed.");

            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}