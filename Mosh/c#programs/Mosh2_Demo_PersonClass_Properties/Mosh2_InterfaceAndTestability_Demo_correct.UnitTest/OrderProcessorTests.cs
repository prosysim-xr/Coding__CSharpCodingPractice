using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mosh2_InterfaceAndTestability_Demo_correct.UnitTest
{
    [TestClass]//decorated with attributes which are meta data 
               //about classes and their members
               //they dont have any logic they are just markers
               //so that another application(ex: MS test runner) or assembly can take 
               //the data and dof someting about it
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //MethodName_Condition_Expectation
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());//passed fake object that is always working
            //var order = new Order();//instead this below
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }
        [TestMethod] // testcase2
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
            
        
    }

    public class FakeShippingCalculator: IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }

}
