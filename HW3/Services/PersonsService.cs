using AutoMapper;
using HW3.DAL.Entities;
using HW3.DAL.Repository.Interfaces;

namespace HW3.Services
{
    public class PersonsService : IService<Persons>
    {
        private readonly IPersonsRepository _contractRepository;
        private readonly IMapper _mapper;

        public PersonsService(IPersonsRepository contractRepository,
                                IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public Task Create(Persons item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Persons> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Persons>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Persons item)
        {
            throw new NotImplementedException();
        }

        Task<IList<HW3.Controllers.Models.Persons>> IService<Persons>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
