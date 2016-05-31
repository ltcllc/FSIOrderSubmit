using FSIOrderSubmit.Models.OrderServiceV5;
using FSIOrderSubmit.Models.OrderStatus;
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
        readonly string orderStatusRequestUri;

        public FsiOrderServiceV5()
        {
            if (FSIOrderSubmit.Properties.Settings.Default.TestMode == true)
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress);
                this.createOrderRequestUri = FSIOrderSubmit.Properties.Settings.Default.TestCreateOrderRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey;
                this.orderStatusRequestUri = FSIOrderSubmit.Properties.Settings.Default.TestOrderStatusRequestUri;
            }
            else
            {
                this.baseAddress = new Uri(FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress);
                this.createOrderRequestUri = FSIOrderSubmit.Properties.Settings.Default.LiveCreateOrderRequestUri;
                this.authString = FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
                this.orderStatusRequestUri = FSIOrderSubmit.Properties.Settings.Default.LiveOrderStatusRequestUri;
            }            
        }
            
        public async Task<OrderServiceResponse> SendOrderAsync(string orderXml)
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

        public OrderServiceResponse SendOrder(string orderXml)
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
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);

                using (var response = httpClient.PostAsync(requestUri: this.createOrderRequestUri, content: xml).Result)
                //using (var response = await httpClient.PostAsync(requestUri: this.requestUri, content: json).ConfigureAwait(false))
                {
                    responseData = response.Content.ReadAsStringAsync().Result;
                    orderServiceResponse.Content = responseData;
                    orderServiceResponse.ResponseMessage = response;

                    return orderServiceResponse;
                }
            }
        }

        public OrderStatusServiceResponse GetOrderStatus(Guid orderId)
        {
            var orderStatusResponse = new OrderStatusServiceResponse();
            string responseData = string.Empty;
            var fail = new Fail();
            var success = new Success();

            
            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {                
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "Accept", value: "application/xml");

                using (var response = httpClient.GetAsync(requestUri: $"{this.orderStatusRequestUri}/{orderId}").Result)
                 {
                    responseData = response.Content.ReadAsStringAsync().Result;
                    orderStatusResponse.Content = responseData;
                    orderStatusResponse.ResponseMessage = response;

                    return orderStatusResponse;
                }
            }
            
        }

    }
}
