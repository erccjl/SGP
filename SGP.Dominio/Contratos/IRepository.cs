using SGP.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Dominio.Contratos
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Add(TEntity item);

        Task<TEntity> Update(TEntity item);

        Task<TEntity> Get(int id);

        Task<IEnumerable<TEntity>> GetAll();

        IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);

        Task<IEnumerable<T>> ExecuteQuery<T>(string sqlQuery, params object[] parameters);

        Task Save();
    }
}
