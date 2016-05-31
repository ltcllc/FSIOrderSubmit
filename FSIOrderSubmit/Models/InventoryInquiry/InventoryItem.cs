using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSIOrderSubmit.Models.InventoryInquiry
{
    public class InventoryItem
    {       
        public string LongItemNumber { get; set; }
        public string ShortItemNumber { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityAvailable { get; set; }
        public int QuantityCommitted { get; set; }
        public int QuantityBackOrdered { get; set; }
        public int QuantityOnReorder { get; set; }
        public string InventoryType { get; set; }
        public int ReorderPoint { get; set; }
        public int ReorderQuantity { get; set; }    
        public DateTime? LastReceiptDate { get; set; }
        public int? LastReceiptQuantity { get; set; }
        public string Category { get; set; }
        public string SellingUnit { get; set; }
        public int CartonQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string MasterUpc { get; set; }
        public string DimensionUpc { get; set; }
    }
}
