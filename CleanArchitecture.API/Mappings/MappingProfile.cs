using AutoMapper;
using CleanArchitecture.Infrastructure.Persistence.Entity;
using CleanArchitecure.Domain.Domain;
using CleanArchitecure.Domain.DTO;

namespace CleanArchitecture.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieDTO, Movie>();
        }
    }
}
