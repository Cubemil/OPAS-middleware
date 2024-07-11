using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Linq;
using System.Collections.Generic;

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
                return BadRequest(new { message = "Invalid data." });
            }

            // Split Hausnummer into digits/extra part
            record.SplitHausnummer();

            // Add the new record to the context
            _context.OffenseRecords.Add(record);
            _context.SaveChanges();

            // Retrieve the saved record to ensure RecordId is included
            var savedRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == record.RecordId);

            // Ensure that no empty record is created
            if (savedRecord == null)
            {
                return StatusCode(500, new { message = "Error saving the record." });
            }

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

        // 'PUT /api/Offense/{id}' -> updates a single record in the database by RecordId
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OffenseRecord updatedRecord)
        {
            if (updatedRecord == null)
            {
                return BadRequest(new { message = "Invalid data. Record is null." });
            }

            // Log received data for debugging
            System.Console.WriteLine($"Received ID: {id}");
            System.Console.WriteLine($"Updated Record ID: {updatedRecord.RecordId}");

            if (id != updatedRecord.RecordId)
            {
                return BadRequest(new { message = "Invalid data. ID mismatch." });
            }

            var existingRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);
            if (existingRecord == null)
            {
                return NotFound(new { message = "Ordungswidrigkeit nicht gefunden." });
            }

            // Server-side validation
            var validationResults = ValidateRecord(updatedRecord);
            if (validationResults.Any())
            {
                return BadRequest(new { message = "Validation failed.", errors = validationResults });
            }

            // Update the existing record with the new values
            existingRecord.UpdateRecord(updatedRecord);

            // Save the changes to the database
            _context.SaveChanges();

            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich aktualisiert.", data = existingRecord });
        }

        private List<string> ValidateRecord(OffenseRecord record)
        {
            var errors = new List<string>();

            // Perform your validation logic here
            if (string.IsNullOrEmpty(record.Fallnummer))
            {
                errors.Add("Fallnummer is required.");
            }
            if (string.IsNullOrEmpty(record.Geschlecht))
            {
                errors.Add("Geschlecht is required.");
            }
            if (string.IsNullOrEmpty(record.Vorname))
            {
                errors.Add("Vorname is required.");
            }
            if (string.IsNullOrEmpty(record.Nachname))
            {
                errors.Add("Nachname is required.");
            }
            if (record.Geburtsdatum == DateTime.MinValue)
            {
                errors.Add("Geburtsdatum is required.");
            }
            if (string.IsNullOrEmpty(record.Str))
            {
                errors.Add("Str is required.");
            }
            if (string.IsNullOrEmpty(record.Hausnummer))
            {
                errors.Add("Hausnummer is required.");
            }
            if (string.IsNullOrEmpty(record.Plz))
            {
                errors.Add("Plz is required.");
            }
            if (string.IsNullOrEmpty(record.Wohnort))
            {
                errors.Add("Wohnort is required.");
            }
            if (string.IsNullOrEmpty(record.Geburtsort))
            {
                errors.Add("Geburtsort is required.");
            }
            if (string.IsNullOrEmpty(record.Versicherungsunternehmensnummer))
            {
                errors.Add("Versicherungsunternehmensnummer is required.");
            }
            if (string.IsNullOrEmpty(record.Krankenversicherung))
            {
                errors.Add("Krankenversicherung is required.");
            }
            if (string.IsNullOrEmpty(record.Versicherungsnummer))
            {
                errors.Add("Versicherungsnummer is required.");
            }
            if (record.Aufforderungsdatum == DateTime.MinValue)
            {
                errors.Add("Aufforderungsdatum is required.");
            }
            if (record.Startdatum == DateTime.MinValue)
            {
                errors.Add("Startdatum is required.");
            }
            if (record.Verzugsende == DateTime.MinValue)
            {
                errors.Add("Verzugsende is required.");
            }
            if (record.Beitragsrueckstand < 0)
            {
                errors.Add("Beitragsrueckstand must be a non-negative integer.");
            }
            if (record.Gesamtsollbetrag < 0)
            {
                errors.Add("Gesamtsollbetrag must be a non-negative integer.");
            }

            return errors;
        }
    }
}
