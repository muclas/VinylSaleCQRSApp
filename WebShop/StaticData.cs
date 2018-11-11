using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebShop
{
    public class StaticData
    {
        public List<VinylItemDTO> BuyableItems { get; set; }
        private readonly IHttpClientFactory _httpClientFactory;

        public StaticData(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            LoadItems();
        }

        private async void LoadItems()
        {
            var client = _httpClientFactory.CreateClient("staticdata");
            var response = await client.GetAsync("/StaticData/VinylItems");
            var jsonString = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IEnumerable<VinylItemDTO>>(jsonString);
            BuyableItems = new List<VinylItemDTO>(data);
        }
    }
}
