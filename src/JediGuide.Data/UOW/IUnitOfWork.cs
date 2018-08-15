using JediGuide.Data.Repository.Interfaces;

namespace JediGuide.Data.UOW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        IPlanetRepository PlanetRepository { get; }
    }
}