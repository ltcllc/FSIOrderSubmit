using FSIOrderSubmit.Models.OrderServiceV5;
using Models.OrderServiceV5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FSIOrderSubmit
{
    public class FsiOrderServiceV5
    {
        readonly Uri baseAddress;
        readonly string createOrderRequestUri;
        readonly string authString;

        public FsiOrderServiceV5()
        {
            if (FSIOrderSubmit.Properties.Settings.Default.TestMode == true)
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress);
                this.createOrderRequestUri = FSIOrderSubmit.Properties.Settings.Default.TestCreateOrderRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey;
            }
            else
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress);
                this.createOrderRequestUri = FSIOrderSubmit.Properties.Settings.Default.LiveCreateOrderRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
            }            
        }

        public async Task<OrderServiceResponse> SendOrder(string orderXml)
        {
            var orderServiceResponse = new OrderServiceResponse();
            string responseData = string.Empty;
            var fail = new Fail();
            var success = new Success();

            /*
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(orderXml);

            string jsonData = JsonConvert.SerializeXmlNode(doc);
            var json = new StringContent(orderXml, System.Text.Encoding.Default, mediaType: "application/json");
            */

            var xml = new StringContent(orderXml, System.Text.Encoding.Default, mediaType: "application/xml");

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.Timeout = new TimeSpan(0, 0, 15);

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);

                using (var response = await httpClient.PostAsync(requestUri: this.createOrderRequestUri, content: xml).ConfigureAwait(false))
                //using (var response = await httpClient.PostAsync(requestUri: this.requestUri, content: json).ConfigureAwait(false))
                {
                    responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    orderServiceResponse.Content = responseData;
                    orderServiceResponse.ResponseMessage = response;

                    return orderServiceResponse;
                }
            }
        }
    }
}
