using CleanArchitecure.Domain.Domain;
using CleanArchitecure.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movies>> GetAllMovies();
        Task<List<MovieDTO>> AllMovies();
        Task<MovieDTO> AddMovies(MovieDTO data);
        Task<Boolean> IsMovieExist(string name);
    }
}
