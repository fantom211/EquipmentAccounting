using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T? GetById(int id);
        List<T> GetAll();
        void Add(T model);
        void Update(T model);
        void Delete(int id);
    }
}
