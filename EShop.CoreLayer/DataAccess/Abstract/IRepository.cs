using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShop.CoreLayer.DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity:class,new()
    {
        // ortak kullanılan metodlar
        void AddEntity(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void DeleteEntity(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        TEntity FindEntity(Expression<Func<TEntity, bool>> filter);

        List<TEntity> FindRange(Expression<Func<TEntity, bool>> filter = null);
        

    }
}
