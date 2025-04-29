using Microsoft.AspNetCore.Mvc;

namespace mod10_103022330128.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", ["Tim Robbins", "Morgan Freeman", "Bob Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", ["Marlon Brando", "AI Pacino", "James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", ["Christian Bale", "Heath Ledger", "Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]

        public IEnumerable<Movie> Get()
        {
            return movieList;
        }

        [HttpGet("{index}")]

        public Movie Get(int index)
        {
            return movieList[index];
        }

        [HttpPost]

        public void Post([FromBody] Movie movie)
        {
            movieList.Add(movie);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            movieList.RemoveAt(index);
        }

    }
}
