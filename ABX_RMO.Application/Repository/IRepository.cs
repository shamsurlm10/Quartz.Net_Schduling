namespace ABX_RMO.Application.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetALlAsync();
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}
