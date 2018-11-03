using JediGuide.Core.Entities;
using JediGuide.Rest;

namespace JediGuide.Application.IServices
{
    public interface IPlanetAppService
    {
        PageResult Insert(Planet planet);
        PageResult Update(Planet planet);
        PageResult Delete(int id);
    }
}