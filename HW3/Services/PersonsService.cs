using AutoMapper;
using HW3.Controllers.Models;
using HW3.DAL.Entities;
using HW3.DAL.Repository.Interfaces;

namespace HW3.Services
{
    public class PersonsService : IService<Persons>
    {
        private readonly IPersonsRepository _personsRepository;
        private readonly IMapper _mapper;

        public PersonsService(IPersonsRepository personsRepository,
                                IMapper mapper)
        {
            _personsRepository = personsRepository;
            _mapper = mapper;
        }

        public async Task Create(Persons item)
        {
            var persons = new PersonsEntity
            {
                Name = item.Name,
                Description = item.Description,                
            };
            await _personsRepository.Add(persons);
        }

        public async Task Delete(int id)
        {
            var persons = await _personsRepository.Get(id);
            persons.Delete();
            await _personsRepository.Delete(persons);
        }

        public async Task<Persons> Get(int id)
        {
            var persons = await _personsRepository.Get(id);
            return _mapper.Map<Persons>(persons);
        }

        public async Task<IList<PersonsEntity>> GetAll()
        {
            var tt = await _personsRepository.GetAll();
            return (IList<PersonsEntity>)tt;
        }

        public async Task Update(Persons item)
        {
            var persons = await _personsRepository.Get(item.Id);
            persons.Name = item.Name;
            persons.Description = item.Description;
            await _personsRepository.Update(persons);
        }
    }
}
