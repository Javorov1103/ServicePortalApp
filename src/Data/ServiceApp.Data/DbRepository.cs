namespace ServiceApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using ServiceApp.Data.Common;
    using ServiceApp.Web.Models;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly ServiceAppContext context;
        private DbSet<TEntity> dbSet;

        public DbRepository(ServiceAppContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }

        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public bool Contains(TEntity entity)
        {
            return this.dbSet.Contains(entity);
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter)
        {
            return dbSet.Where(filter);
        }

        public IQueryable<TEntity> QueryObjectGraph(Expression<Func<TEntity, bool>> filter,string children)
        {

            return dbSet.Include(children).Where(filter);
        }
    }
}
