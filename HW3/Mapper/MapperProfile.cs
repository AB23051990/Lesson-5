using AutoMapper;
using HW3.DAL.Entities;

namespace HW3.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Persons, PersonsEntity<int>>();
        }
    }
}