using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class Payment
    {
        public decimal Amount { get; set; }

        public string Method { get; set; }

        public string ReferenceNumber { get; set; }

        public string CreditCardNumber { get; set; }

        public string Status { get; set; }

        public DateTime PaymentProcessedDate { get; set; }
    }
}