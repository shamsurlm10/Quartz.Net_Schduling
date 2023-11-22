using ABX_RMO.Application.Repository;
using Microsoft.EntityFrameworkCore;

namespace ABX_RMO.Infrastructure.Repository
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly ABXRMODbContext _db;

        public EfRepository(ABXRMODbContext db)
        {
            _db = db;
        }

        public async Task<bool> AddAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<IReadOnlyList<T>> GetALlAsync()
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
