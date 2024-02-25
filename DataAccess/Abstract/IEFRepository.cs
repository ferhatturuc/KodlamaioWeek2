using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEFRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
