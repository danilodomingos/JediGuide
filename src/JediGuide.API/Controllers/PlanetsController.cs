using System.Collections.Generic;
using JediGuide.Models.Entities;
using JediGuide.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JediGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController
    {
        private readonly IPlanetService service;

        public PlanetsController(IPlanetService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Planet> Get()
        {
            Planet planet = new Planet();
            planet.Id = 1;
            planet.Name = "Saturn";

            service.Insert(planet);

            var list = new List<Planet>(){ planet };
            return list; 
        }

        [HttpPost]
        public void Post([FromBody]Planet planet)
        {
            
        }
    }
}