namespace LMS.Application.Contracts.Persistence.Common
{
    public interface IBaseRepository<T> where T:class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> TrashAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
