using BusinessLogic.Interfaces;
using DAL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class Service
    {
        private readonly EquipmentContext _eqContext;

        public Service()
        {
            _eqContext = new EquipmentContext(new DbContextOptionsBuilder<EquipmentContext>()
                .UseSqlServer(AppConfig.connectionString)
                .Options);
        }

        public void Add<T>(T model) where T : class 
        {
            _eqContext.Set<T>().Add(model);
            _eqContext.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var entity = _eqContext.Set<T>().Find(id);
            if(entity != null)
            {
                _eqContext.Set<T>().Remove(entity);
                _eqContext.SaveChanges();
            }
        }
        public void Update<T>(T model) where T : class
        {
            _eqContext.Set<T>().Update(model);
            _eqContext.SaveChanges();
        }

        public List<T> GetAll<T>() where T : class
        {
            return _eqContext.Set<T>().ToList();
        }

        public T? GetById<T>(int id) where T : class
        {
            return _eqContext.Set<T>().Find(id);
        }
    }
}
