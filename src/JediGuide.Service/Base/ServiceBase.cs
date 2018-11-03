using System;
using System.Collections.Generic;
using JediGuide.Data.Repository.Base;
using JediGuide.Core.Entities.Base;
using JediGuide.Service.Interfaces;

namespace JediGuide.Service.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        void IServiceBase<TEntity>.Delete(int id)
        {
            repository.Delete(id);
        }

        List<TEntity> IServiceBase<TEntity>.FindAllBy(Func<TEntity, bool> where)
        {
            return repository.FindAllBy(where);
        }

        TEntity IServiceBase<TEntity>.FindBy(Func<TEntity, bool> where)
        {
            return repository.FindBy(where);
        }

        TEntity IServiceBase<TEntity>.FindById(int id)
        {
            return repository.FindById(id);
        }

        List<TEntity> IServiceBase<TEntity>.GetAll()
        {
            return repository.GetAll();
        }

        void IServiceBase<TEntity>.Insert(TEntity entity)
        {
            repository.Insert(entity);
        }

        void IServiceBase<TEntity>.Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}