using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    // https://localhost:7148/api/movies
    [Route("api/[Controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private Movie[] _movies = new Movie[]
        {
            new Movie { Id = 1, Title = "Title One", Director = "Director One", Rating = 1 },
            new Movie { Id = 2, Title = "Title Two", Director = "Director Two", Rating = 2 },
            new Movie { Id = 3, Title = "Title Three", Director = "Director Three", Rating = 3 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies() 
        {
            return Ok(_movies);
        }

    };
}
