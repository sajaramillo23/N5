using System.Threading.Tasks;

namespace N5.Domain.Interfaces.Services
{
    public interface IService<T,TKey> where T : class
    {
        Task<T> SaveAsync(T dto);
        Task<T> GetAsync(TKey id);
        Task<T> UpdateAsync(T dto);
    }
}
