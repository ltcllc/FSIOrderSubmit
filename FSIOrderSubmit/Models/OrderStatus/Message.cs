using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FSIOrderSubmit.Models.OrderStatus
{
   public class Message
    {
        public string MessageText { get; set; }

        public string Type { get; set; }
    }      
}