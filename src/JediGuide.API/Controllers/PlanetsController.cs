using System.Collections.Generic;
using JediGuide.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JediGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController
    {
        [HttpGet]
        public IEnumerable<Planet> Get()
        {
            Planet planet = new Planet();
            planet.Id = 1;
            planet.Name = "Saturn";

            var list = new List<Planet>(){ planet };
            return list; 
        }

        [HttpPost]
        public void Post([FromBody]Planet planet)
        {
            
        }
    }
}