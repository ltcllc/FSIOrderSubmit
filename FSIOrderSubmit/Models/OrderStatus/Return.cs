using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class Return
    {
       public string ItemNumber { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public int QuantityReturned { get; set; }

        public string ReturnReason { get; set; }

        public string Reference { get; set; }
        
        public DateTime ReturnDate { get; set; }
    }
}