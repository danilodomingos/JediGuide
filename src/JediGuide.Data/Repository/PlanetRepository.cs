using JediGuide.Data.Context;
using JediGuide.Data.Repository.Base;
using JediGuide.Data.Repository.Interfaces;
using JediGuide.Models.Entities;

namespace JediGuide.Data.Repository
{
    public class PlanetRepository : RepositoryBase<Planet>, IPlanetRepository
    {
        public PlanetRepository(JediGuideContext context) : base(context)
        {
        
        }
    }
}