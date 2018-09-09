using System.Collections.Generic;
using System.Threading.Tasks;
using JediGuide.Models.Entities;
using JediGuide.Service.Interfaces;
using JediGuide.SWAPI.Client.Service;
using Microsoft.AspNetCore.Mvc;

namespace JediGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController
    {
        private readonly IPlanetService service;
        private readonly SWAPIClient restService;

        public PlanetsController(IPlanetService service, SWAPIClient restService)
        {
            this.service = service;
            this.restService = restService;
        }

        [HttpGet("{name}")]
        public async Task<dynamic> Get(string name)
        {
            return await restService.GetPlanets(name);
        }

        [HttpPost]
        public void Post([FromBody]Planet planet)
        {
            service.Insert(planet);
        }
    }
}