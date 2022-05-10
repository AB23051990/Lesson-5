using HW3.Controllers.Models;

namespace HW3.Services
{
    public interface IService<T> where T : class
    {
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IList<Persons>> GetAll();
    }
}
