using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class Shipment
    {
        public string TrackingNumber { get; set; }

        public DateTime ShipDate { get; set; }

        public string ShipViaCode { get; set; }

        public decimal EstimatedShippingCharge { get; set; }

        public decimal PackageWeight { get; set; }
    }
}