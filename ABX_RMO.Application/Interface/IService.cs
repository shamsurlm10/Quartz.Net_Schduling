namespace ABX_RMO.Application.Interface
{
    public interface IService<T> where T : class
    {
        Task<IReadOnlyList<T>> GetALlAsync();
        Task<bool> UpdateAsync(T entity);
    }
}
