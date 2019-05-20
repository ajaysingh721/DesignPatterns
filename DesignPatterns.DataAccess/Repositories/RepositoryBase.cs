using DesignPatterns.DataAccess.Interfaces;
using DesignPatterns.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext Context;
        private readonly DbSet<T> Entity;

        protected RepositoryBase(AppDbContext context)
        {
            Context = context;
            Entity = Context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Entity.Add(entity);
            Context.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            Entity.AddRange(entities);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Entity.Remove(entity);
            Context.SaveChanges();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            Entity.RemoveRange(entities);
            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Entity.AsEnumerable();
        }

        public IQueryable<T> GetQueryable()
        {
            return Entity.AsQueryable<T>();
        }

        public T GetSingle(long id)
        {
            return Entity.SingleOrDefault(s => s.Id == id);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Context.SaveChanges();
        }
    }
}
