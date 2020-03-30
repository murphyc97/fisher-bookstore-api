using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private Services.IBooksRepository booksRepository;
        
        public BooksController(Services.IBooksRepository repository)
        {
            booksRepository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
         return Ok();
        }
    }
}