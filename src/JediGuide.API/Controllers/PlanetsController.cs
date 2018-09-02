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
            return service.GetAll(); 
        }

        [HttpPost]
        public void Post([FromBody]Planet planet)
        {
            service.Insert(planet);
        }
    }
}