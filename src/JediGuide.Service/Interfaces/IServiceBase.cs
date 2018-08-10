using System;
using System.Collections.Generic;
using JediGuide.Models.Entities.Base;

namespace JediGuide.Service.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        void InsertOrUpdate(TEntity t);
        void Delete(int id);
        List<TEntity> GetAll();
        TEntity FindById(int id);
        TEntity FindBy(Predicate<TEntity> func);
        List<TEntity> FindAllBy(Predicate<TEntity> func);
    }
}