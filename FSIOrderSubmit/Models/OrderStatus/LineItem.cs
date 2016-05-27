using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class LineItem
    {
        public string ShortItemNumber { get; set; }

        public string LongItemNumber { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int QuantityOrdered { get; set; }

        public int QuantityShipped { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }
    }
}