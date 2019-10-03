namespace Mosh2_InterfaceAndTestability_Demo_correct
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator: IShippingCalculator
    {
        

        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)             //if we change this code not going to have impact on orderProcessor. infact now it doesnt know about shippingcalcularor it only know there is a chef not john the chef ie it know there is a class which will take care
            {
                return order.TotalPrice = 0.1f;
            }

            return 0;
        }
    }
}