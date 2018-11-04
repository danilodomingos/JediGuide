using JediGuide.Application.IServices;
using JediGuide.Service.Interfaces;
using JediGuide.Rest;
using System;
using JediGuide.Core.Entities;
using System.Net;
using JediGuide.Core.Exceptions;

namespace JediGuide.Application.Services
{
    public class PlanetAppService : IPlanetAppService
    {
        private readonly IPlanetService service;
        private readonly Result<Planet> pageResult;

        public PlanetAppService(IPlanetService service, Result<Planet> pageResult)
        {
            this.service = service;
            this.pageResult = pageResult;
        }

        Result<Planet> IPlanetAppService.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        Result<Planet> IPlanetAppService.Insert(Planet planet)
        {
            try{

                service.Insert(planet);

                pageResult.Message = "Insert Sucessful";
                pageResult.StatusCode = (int)HttpStatusCode.Created;
                
            }
            catch(DomainException de)
            {
                pageResult.Message = de.Message;
                pageResult.StatusCode = de.ErrCode;
            }
            
            return pageResult;
        }

        Result<Planet> IPlanetAppService.Update(Planet planet)
        {
            throw new System.NotImplementedException();
        }
    }
}