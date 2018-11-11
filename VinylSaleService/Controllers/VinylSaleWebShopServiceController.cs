using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aggregates;
using Commands.WebShop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VinylSaleService.Controllers
{
    [ApiController]
    public class VinylSaleWebShopServiceController : ControllerBase
    {
        [HttpPost]
        [Route("api/VinylSaleWebShopService/OpenCart")]
        public void Post(OpenCart cmd)
        {
            Startup.Dispatcher.SendCommand(cmd);
        }

        [HttpPost]
        [Route("api/VinylSaleWebShopService/AddItemToCart")]
        public void AddItemToCart(AddItemToCart cmd)
        {   
            Startup.Dispatcher.SendCommand(cmd);
        }
    }
}