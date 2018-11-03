using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JediGuide.Application.IServices;
using JediGuide.Core.Entities;
using JediGuide.Rest;
using JediGuide.SWAPI.Client.Service;
using Microsoft.AspNetCore.Mvc;

namespace JediGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController
    {
        private readonly IPlanetAppService appService;
        private readonly PageResult pageResult;

        public PlanetsController(IPlanetAppService appService)
        {
            this.appService = appService;
        }

        // [HttpGet("{name}")]
        // public async Task<dynamic> Get(string name, string page)
        // {
        //     return await restService.GetPlanets(name, page);
        // }

        [HttpPost]
        public ActionResult Post([FromBody]Planet planet)
        {
            try{
                appService.Insert(planet);
            }
            catch(Exception e)
            {

            }

            return null;
        }
    }
}