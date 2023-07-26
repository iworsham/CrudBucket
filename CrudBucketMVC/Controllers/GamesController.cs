using Microsoft.AspNetCore.Mvc;
using CrudBucketMVC.DataAccess;
using CrudBucketMVC.Models;

namespace CrudBucketMVC.Controllers
{
    public class GamesController : Controller
    {

        private readonly CrudBucketContext _context;

        public GamesController(CrudBucketContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? genre)
        {
            var games = _context.Games;
           
          
            return View(games);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Game game)
        {
            
            _context.SaveChanges();

          
            var newGameId = game.Id;

            
            return RedirectToAction("show", new { id = newGameId });
        }

      
        [Route("Games/{id:int}")]
        public IActionResult Show(int id)
        {
            var game = _context.Games.Find(id);
            return View(game);
        }
        [Route("Games/{id:int}/edit")]
        public IActionResult Edit(int id)
        {
            var game = _context.Games.Find(id);
            return View(game);
        }
        [HttpPut]
        [Route("Games/{id:int}")]
        public IActionResult Update(int id,Game game)
        {
           game.Id = id;
            _context.Games.Update(game);
            _context.SaveChanges();

            return RedirectToAction("show", new { id = game.Id });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var game = _context.Games.Find(id);
            _context.Games.Remove(game);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

    }
}