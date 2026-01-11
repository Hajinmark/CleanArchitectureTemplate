using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infrastructure.Persistence.Database;
using CleanArchitecure.Domain.Domain;
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
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext _context)
        {
            this._context = _context;
        }
        public async Task<List<Movies>> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }
    }
}
