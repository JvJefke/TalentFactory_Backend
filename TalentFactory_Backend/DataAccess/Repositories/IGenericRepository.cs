
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.DataAccess.Repositories
{

    public interface IGenericRepository<TEntity>
      where TEntity : class {
        IEnumerable<TEntity> All();
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        TEntity GetByID(object id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
      }

}