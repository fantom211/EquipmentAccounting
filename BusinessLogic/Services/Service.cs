using BusinessLogic.Interfaces;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class Service<T> : IRepository<T> where T : class
    {
        private readonly EquipmentContext _eqContext;
        private readonly DbSet<T> _dbSet;

        public Service(EquipmentContext eqContext)
        {
            _eqContext = eqContext;
            _dbSet = eqContext.Set<T>();
        }

        public void Add(T model)
        {
            _dbSet.Add(model);
            _eqContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
                _eqContext.SaveChanges();
            }
        }
        public void Update(T model)
        {
            _dbSet.Update(model);
            _eqContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
