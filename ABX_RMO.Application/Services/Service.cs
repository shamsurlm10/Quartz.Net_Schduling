using ABX_RMO.Application.Interface;
using ABX_RMO.Application.Repository;

namespace ABX_RMO.Application.Services
{
    public class Service<T>:IService<T> where T : class
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }
        public async Task<IReadOnlyList<T>> GetALlAsync()
        {
            return await _repo.GetALlAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _repo.UpdateAsync(entity);
        }
    }
}
