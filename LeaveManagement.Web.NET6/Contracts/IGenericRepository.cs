namespace LeaveManagement.Web.NET6.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> ExistsAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}
