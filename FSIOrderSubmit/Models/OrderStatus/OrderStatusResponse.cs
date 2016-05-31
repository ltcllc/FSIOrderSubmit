using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class OrderStatusResponse
    {
        public string OrderNumber { get; set; }

        public int FsiOrderNumber { get; set; }

        public string OrderStatus { get; set; }

        public DateTime PostingDate { get; set; }

        public string OwnerCode { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShipAfterDate { get; set; }

        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }

        public string ShipViaCode { get; set; }

        public decimal ShippingCharge { get; set; }

        public decimal HandlingCharge { get; set; }

        public decimal TotalTax { get; set; }

        public decimal OrderTotal { get; set; }

        public List<Payment> Payments { get; set; }

        public string Email { get; set; }

        public string PromotionCode { get; set; }

        public List<Message> Messages { get; set; }

        public UserDefinedField UserDefinedField { get; set; }

        public string OrderSourceCode { get; set; }

        public string OrderSourceName { get; set; }

        public List<Shipment> Shipments { get; set; }

        public List<LineItem> LineItems { get; set; }

        public List<OrderHold> OrderHolds { get; set; }

        public bool HasReturns { get; set; }

        public List<Return> Returns { get; set; }

        public int OriginalInvoiceNumber { get; set; }

        public List<LineItemLot> LineItemLots { get; set; }

        public List<LineItemSerial> LineItemSerials { get; set; }

    }
}