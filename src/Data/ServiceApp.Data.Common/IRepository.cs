namespace ServiceApp.Data.Common
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<TEntity>
   where TEntity : class
    {
        IQueryable<TEntity> All();

        bool Contains(TEntity entity);

        Task AddAsync(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();

        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter);

        IQueryable<TEntity> QueryObjectGraph(Expression<Func<TEntity, bool>> filter, string children);
    }
}
