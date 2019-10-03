using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_InterfaceAndTestability_Demo_correct
{
    public class Shipment
    {
        public DateTime ShippingDate { get; internal set; }
        public float Cost { get; internal set; }
    }
}
