using HW3.DAL.Entities;
using HW3.DAL.Repository.Interfaces;

namespace HW3.DAL.Repository
{
    public class PersonsRepository : IPersonsRepository
    {
        // private readonly Persons _persons;

        //public PersonsRepository(Persons persons)
        // {
        //    _persons = persons;
        // }
        public Task Add(PersonsEntity item)
        {
            throw new NotImplementedException();
            //await _persons.Persons.AddAsync(item);
            //await _persons.SaveChangesAsync();
        }

        public Task Delete(PersonsEntity item)
        {
            throw new NotImplementedException();
            //_persons.Update(item);
            //await _persons.SaveChangesAsync();
        }

        public Task<PersonsEntity> Get(int id)
        {
            throw new NotImplementedException();
            //var customer = await _persons.Persons.FindAsync(id);
            //if (customer == null)
            //{
            //    throw new ArgumentException("Клиент не найден!");
            //}
            //return customer;
        }

        public Task<IEnumerable<PersonsEntity>> GetAll()
        {
            throw new NotImplementedException();
            // return await _persons
            //     .Persons
            //    .Where(x => x.IsDeleted == false)
            //     .ToListAsync();
        }

        public Task Update(PersonsEntity item)
        {
            throw new NotImplementedException();
            // _persons.Persons.Update(item);
            // await _persons.SaveChangesAsync();
        }
    }
}