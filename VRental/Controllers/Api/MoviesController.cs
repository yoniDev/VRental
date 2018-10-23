using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VRental.Models;

namespace VRental.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
            
        }

        // GET api/movies
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        //GET api/movie/id
        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return movie;
        }

        //POST api/movies
        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        // PUT api/movies/id
        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if(movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            movieInDb.Name = movie.Name;
            movieInDb.NumbersInStock = movie.NumbersInStock;
            movieInDb.ReleasedDate = movie.ReleasedDate;
            movieInDb.GenreId = movie.GenreId;

            _context.SaveChanges();

        }

        // DELETE api/movies/id
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if(movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
