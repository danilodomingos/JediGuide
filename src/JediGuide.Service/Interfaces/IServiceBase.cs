using System;
using System.Collections.Generic;
using JediGuide.Models.Entities.Base;

namespace JediGuide.Service.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity t);
        void Update(TEntity t);
        void Delete(int id);
        List<TEntity> GetAll();
        TEntity FindById(int id);
        TEntity FindBy(Func<TEntity, bool> where);
        List<TEntity> FindAllBy(Func<TEntity, bool> where);
    }
}