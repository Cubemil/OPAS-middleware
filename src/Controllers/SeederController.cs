using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeederController : ControllerBase
    {
        private OffenseDbContext _context;

        public SeederController(OffenseDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("seed")]
        public IActionResult Seed()
        {
            DatabaseSeeder.Seed(_context);
            return Ok("Database seeded successfully.");
        }
    }

}