using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ParcialLPPA.Entidades;
using System.Data.Entity;

namespace ParcialLPPA.Servicios
{
    public class BaseDataService<T> : IDataService<T> where T : Entidades.Identidad, new()
    {
        protected ObraDbContext obracontext;

        public BaseDataService()
        {
            this.obracontext = new ObraDbContext();
        }
        public T Create(T entidad)
        {
            obracontext.Set<T>().Add(entidad);
            obracontext.SaveChanges();
            return entidad;
        }

        public void delete(T entidad)
        {
            obracontext.Set<T>().Remove(entidad);
            obracontext.SaveChanges();
        }

        public List<T> get(Expression<Func<T, bool>> WhereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeModels = "")
        {
            IQueryable<T> query = obracontext.Set<T>();
            if (WhereExpression != null)
            {
                query = query.Where(WhereExpression);
            }
            var entity = includeModels.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            query = entity.Aggregate(query,(current,model) => current.Include(model));
            if (orderFunction != null)
            {
                query = orderFunction(query);
            }
            return query.ToList();

        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Entidades.Afiliado entidad)
        {
            using (var contexto = new ObraDbContext())
            {
                var entity = contexto.Afiliados.FirstOrDefault(item => item.id == entidad.id);
                if (entity != null)
                {
                    entity =entidad;
                    contexto.SaveChanges();
                }
            }
                
        }

        public void update(T entidad)
        {
            throw new NotImplementedException();
        }
    }
}