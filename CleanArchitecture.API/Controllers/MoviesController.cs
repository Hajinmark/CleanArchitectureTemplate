using CleanArchitecture.Application.Interfaces;
using CleanArchitecure.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService _movieService)
        {
            this._movieService = _movieService; 
        }

        [HttpGet("FetchMoviesData")]
        public async Task<IActionResult> FetchMoviesData()
        {
            var movies = await _movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("AllMovies")]
        public async Task<IActionResult> AllMovies()
        {
            var movies = await _movieService.AllMovies();

            try
            {
                return Ok(movies);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("AddMovie")]
        public async Task<IActionResult> AddMovie(MovieDTO data)
        {
            var movie = await _movieService.AddMovies(data);

            try
            {
                if (movie != null)
                    return Ok(movie);

                else
                    return NoContent();

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
