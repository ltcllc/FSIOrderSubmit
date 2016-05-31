using FSIOrderSubmit.Models;
using FSIOrderSubmit.Models.InventoryInquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FSIOrderSubmit
{
    public class FsiInventoryService
    {
        readonly Uri baseAddress;
        readonly string authString;

        public FsiInventoryService()
        {
            this.baseAddress = new Uri("Https://inventory.fsifulfillment.com");
            this.authString = FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
        }

        public async Task<ServiceResponse> GetAllItems()
        {
            var serviceResponse = new ServiceResponse();
            var items = new List<InventoryItem>();
            string responseData = string.Empty;

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "Accept", value: "application/xml");

                using (var response = await httpClient.GetAsync(requestUri: "/V5/GetItems"))
                {
                    responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    serviceResponse.Content = responseData;
                    serviceResponse.ResponseMessage = response;

                    return serviceResponse;
                }
            }

        }

        public async Task<ServiceResponse> GetItem(string itemNumber)
        {
            var serviceResponse = new ServiceResponse();
            var items = new InventoryItem();
            string responseData = string.Empty;

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "authorization", value: this.authString);
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(name: "Accept", value: "application/xml");

                using (var response = await httpClient.GetAsync(requestUri: $"/V5/GetItem?sku={itemNumber}"))
                {
                    responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    serviceResponse.Content = responseData;
                    serviceResponse.ResponseMessage = response;

                    return serviceResponse;
                }
            }
        }
    }
}
