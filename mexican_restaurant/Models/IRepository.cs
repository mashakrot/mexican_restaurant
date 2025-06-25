using System.Linq.Expressions;

namespace mexican_restaurant.Models
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdasync(int id, QueryOptions<T> options);
        Task AddAsync(Task entity);
        Task UpdateAsync(Task entity);
        Task DeleteAsync(int id);

    }
}
