using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
    // router: if api is called in a particular url, this determines what happens
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseController : ControllerBase
    {
        private readonly OffenseDbContext _context;

        // constructor -> adds database context
        public OffenseController(OffenseDbContext context)
        {
            _context = context;
        }

        // 'POST /api/Offense' -> add new record to database
        [HttpPost]
        public IActionResult Post([FromBody] OffenseRecord record)
        {
            if (record == null)
            {
                return BadRequest("Invalid data.");
            }
                
            // adds newly retrieved record to existing records through context
            _context.OffenseRecords.Add(record);
            _context.SaveChanges();
            
            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich eingetragen.", data = record });
        }

        // 'GET /api/Offense' -> retrieves all records from the database
        [HttpGet]
        public IActionResult Get()
        {
            // gets all records in database as list
            var records = _context.OffenseRecords.ToList();
            return Ok(new { message = "Ordnungswidrigkeiten wurden erfolgreich aus der Datenbank geholt.", data = records });
        }
    }
}
