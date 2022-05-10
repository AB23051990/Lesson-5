using AutoMapper;
using HW3.Controllers.Models;
using HW3.Responses;

namespace Timesheets
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {            
            CreateMap<Persons, PersonsDto>();            
        }
    }
}
