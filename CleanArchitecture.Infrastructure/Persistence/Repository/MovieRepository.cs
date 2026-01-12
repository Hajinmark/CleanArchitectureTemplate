using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infrastructure.Persistence.Database;
using CleanArchitecture.Infrastructure.Persistence.Entity;
using CleanArchitecure.Domain.Domain;
using CleanArchitecure.Domain.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CorpsInventorySystemContext _context;
        private readonly IMapper _mapper;
        public MovieRepository(CorpsInventorySystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }

        public async Task<MovieDTO> AddMovies(MovieDTO data)
        {
            var movie = _mapper.Map<Movie>(data);

            await _context.AddAsync(movie);
            await _context.SaveChangesAsync();

            // without using AutoMapper
            /* new MovieDTO
            {
                Name = data.Name,
                Cost = data.Cost
            };*/

            // with use of AutoMapper
            return _mapper.Map<MovieDTO>(movie);

            
        }

        public async Task<List<MovieDTO>> AllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return _mapper.Map<List<MovieDTO>>(movies);
        }

        public async Task<List<Movies>> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();

            // Map each Entity.Movie to Domain.Movies
            var domainMovies = movies.Select(m => new Movies
            {
                Id = m.Id,
                Name = m.Name,
                Cost = m.Cost
                // map all other properties
            }).ToList();

            return domainMovies;
        }

        public async Task<bool> IsMovieExist(string name)
        {
            var movieName = await _context.Movies
                .FirstOrDefaultAsync(x => x.Name == name);

            if (movieName != null)
                return true;

            else
                return false;
        }
    }
}
