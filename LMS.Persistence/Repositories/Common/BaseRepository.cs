using LMS.Application.Contracts.Persistence.Common;
using LMS.ApplicationCore.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LMS.Persistence.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly LMSDbContext _context;
        public DbSet<T> _dbSet;

        public BaseRepository(LMSDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); 
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException();
            }
            return entity;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var entities = await _dbSet.ToListAsync();
            if (entities == null)
            {
                throw new KeyNotFoundException();
            }
            return entities;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }
        public Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return Task.FromResult(entity);
        }

        public Task<T> TrashAsync(T entity)
        {
            entity.IsDeleted = true;
            _dbSet.Entry(entity).Property(x => x.IsDeleted).IsModified = true;
            return Task.FromResult(entity);
        }
        public Task<T> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.FromResult(entity);
        }
    }
}
