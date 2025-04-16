using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Create
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        // Read
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        // Update
        void Update(TEntity entity);

        // Delete
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}