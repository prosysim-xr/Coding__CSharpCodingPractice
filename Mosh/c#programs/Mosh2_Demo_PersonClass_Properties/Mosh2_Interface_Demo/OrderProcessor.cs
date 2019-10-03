//namespace Mosh2_InterfaceAndTestability_Demo
//{
//    internal class OrderProcessor
//    {
//        private readonly ShippingCalculator _shippingCalculator;//tightcoupling
//        public OrderProcessor()
//        {
//            _shippingCalculator = new ShippingCalculator();//tightcoupling here shipping calculator instantiated
//        }

//        public void Process(Order order)
//        {
//            //validation
//            if (order.IsShipped)
//            {
//                throw new InvalidOperationException("this oder is already processed.");

//            }

//            order.Shipment = new Shipment
//            {                                                        //this block is test code
//                Cost = _shippingCalculator.CalculateShipping(order), //there dependency to _shippingCalculator in all code going to be a problem
//                ShippingDate = DateTime.Today.AddDays(1)             // resolved by interface
//            };
//        }
//    }
//}