using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSIOrderSubmit.Models
{
    public class ServiceResponse
    {
        public string Content { get; set; }
        public System.Net.Http.HttpResponseMessage ResponseMessage { get; set; }
    }
}
