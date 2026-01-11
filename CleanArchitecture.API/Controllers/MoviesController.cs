using CleanArchitecture.Application.Interfaces;
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

        [HttpGet]
        public async Task<IActionResult> FetchMoviesData()
        {
            var movies = await _movieService.GetAllMovies();
            return Ok(movies);
        }
    }
}
