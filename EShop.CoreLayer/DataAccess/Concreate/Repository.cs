using EShop.CoreLayer.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EShop.CoreLayer.DataAccess.Concreate
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected DbContext _context; // DI
        private DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
       

        public void AddEntity(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void DeleteEntity(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public TEntity FindEntity(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public List<TEntity> FindRange(Expression<Func<TEntity, bool>> filter = null)
        {
            return _dbSet.Where(filter).ToList();
        }
    }
}
