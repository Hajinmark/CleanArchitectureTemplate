using CleanArchitecture.Application.Interfaces;
using CleanArchitecure.Domain.Domain;
using CleanArchitecure.Domain.DTO;
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

        public async Task<MovieDTO> AddMovies(MovieDTO data)
        {
            var isMovieExist = await _movieRepository.IsMovieExist(data.Name);

            if (isMovieExist)
                return null;

            return await _movieRepository.AddMovies(data);
        }

        public async Task<List<MovieDTO>> AllMovies()
        {
            var movies = await _movieRepository.AllMovies();
            return movies;
        }

        public async Task<List<Movies>> GetAllMovies()
        {
            var movies = await _movieRepository.GetAllMovies(); 
            return movies;
        }

    }
}
