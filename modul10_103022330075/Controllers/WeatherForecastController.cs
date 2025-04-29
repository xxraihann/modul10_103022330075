using Microsoft.AspNetCore.Mvc;

namespace modul10_103022330075.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<string> Stars1 = new List<string>
       {
           new string("Tim Robbins"),
           new string("Morgan Freeman"),
           new string("Bob Gunton")
       };
        private static List<Movie> MovieList = new List<Movie>
        {
            new Movie("The Shawshank Redemption","Frank Darabont",Stars1,"A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion.")
            , new Movie("The Godfather","Francis Ford Coppola",Stars2,"The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.")
        ,new Movie("The Dark Knight","Christopher Nolana",Stars3,"When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        private static List<string> Stars2 = new List<string>
        {
            new string("Marlon Brando"),
            new string("Al Pacino"),
            new string("James Caan")

        };


        private static List<string> Stars3 = new List<string>
        {
            new string("Christian Bale"),
            new string("Heath Ledger"),
            new string("Aaron Eckhart")
        };

        [HttpGet]
        public IEnumerable <Movie> Get()
        {
            return MovieList;
        }

        [HttpGet("id")]
        public Movie Get(int id)
        {
            return MovieList[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            MovieList.Add(movie);   
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            MovieList.RemoveAt(id);
        }
       
        
    }
}
