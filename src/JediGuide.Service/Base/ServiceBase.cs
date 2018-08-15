using System;
using System.Collections.Generic;
using JediGuide.Models.Entities.Base;
using JediGuide.Service.Interfaces;

namespace JediGuide.Service.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        void IServiceBase<TEntity>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<TEntity> IServiceBase<TEntity>.FindAllBy(Func<TEntity, bool> func)
        {
            throw new NotImplementedException();
        }

        TEntity IServiceBase<TEntity>.FindBy(Func<TEntity, bool> func)
        {
            throw new NotImplementedException();
        }

        TEntity IServiceBase<TEntity>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        List<TEntity> IServiceBase<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IServiceBase<TEntity>.InsertOrUpdate(TEntity t)
        {
            throw new NotImplementedException();
        }
    }
}