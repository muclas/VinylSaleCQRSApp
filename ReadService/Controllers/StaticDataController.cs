using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReadService.Controllers
{
    [Produces("application/json")]
    [Route("api/StaticData")]
    public class StaticDataController : Controller
    {
        // GET api/StaticData/VinylItems
        [HttpGet]
        [Route("/api/StaticData/VinylItems")]
        public IEnumerable<VinylItemDTO> GetVinylItems()
        {
            return new List<VinylItemDTO>
            {
                new VinylItemDTO
                {
                    ItemNumber = 1,
                    Artist = "Fahrenheit 66",
                    Title = "The Pulse",
                    ReleasedYear = 2000,
                },
                new VinylItemDTO
                {
                    ItemNumber = 2,
                    Artist = "Tito Puente",
                    Title = "Ran Kan Kan",
                    ReleasedYear = 1992,
                },
                new VinylItemDTO
                {
                    ItemNumber = 3,
                    Artist = "Pfirter",
                    Title = "Double Existence",
                    ReleasedYear = 2017,
                },
                new VinylItemDTO
                {
                    ItemNumber = 4,
                    Artist = "Daryl Hall & John Oates",
                    Title = "Abandoned Luncheonette",
                    ReleasedYear = 1975,
                },
                new VinylItemDTO
                {
                    ItemNumber = 5,
                    Artist = "Alisha",
                    Title = "Bounce Back",
                    ReleasedYear = 1990,
                },
                 new VinylItemDTO
                 {
                     ItemNumber = 6,
                     Artist = "The Beginning Of The End",
                     Title = "Funky Nassau",
                     ReleasedYear = 1971,
                 },
                new VinylItemDTO
                {
                    ItemNumber = 7,
                    Artist = "Radio Stars",
                    Title = "From A Rabbit",
                    ReleasedYear = 1978,
                },
            };
        }
    }
}