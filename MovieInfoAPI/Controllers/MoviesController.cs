using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieInfoAPI.Models;

namespace MovieInfoAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{provider}/movies")]
        public ActionResult<IEnumerable<Movie>> GetMovies(string provider)
        {
            try
            {
                var moviesToReturn = MoviesDataStore.Current.Movies.Where(m => m.Provider == provider);

                if (moviesToReturn.Count() > 0)
                {
                    return Ok(moviesToReturn);
                }
                else
                {
                    _logger.LogInformation(
                        $"Movies with provider {provider} were not found.");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting movies with provider {provider}", ex);
                return StatusCode(500, "A probelm happened when handling your request.");
            }
            
                
        }

        [HttpGet("{provider}/movie/{id}")]
        public ActionResult<Movie> GetMovie(string provider, int id)
        {
            try
            {
                var movieToReturn = MoviesDataStore.Current.Movies.FirstOrDefault(m => m.Provider == provider && m.MovieId == id);

                if (movieToReturn == null)
                {
                    _logger.LogInformation(
                        $"Movie with provider {provider} and Id {id} was not found.");
                    return NotFound();
                }

                return Ok(movieToReturn);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting a movie with provider {provider} and Id {id}", ex);
                return StatusCode(500, "A probelm happened when handling your request.");
            }

        }
    }




}
