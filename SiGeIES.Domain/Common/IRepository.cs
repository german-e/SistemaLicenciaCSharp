using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);        
        IEnumerable<T> FindAll();        
        T FindById(int id);
        void Delete(T entity);
        void Updater(T entity);

    }
}
