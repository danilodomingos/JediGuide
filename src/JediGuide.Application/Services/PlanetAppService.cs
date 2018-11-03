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
        private readonly PageResult pageResult;

        public PlanetAppService(IPlanetService service, PageResult pageResult)
        {
            this.service = service;
            this.pageResult = pageResult;
        }

        PageResult IPlanetAppService.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        PageResult IPlanetAppService.Insert(Planet planet)
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

        PageResult IPlanetAppService.Update(Planet planet)
        {
            throw new System.NotImplementedException();
        }
    }
}