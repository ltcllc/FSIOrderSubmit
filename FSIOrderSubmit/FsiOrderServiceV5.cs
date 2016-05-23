using Models.OrderServiceV5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FSIOrderSubmit
{
    public class FsiOrderServiceV5
    {
        readonly Uri baseAddress;
        readonly string requestUri;
        readonly string authString;

        public FsiOrderServiceV5()
        {
            if (FSIOrderSubmit.Properties.Settings.Default.TestMode == true)
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress);
                this.requestUri = FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey;
            }
            else
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress);
                this.requestUri = FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
            }

            this.authString = "";
        }

        public async Task<HttpResponseMessage> SendOrder(string orderXml)
        {
            string responseData = string.Empty;
            var fail = new Fail();
            var success = new Success();

            var xml = new StringContent(orderXml, System.Text.Encoding.Default, mediaType: "application/xml");

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);

                using (var response = await httpClient.PostAsync(requestUri: this.requestUri, content: xml))
                {
                    responseData = await response.Content.ReadAsStringAsync();

                    return response;
                }
            }
        }
    }
}
