using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSIOrderSubmit.Models.OrderServiceV5
{
    public class OrderServiceResponse
    {
        public string Content { get; set; }
        public System.Net.Http.HttpResponseMessage ResponseMessage { get; set; }
    }
}