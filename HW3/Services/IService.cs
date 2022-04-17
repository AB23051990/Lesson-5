using HW3.DAL.Entities;

namespace HW3.Services
{
    public interface IService<T> where T : class
    {
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IList<PersonsEntity>> GetAll();
    }
}
