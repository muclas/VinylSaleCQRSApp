using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Commands.WebShop;
using DTO;
using Events.WebShop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class BuyerController : Controller
    {
        private StaticData _staticData;
        private readonly IHttpClientFactory _httpClientFactory;

        public BuyerController(StaticData staticData, IHttpClientFactory httpClientFactory)
        {
            _staticData = staticData;
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OpenCart()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OpenCart(OpenCart cmd)
        {
            var client = _httpClientFactory.CreateClient("vinylsale");
            cmd.Id = Guid.NewGuid();
            HttpContext.Session.SetString("CartId", cmd.Id.ToString());
            var ret = await client.PostAsJsonAsync("api/VinylSaleWebShopService/OpenCart", cmd);
            return RedirectToAction("Index");
        }

        public IActionResult BuyItems()
        {
            return View(_staticData.BuyableItems);
        }

        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var item = _staticData.BuyableItems.FirstOrDefault(i => i.ItemNumber == id);
                var cartId = HttpContext.Session.GetString("CartId");

                if (item != null && cartId != null)
                {
                    var client = _httpClientFactory.CreateClient("staticdata");
                    var cmd = new AddItemToCart
                    {
                        Id = new Guid(cartId),
                        Item = new OrderedItem
                        {
                            ItemNumber = item.ItemNumber,
                            Artist = item.Artist,
                            ReleasedYear = item.ReleasedYear,
                            Title = item.Title,
                        },
                    };
                    client.PostAsJsonAsync("api/VinylSaleWebShopService/AddItemToCart", cmd);
                }
            }
            return RedirectToAction("Index");
        }
    }
}