using Domain.Core.Repository;
using Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Infra.Core.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(DbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
         }

        public IEnumerable<TEntity> GetAll() 
            => DbSet;

        public TEntity GetById(Guid id) 
            => DbSet.Find(id);

        public void Save(TEntity entity) 
            => DbSet.Add(entity);

        public void Update(TEntity entity) 
            => DbSet.Update(entity);

        public void Remove(Guid id) =>
             DbSet.Remove(DbSet.Find(id));
    }
}
