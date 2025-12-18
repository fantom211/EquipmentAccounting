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

        public async Task AddAsync(T model)
        {
            _dbSet.Add(model);
            await _eqContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
