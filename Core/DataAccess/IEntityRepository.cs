using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity ,new()
    {
        // Generic constraint filtreleme sınırlandırma

       
        
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);                                       // C - created
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // R - read
        void Delete(T entity);                                   // U - update
        void Update(T entity);                                   // D - delete

    }
}
