using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookStore.Data.Contracts
{
    public interface IRepository<TEntity>
            where TEntity : class
    {
        TEntity GetByID(object id);

        List<TEntity> GetAll();

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(object id);

        int Count(Expression<Func<TEntity, bool>> filter);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter);

    }
}
