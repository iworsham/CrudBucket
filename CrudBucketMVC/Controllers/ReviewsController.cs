using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudBucketMVC.DataAccess;

namespace CrudBucketMVC.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly CrudBucketContext _context;

        public ReviewsController(CrudBucketContext context)
        {
            _context = context;
        }

        
        [Route("Games/{gameId:int}/reviews")]
        public IActionResult Index(int gameId)
        {
            var game = _context.Games
                .Where(g => g.Id == gameId)
                .Include(g => g.Reviews)
                .First();

            return View(game);
        }
        [Route("Games/reviews/new")]
        public IActionResult New()
        {
            return View();
        }
    }
}
