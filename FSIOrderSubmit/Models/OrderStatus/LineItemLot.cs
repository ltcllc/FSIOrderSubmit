using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FSIOrderSubmit.Models.OrderStatus
{
    public class LineItemLot
    {
        public string ItemNumber { get; set; }

        public string LotNumber { get; set; }

        public DateTime? LotExpirationDate { get; set; }

        public int Quantity { get; set; }
    }
}
