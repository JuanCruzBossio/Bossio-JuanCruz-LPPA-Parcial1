using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ParcialLPPA.Servicios
{
    public interface IDataService<T>
    {
        List<T> get(
            Expression<Func<T, bool>> WhereExpression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderfunction = null,
            string includeModels = "");
        T GetById(int id);
        T Create(T entidad);
        void update(T entidad);
        void delete(T entidad);
    }
}