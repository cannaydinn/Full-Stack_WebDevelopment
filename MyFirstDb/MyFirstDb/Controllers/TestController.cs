using Microsoft.AspNetCore.Mvc;
using MyFirstDb.Context;
using MyFirstDb.Entities;

namespace MyFirstDb.Controllers
{
    public class TestController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public TestController(PatikaFirstDbContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            var newGame = new GameEntity()
            {
                Name = "Test",
                Platform = "TV",
                Rating = 2
            };

            var newMovie = new MovieEntity()
            {
                Title = "Test2",
                Genre = "Test",
                ReleaseYear = 1999
            };

            _context.Games.Add(newGame);
            _context.Movies.Add(newMovie);

            _context.SaveChanges();

            return Ok();
        }
    }
}
