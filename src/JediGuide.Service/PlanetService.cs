using JediGuide.Service.Base;
using JediGuide.Service.Interfaces;
using JediGuide.Models.Entities;
using JediGuide.Data.Repository.Base;
using JediGuide.Data.Repository.Interfaces;
using JediGuide.Data.UOW;

namespace JediGuide.Service
{
    public class PlanetService : ServiceBase<Planet>, IPlanetService
    {
        private readonly IUnitOfWork unitOfWork;

        public PlanetService(IUnitOfWork unitOfWork) : base(unitOfWork.PlanetRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}