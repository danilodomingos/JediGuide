using JediGuide.Data.Context;
using JediGuide.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace JediGuide.Data.UOW
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly JediGuideContext context;
        private IDbContextTransaction transaction;
        private readonly IPlanetRepository planetRepository;

        public UnitOfWork(JediGuideContext context,
            IPlanetRepository planetRepository)
        {
            this.context = context;
            this.planetRepository = planetRepository;
        }

        public IPlanetRepository PlanetRepository => this.planetRepository;

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null) transaction.Commit();
        }

        public void Rollback()
        {
            if (transaction != null) transaction.Rollback();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}