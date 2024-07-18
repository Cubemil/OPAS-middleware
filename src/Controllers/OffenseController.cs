using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseController : ControllerBase
    {
        private readonly OffenseDbContext _context;
        private readonly IMapper _mapper;
        
        public OffenseController(OffenseDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // 'POST /api/Offense' -> add new record to database
        [HttpPost]
        public IActionResult Post([FromBody] JsonOffenseRecord record)
        {
            if (record == null)
                return BadRequest(new { message = "Invalid Data." });

            // server side validation
            var validationResults = JsonOffenseRecord.ValidateRecord(record);
            if (validationResults.Count != 0)
                return BadRequest(new { message = "Validation failed.", errors = validationResults });

            // map JsonOffenseRecord to DtoOffenseRecord
            var dtoRecord = _mapper.Map<DtoOffenseRecord>(record);

            // split Hausnummer into digits/extra part
            dtoRecord.SplitHausnummer();

            // add new record to db context
            _context.OffenseRecords.Add(dtoRecord);
            _context.SaveChanges();

            // get saved record to ensure RecordId is included
            var savedRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == dtoRecord.RecordId);

            // no empty record is allowed
            if (savedRecord == null)
                return StatusCode(500, new { message = "Error saving offense." });

            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich eingetragen.", data = savedRecord });
        }

        // 'GET /api/Offense' -> retrieves all records from the database
        [HttpGet]
        public IActionResult Get()
        {
            var records = _context.OffenseRecords.ToList();
            var ids = records.Select(r => r.RecordId);
            return Ok(new { message = "Offenses successfully retrieved.", data = records, ids });
        }

        // 'GET /api/Offense/{id}' -> retrieves a single record from the database by RecordId
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);
            if (record == null)
                return NotFound(new { message = "Offense not found." });

            return Ok(new { message = "Offense found.", data = record });
        }

        // 'PUT /api/Offense/{id}' -> updates a single record in the database by RecordId
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] JsonOffenseRecord updatedRecord)
        {
            if (updatedRecord == null)
                return BadRequest(new { message = "Invalid data. Offense is empty." });

            // server side validation
            var validationResults = JsonOffenseRecord.ValidateRecord(updatedRecord);
            if (validationResults.Count != 0)
                return BadRequest(new { message = "Validation failed.", errors = validationResults });

            var existingRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);
            if (existingRecord == null)
                return NotFound(new { message = "Offense not found." });

            if (existingRecord.RowVersion != updatedRecord.RowVersion)
                return Conflict(new { message = "The offense has been modified by another user." });

            // update existing record with new values
            existingRecord.UpdateRecord(updatedRecord);

            // Save changes to db
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict(new { message = "Conflict: The record has been modified by another user." });
            }

            return Ok(new { message = "Offense successfully updated.", data = existingRecord });
        }
    }
}
