using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using JediGuide.API.Controllers.Base;
using JediGuide.Application.IServices;
using JediGuide.Core.Entities;
using JediGuide.Rest;
using JediGuide.SWAPI.Client.Service;
using Microsoft.AspNetCore.Mvc;

namespace JediGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : BaseController
    {
        private readonly IPlanetAppService appService;

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
                
                var result = appService.Insert(planet);

                return Result(result);
            }
            catch(Exception e)
            {
                //Implementar Log.
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Ocorreu um erro: {e.Message}");
            }
        }
    }
}