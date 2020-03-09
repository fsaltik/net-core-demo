using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApp.Model;

namespace WebApp.Controller
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new {data = _db.Book.ToList()});
        }
    }
}