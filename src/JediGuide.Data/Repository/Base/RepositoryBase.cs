using System;
using System.Collections.Generic;
using System.Linq;
using JediGuide.Data.Context;
using JediGuide.Models.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace JediGuide.Data.Repository.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly JediGuideContext context;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(JediGuideContext context)
        {
            this.context = context;
        }

        void IRepositoryBase<TEntity>.Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        List<TEntity> IRepositoryBase<TEntity>.FindAllBy(Func<TEntity,bool> where)
        {
            
            return DbSet.Where(where).ToList();
        }

        TEntity IRepositoryBase<TEntity>.FindBy(Func<TEntity,bool> where)
        {
            return DbSet.Where(where).FirstOrDefault();
        }

        TEntity IRepositoryBase<TEntity>.FindById(int id)
        {
            return DbSet.Find(id);
        }

        List<TEntity> IRepositoryBase<TEntity>.GetAll()
        {
            return DbSet.ToList();
        }

        void IRepositoryBase<TEntity>.Insert(TEntity t, bool saveChanges)
        {
            DbSet.Add(t);
            
            if(saveChanges)
                context.SaveChanges();
        }

        void IRepositoryBase<TEntity>.Update(TEntity t, bool saveChanges)
        {
            DbSet.Update(t);
            
            if(saveChanges)
                context.SaveChanges();
        }

        int IRepositoryBase<TEntity>.SaveChanges()
        {
            return context.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}