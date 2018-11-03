using JediGuide.Service.Base;
using JediGuide.Service.Interfaces;
using JediGuide.Core.Entities;
using JediGuide.Data.Repository.Base;
using JediGuide.Data.Repository.Interfaces;
using JediGuide.Data.UOW;
using JediGuide.Rest;
using System.Threading.Tasks;
using JediGuide.Core.Exceptions;
using JediGuide.SWAPI.Client.Service;

namespace JediGuide.Service
{
    public class PlanetService : ServiceBase<Planet>, IPlanetService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPlanetRepository repository;
        private readonly SWAPIClient swapiClient;

        public PlanetService(SWAPIClient swapiClient, 
            IUnitOfWork unitOfWork) : base(unitOfWork.PlanetRepository)
        {
            this.swapiClient = swapiClient; 
            this.unitOfWork = unitOfWork;
            this.repository = unitOfWork.PlanetRepository;
        }

        public void Insert(Planet planet){

            if(planet.IsValid()){

                var persisted = repository.FindBy(x => x.Name == planet.Name);
                var onlineInfo = swapiClient.GetPlanets(planet.Name);

                if(persisted != null)
                    throw new DomainException("Planeta já cadastrado.", 409);

                if(onlineInfo == null || 
                   onlineInfo.Result?.Count > 1)
                        throw new DomainException("Planeta inexistente.", 404);

                var movies = onlineInfo.Result.Results[0].Films;
                planet.MoviesShowUp = movies.Count;

                repository.Insert(planet);

            }else{

                throw new DomainException("Preencha os campos corretamente.", 400);
            }

        }

    }
}