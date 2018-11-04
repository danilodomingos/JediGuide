using JediGuide.Core.Entities;
using JediGuide.Rest;

namespace JediGuide.Application.IServices
{
    public interface IPlanetAppService
    {
        Result<Planet> Insert(Planet planet);
        Result<Planet> Update(Planet planet);
        Result<Planet> Delete(int id);
    }
}