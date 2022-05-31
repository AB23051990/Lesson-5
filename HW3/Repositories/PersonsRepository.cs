using Xunit;
using Microsoft.EntityFrameworkCore;
using HW3.Requests;
using HW3.Controllers.Models;
using Moq;

namespace HW3.Repositories
{
    
    public interface IPersonsRepository
    {
        Task Create(CreatePersonsRequest request);
        Task Delete(DeletePersonsRequest request);
        Task<List<Persons>> GetAll();
        Task<Persons> GetById(GetPersonsByIdRequest request);
        IReadOnlyList<Persons> Test();
    }
    public class PersonsRepository : IPersonsRepository
    {
        private IReadOnlyList<Persons> _index;
        
        HW3DbContext _context;        
        public PersonsRepository(HW3DbContext context)
        {
            _context = context;
        }       

        public async Task Create(CreatePersonsRequest request)
        {
            try
            {
                var lastItem = await _context
                    .Persons
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync();
                var id = lastItem != null ? lastItem.Id + 1 : 1;
                var factory = new PersonsFactory();
                var item = factory.Create(id, request.Name);

                await _context.Persons.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task Delete(DeletePersonsRequest request)
        {
            try
            {
                var item = await _context
                    .Persons
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();

                _context.Persons.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task<List<Persons>> GetAll()
        {
            

            try
            {
                return await _context
                    .Persons
                    .Include(x => x.Person)
                    .ToListAsync();
            }
            catch (Exception)
            {

            }

            return null;
        }

        public async Task<Persons> GetById(GetPersonsByIdRequest request)
        {
            try
            {
                return await _context
                    .Persons
                    .Where(x => x.Id == request.Id)
                    .Include(x => x.Person)
                    .SingleOrDefaultAsync();
            }
            catch (Exception)
            {

            }

            return null;
        }

        public IReadOnlyList<Persons> Test()
        {
            throw new NotImplementedException();
        }

        
    }
}
