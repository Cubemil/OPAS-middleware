using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Linq;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseController : ControllerBase
    {
        private readonly OffenseDbContext _context;

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
                
            // split Hausnummer into digits/extra part
            record.SplitHausnummer();

            // adds newly retrieved record to existing records through context
            _context.OffenseRecords.Add(record);
            _context.SaveChanges();

            // retrieve the saved record to ensure RecordId is included
            var savedRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == record.RecordId);

            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich eingetragen.", data = savedRecord });
        }

        // 'GET /api/Offense' -> retrieves all records from the database
        [HttpGet]
        public IActionResult Get()
        {
            var records = _context.OffenseRecords.ToList();
            return Ok(new { message = "Ordnungswidrigkeiten wurden erfolgreich aus der Datenbank geholt.", data = records });
        }

        // 'GET /api/Offense/{id}' -> retrieves a single record from the database by RecordId
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);

            if (record == null)
            {
                return NotFound(new { message = "Ordungswidrigkeit nicht gefunden." });
            }

            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich gefunden.", data = record });
        }
    }
}
