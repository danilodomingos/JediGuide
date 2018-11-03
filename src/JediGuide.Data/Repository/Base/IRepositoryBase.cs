using JediGuide.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JediGuide.Data.Repository.Base
{
    public interface IRepositoryBase<TEntity>: IDisposable where TEntity: BaseEntity
    {
        void Insert(TEntity t, bool saveChanges = true);
        void Update(TEntity t, bool saveChanges = true);
        void Delete(int id);
        List<TEntity> GetAll();
        TEntity FindById(int id);
        TEntity FindBy(Func<TEntity,bool> where);
        List<TEntity> FindAllBy(Func<TEntity,bool> where);
        int SaveChanges();
    }
}