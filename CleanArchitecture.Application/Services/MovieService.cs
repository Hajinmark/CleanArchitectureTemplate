using CleanArchitecture.Application.Interfaces;
using CleanArchitecure.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository _movieRepository)
        {
            this._movieRepository = _movieRepository;
        }

        public async Task<List<Movies>> GetAllMovies()
        {
            var movies = await _movieRepository.GetAllMovies(); 
            return movies;
        }
    }
}
