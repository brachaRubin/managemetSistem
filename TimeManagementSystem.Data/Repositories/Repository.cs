using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Repositories;

namespace TimeManagementSystem.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        private readonly DataContext _dataContext;

        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
            _dataContext = context;
        }
        public async Task<T> AddAsync(T entity)
        {
             await _dbSet.AddAsync(entity);
           await _dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await GetByIdAsync(id);
            if (existing is not null)
            {
                _dbSet.Remove(existing);
            }
           await _dataContext.SaveChangesAsync();
        }

        public async Task< IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
           
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
           await _dataContext.SaveChangesAsync();
            return entity;
        }
    }
}

